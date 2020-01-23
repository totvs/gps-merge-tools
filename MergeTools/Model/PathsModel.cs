using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeTools.Model
{
    public static class PathsModel
    {
        public static string BatPath { get => Properties.Settings.Default.BAT_PATH; set => Properties.Settings.Default.BAT_PATH = value; }
        public static string LogBatPath { get => Properties.Settings.Default.LOG_TFS_BAT_PATH; set => Properties.Settings.Default.LOG_TFS_BAT_PATH = value; }
        public static string TfsPath { get => Properties.Settings.Default.TFS_PATH; set => Properties.Settings.Default.TFS_PATH = value; }
        public static string WinmergePath { get => Properties.Settings.Default.WINMERGE_PATH; set => Properties.Settings.Default.WINMERGE_PATH = value; }
        
        public static bool FilesExists()
        {
            return (Directory.Exists(BatPath) && Directory.Exists(LogBatPath) && Directory.Exists(TfsPath) && Directory.Exists(WinmergePath));
        }

        public static bool FilesExists(List<string> directorys)
        {
            foreach(var directory in directorys)
            {
                if (!Directory.Exists(directory))
                {
                    return false;
                }
            }

            return true;
        }

        public static string FormatDirectory(string directory)
        {
            if (!directory.EndsWith("\\"))
            {
                return directory + "\\";
            }

            return directory;
        }
        
    }      
    
    
}
