using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Config
    {
        public static string BaseDirectory;
        public static string OutputPath;
        public static string VideoPath;

        public static void Load()
        {
            var dir = Directory.GetCurrentDirectory();
            while (!File.Exists(dir + "/config.cfg"))
                dir = Path.GetFullPath(dir + "\\..");

            BaseDirectory = Path.GetFullPath(dir + "\\..") + "/";
            foreach (var line in File.ReadAllLines(dir + "/config.cfg"))
            {
                var spl = line.Split('=');
                switch(spl[0])
                {
                    case "video_path": VideoPath = spl[1]; break;
                    case "output_path": OutputPath = spl[1]; break;
                    default: break;
                }
            }
        }

    }
}
