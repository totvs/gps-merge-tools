using MergeTools.Model;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MergeTools
{
    public class MergeTool
    {
        public string[] LeftReplace { get; set; }  = { };
        public string[] RightReplace { get; set; } = { };

        public MergeTool()
        {
        }

        public string StartMerge(string version, string csv)
        {
            var notExistList = new List<string>();
            var deletedList = new List<string>();
            var lines = new List<string>();
            var bat = "cd " + PathsModel.WinmergePath + "\n";
            var logName = "LogTfsBat.txt";
                        
            using (var sr = new StreamReader(@csv))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    lines.Add(line);
                } 
            }

            ChangeLineToTFSformat(lines);
            
            foreach (var line in lines)
            {
                string[] str = line.Split(';');

                //V11
                var leftFile = str[1];
                //Versão do cliente
                var rightFile = str[1].Replace("V11.0","V11");

                leftFile = leftFile.Replace('/', '\\');

                for (var i = 0; i < LeftReplace.Length - 1; i = i + 2)
                {
                    leftFile = leftFile.Replace(LeftReplace[i], LeftReplace[i + 1]);
                }

                if (Directory.Exists(leftFile)) continue;
                
                rightFile = rightFile.Replace('/', '\\');

                for (var i = 0; i < RightReplace.Length - 1; i = i + 2)
                {
                    rightFile = rightFile.Replace(RightReplace[i], RightReplace[i + 1]);
                }

                //nao cooloca na branch do cliente fontes deletados 
                if (str[0].Contains("del")) continue;

                if (File.Exists(rightFile))
                {
                    //arquivo foi deletado na v11
                    if (!File.Exists(leftFile))
                    {
                        bat += "DEL \"" + new FileInfo(rightFile).DirectoryName + "\"\n";

                        deletedList.Add(line);
                        continue;
                    }
                }
                else
                {
                    //Não existe nas duas branchs
                    if (!File.Exists(leftFile))
                    {
                        continue;
                    }
                }

                if (!File.Exists(rightFile))
                { //se nao existe na branch do cliente
                    notExistList.Add(line);
                    var productRightFile = rightFile;

                    if (!File.Exists(productRightFile))
                    {
                        productRightFile = leftFile; //quer dizer que o arquivo foi criado na v11
                    }

                    FileInfo fileInfo = new FileInfo(rightFile);
                    
                    if (!File.Exists(fileInfo.DirectoryName))
                    {
                        bat += "mkdir \"" + fileInfo.DirectoryName + "\"\n";
                    }

                    bat += "copy /V \"" + productRightFile + "\" \"" + fileInfo.DirectoryName + "\"\n"; 

                    //se foi criado na v11 nao precisa fazer merge
                    if (productRightFile.Equals(leftFile))
                    {
                        continue;
                    }
                }                

               bat += "winmergeu /e /xq \"" + leftFile + "\" \"" + rightFile + "\"\n"; 
            }

            bat += "break>\"" + PathsModel.LogBatPath + logName + "\"\n";
            bat += "cd \""+ PathsModel.TfsPath + "\"\n";

            foreach(var line in lines)
            {
                string[] str = line.Split(';');

                string rightFile = str[1].Replace("V11.0","V11");
                rightFile = rightFile.Replace(RightReplace[0], RightReplace[1]);

                StringBuilder sb = new StringBuilder();
                sb.Append("tf ");

                if (notExistList.Contains(line))
                {
                    sb.Append("add ");
                }
                else if (deletedList.Contains(line))
                {
                    sb.Append("delete ");
                }
                else
                {
                    sb.Append("checkout ");
                }

                sb.Append("/lock:checkin \"");
                sb.Append(rightFile);
                sb.Append("\" >> \"" + PathsModel.LogBatPath + logName + "\" 2>&1");
                sb.Append("\n");
                sb.Append("IF %ERRORLEVEL%==1 set erro=%ERRORLEVEL%");

                bat += sb.ToString() + "\n";
            }

            bat += "if %erro%==1 " + PathsModel.LogBatPath + logName + "\n";
            bat += $"msg * \"Arquivo .bar para versão {version} executado com sucesso.\"";

            var batFile = PathsModel.BatPath + "merge" + version + ".bat";
            using (StreamWriter writer = new StreamWriter(File.Create(batFile)))
            {
                writer.Write(bat);
            }

            return batFile;
        }

        private void ChangeLineToTFSformat(List<string> lines)
        {
            for (int i = 0; i < lines.Count; i++)
            {
                var line = lines[i];

                line = line.Trim().Replace("/", "\\");

                lines[i] = "lock,edit;" + line;
            }
        }
    }    
}
