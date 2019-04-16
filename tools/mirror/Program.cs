using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using System.Security.Cryptography;
using System.IO;

namespace mirror
{
    class Program
    {
        static void Main(string[] args)
        {
            Config.Load();
            var videos = Data.LoadVideos();
            if (args[0] == "-g")
            {
                Console.WriteLine("Generating hashes...");
                foreach (var v in videos)
                {
                    if (v.FileExists)
                    {
                        Console.WriteLine("Generating hash for " + v.Diskfile);
                        v.sha1 = Data.StreamSHA1(v.Diskfile); ;
                        Console.WriteLine(v.sha1);
                    }
                }
                videos.Save();
            }

            if(args[0] == "-v")
            {
                Console.WriteLine("Validating video files...");
                foreach (var v in videos)
                {
                    if (!v.FileExists)
                    {
                        Console.WriteLine(v.title + " is missing!");
                        continue;
                    }
                    if (!v.ValidateHash)
                    {
                        Console.WriteLine(v.Diskfile + " - the checksum doesn't match!");
                        continue;
                    }
                    Console.WriteLine(v.Diskfile + " is OK");
                }
                Console.ReadKey();
            }

            //videos.Save();

        }
    }
}
