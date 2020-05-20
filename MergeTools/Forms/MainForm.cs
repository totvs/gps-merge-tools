using MergeTools.Model;
using MergeTools.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MergeTools
{
    public partial class MainForm : Form
    {
        public MergeTool MergeTool { get; set; }
        public List<ConvertTFSDataModel> ConvertDirectories { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!PathsModel.FilesExists())
            {
                startMergeButton.Enabled = false;
                removeButton.Enabled = false;
                addVersionButton.Enabled = false;
                return;
            }

            Inicialize();                       
        }

        private void StartMergeButton_Click(object sender, EventArgs e)
        {

            foreach(var version in VersionsList.Items)
            {
                MergeTool = new MergeTool();
                V11toTS(version.ToString());

                try
                {
                    var mergeVersionBat = MergeTool.StartMerge(version.ToString(), csvPath.Text);
                    MessageBox.Show($"Arquivo .bat para versão {version} gerado com sucesso.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (runBat.Checked)
                    {
                        BatUtils.StartBat(mergeVersionBat);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Houve erro na geração do arquivo .bat para versão {version}: {ex}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw ex;
                }
            }

        }       

        private void MainForm_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AddVersionButton_Click(object sender, EventArgs e)
        {

            if (!version.Text.Length.Equals(7))
            {
                MessageBox.Show("Versão no formato incorreto.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            VersionsList.Items.Add(version.Text.Replace(',', '.'));
            startMergeButton.Enabled = true;
            removeButton.Enabled = true;
            version.Text = "";
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            var tempList = new List<string>();

            foreach(var item in VersionsList.Items)
            {
                tempList.Add(item.ToString());
            }

            foreach(var item in VersionsList.CheckedItems)
            {
                tempList.Remove(item.ToString());
            }

            VersionsList.Items.Clear();
            foreach(var item in tempList)
            {
                VersionsList.Items.Add(item);
            }

            removeButton.Enabled = !VersionsList.Items.Count.Equals(0);

        }
        /**
         * Realiza chamada para o form de configurações
         */
        private void ConfigButton_Click(object sender, EventArgs e)
        {            
            using (var form = new ConfigurationForm())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    Inicialize();
                }
            }
        }

        private void Inicialize()
        {
            MergeTool = new MergeTool();
            addVersionButton.Enabled = true;
            startMergeButton.Enabled = false;
            removeButton.Enabled = false;

            var tfsMapping = PathsModel.BatPath + "MapeamentoTFS.bat";

            using (StreamWriter writer = new StreamWriter(File.Create(tfsMapping)))
            {
                writer.WriteLine("cd {0}", PathsModel.TfsPath);
                writer.WriteLine("tf workfold");
            }

            var output = BatUtils.StartBat(tfsMapping,false).StandardOutput.ReadToEnd();
            var formatted = output.Substring(output.IndexOf('$'));
            formatted = formatted.Replace('\r', ' ').Replace('\n', ';');
            var paths = formatted.Split(';');

            File.Delete(tfsMapping);

            ConvertDirectories = new List<ConvertTFSDataModel>();

            foreach (var path in paths)
            {
                if (path.Equals(""))
                {
                    break;
                }

                var directory = path.Replace(": ", ";").Split(';');

                var convert = new ConvertTFSDataModel
                {
                    TfsDirectory = directory[0].Trim(),
                    LocalDirectory = directory[1].Trim()
                };

                ConvertDirectories.Add(convert);
            }
        }

        private void V11toTS(string version)
        {
            foreach (ConvertTFSDataModel convert in ConvertDirectories)
            {
                AddLeftReplace(convert.TfsDirectory, convert.LocalDirectory);
            }

            AddRightReplace("V11\\V11", "V11\\V" + version + "-TS");
            foreach (ConvertTFSDataModel convert in ConvertDirectories)
            {
                AddRightReplace(convert.TfsDirectory, convert.LocalDirectory);
            }
        }

        private void AddLeftReplace(string str, string replacePor)
        {
            MergeTool.LeftReplace = AddReplace(MergeTool.LeftReplace, str, replacePor);
        }

        private void AddRightReplace(string str, string replacePor)
        {
            MergeTool.RightReplace = AddReplace(MergeTool.RightReplace, str, replacePor);
        }

        private string[] AddReplace(string[] array, string str, string replacePor)
        {
            str = str.Replace("/", "\\"); //toLowerCase();
            replacePor = replacePor.Replace("/", "\\"); //toLowerCase();

            string[] arrayAux = new string[array.Length + 2];
            int i = 0;
            for (; i < array.Length; i++)
            {
                arrayAux[i] = array[i];
            }

            arrayAux[i++] = str;
            arrayAux[i] = replacePor;

            return arrayAux;
        }
    }
}
