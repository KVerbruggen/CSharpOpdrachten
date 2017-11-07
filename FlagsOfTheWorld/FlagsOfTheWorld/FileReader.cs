using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FlagsOfTheWorld
{
    public static class FileReader
    {
        private static string separator = ": ";
        private static string valueSeparator = ", ";

        public static Dictionary<string, string[]> ReadProperties(string file)
        {
            Dictionary<string, string[]> data = new Dictionary<string, string[]>();
            foreach (string datarow in File.ReadAllLines(file))
            {
                string property = datarow.Split(new string[] { separator }, StringSplitOptions.None)[0];
                string valueString = string.Join(": ", datarow.Split(new string[] { separator }, StringSplitOptions.None).Skip(1).ToArray());
                string[] value = valueString.Split(new string[] { valueSeparator }, StringSplitOptions.None);
                data.Add(property, value);
            }
            return data;
        }
    }
}
