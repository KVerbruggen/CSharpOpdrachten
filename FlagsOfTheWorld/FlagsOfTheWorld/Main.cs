using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FlagsOfTheWorld
{
    public static class Main
    {
        public static List<Flag> flags = new List<Flag>();

        public static void LoadFlags()
        {
            Dictionary<string, string> data;

            string separator = ": ";

            foreach (string file in Directory.GetFiles(@"resources/nations/"))
            {
                data = new Dictionary<string, string>();
                foreach (string datarow in File.ReadAllLines(file))
                {
                    string property = datarow.Split(new string[] { separator }, StringSplitOptions.None)[0];
                    string value = string.Join(": ", datarow.Split(new string[] { separator }, StringSplitOptions.None).Skip(1).ToArray());
                    data.Add(property, value);
                }
                if (data.ContainsKey("ID") && data.ContainsKey("Name"))
                {
                    if (data["ID"] != String.Empty && data["Name"] != String.Empty)
                    {
                        string id = data["ID"];
                        string name = data["Name"];
                        string image = @"resources/flags/" + data["ID"] + ".png";
                        Flag flag = new Flag(id, name, image);
                        if (flag.Image != null) {
                            flags.Add(new Flag(id, name, image));
                        }
                    }
                }
                
            }
        }

        /*
        // Code gebruikt om tekstbestanden met info te genereren adhv vlaggen
        public static void createFiles()
        {
            DirectoryInfo di = new DirectoryInfo(@"resources/flags/");
            List<FileInfo> files = di.EnumerateFiles().ToList<FileInfo>();
            foreach (FileInfo fi in files)
            {
                string id = Path.GetFileNameWithoutExtension(fi.Name);
                StreamWriter sw = File.CreateText(@"../../resources/flags" + id + ".txt");
                sw.WriteLine("ID: " + id);
                sw.WriteLine("Name: ");
                sw.Close();
            }
        }
        */
    }
}
