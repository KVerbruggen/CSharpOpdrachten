using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Globalization;

namespace CountCharacters
{
    public static class Main
    {

        public static int LoadFile(string[] fileLocations, out Dictionary<string, int> characterFrequencies)
        {
            int characterCount = 0;

            string data = String.Empty;
            characterFrequencies = new Dictionary<string, int>();

            foreach (string fileLocation in fileLocations)
            {
                StreamReader fileReader = new StreamReader(fileLocation, true);
                if (File.Exists(fileLocation))
                {
                    data = fileReader.ReadToEnd();
                    fileReader.Close();
                }
                else
                {
                    throw new FileNotFoundException();
                }
                foreach (char character in data)
                {
                    string stringToAdd;
                    if (!Char.IsLetterOrDigit(character) && !Char.IsPunctuation(character) && !Char.IsSymbol(character))
                    {
                        if ((int)character == 32)
                        {
                            stringToAdd = "Space";
                        }
                        else
                        {
                            stringToAdd = "\\u" + ((int)character).ToString("x4");
                        }
                    }
                    else
                    {
                        stringToAdd = character.ToString();
                    }
                    if (characterFrequencies.ContainsKey(stringToAdd))
                    {
                        characterFrequencies[stringToAdd]++;
                    }
                    else
                    {
                        characterFrequencies.Add(stringToAdd, 1);
                    }
                    characterCount++;
                }
            }

            return characterCount;

        }


    }
}
