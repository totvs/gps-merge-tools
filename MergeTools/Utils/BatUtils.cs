using System.Diagnostics;

namespace MergeTools.Utils
{
    public static class BatUtils
    {
        public static Process StartBat(string file)
        {
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = file;
            p.Start();

            return p;
        }
        
    }
}
