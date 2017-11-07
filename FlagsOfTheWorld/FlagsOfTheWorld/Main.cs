using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace FlagsOfTheWorld
{
    public static class Main
    {
        public static List<Flag> flags;
        public static List<Category> categories;
        private static Random random;

        static Main()
        {
            flags = new List<Flag>();
            categories = new List<Category>();
            categories.Add(new Category("World", @"resources/categories/icons/world.png"));
            categories[0].SetFlags(flags);
            random = new Random();
        }

        public static void Shuffle<T>(this IList<T> list)
        {
            // Shuffle through Fisher-Yates implementation.
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public static void ConvertCoordinates(Form form1, Form form2)
        {
            form2.Top = form1.Top + Convert.ToInt32((form1.Size.Height - form2.Size.Height) * 0.5);
            form2.Left = form1.Left + Convert.ToInt32((form1.Size.Width - form2.Size.Width) * 0.5);
        }

        public static Image TryImageFromFile(string URI)
        {
            Image image;
            try
            {
                image = Image.FromFile(URI);
            }
            catch (FileNotFoundException)
            {
                image = null;
            }
            return image;
        }

        private static bool CheckPropertyIsNotEmpty(string[] property)
        {
            return !property.Equals(Array.Empty<string>()) && property[0] != String.Empty;
        }

        public static void LoadCategories()
        {
            Dictionary<string, string[]> data;

            foreach (string file in Directory.GetFiles(@"resources/categories/"))
            {
                data = FileReader.ReadProperties(file);
                string icon = "";
                if (data.ContainsKey("Name") && CheckPropertyIsNotEmpty(data["Name"]))
                {
                    string name = data["Name"][0];
                    if (data.ContainsKey("Icon") && CheckPropertyIsNotEmpty(data["Icon"]))
                    {
                        icon = @"resources/categories/icons/" + data["Icon"][0];
                    }
                    Category category = new Category(name, icon);
                    categories.Add(category);
                    if (data.ContainsKey("FlagIDs") && CheckPropertyIsNotEmpty(data["FlagIDs"]))
                    {
                        category.AddFlags(data["FlagIDs"]);
                    }
                }
            }
        }

        public static void LoadFlags()
        {
            Dictionary<string, string[]> data;

            foreach (string file in Directory.GetFiles(@"resources/nations/"))
            {
                data = FileReader.ReadProperties(file);
                if (data.ContainsKey("ID") && data.ContainsKey("Name") && CheckPropertyIsNotEmpty(data["ID"]) && CheckPropertyIsNotEmpty(data["Name"]))
                {
                    string id = data["ID"][0];
                    string[] name = data["Name"];
                    string image = @"resources/nations/flags/" + id + ".png";
                    Flag flag = new Flag(id, name, image);
                    if (flag.Image != null) {
                        flags.Add(flag);
                    }
                }
            }

            // Order flaglist using Linq - based on: https://stackoverflow.com/questions/3309188/how-to-sort-a-listt-by-a-property-in-the-object
            flags = flags.OrderBy(flag => flag.Country[0]).ToList();
        }

        /*
        // Code gebruikt om tekstbestanden met info te genereren adhv vlaggen
        public static void createFiles()
        {
            DirectoryInfo di = new DirectoryInfo(@"resources/nations/flags/");
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
