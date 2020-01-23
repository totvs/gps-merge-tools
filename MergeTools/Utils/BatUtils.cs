using System.Diagnostics;

namespace MergeTools.Utils
{
    public static class BatUtils
    {
        public static Process StartBat(string file, bool showConsole = true)
        {
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = file;

            if (!showConsole)
            {
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                p.StartInfo.CreateNoWindow = true;
            }
                
            p.Start();

            return p;
        }
        
    }
}
