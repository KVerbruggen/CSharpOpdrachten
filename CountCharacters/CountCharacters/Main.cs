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

        public static Dictionary<string, int> LoadFile(string[] fileLocations, out int characterCount)
        {
            characterCount = 0;

            string data = String.Empty;
            Dictionary<string, int> characterFrequencyDictionary = new Dictionary<string, int>();

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
                    if (characterFrequencyDictionary.ContainsKey(stringToAdd))
                    {
                        characterFrequencyDictionary[stringToAdd]++;
                    }
                    else
                    {
                        characterFrequencyDictionary.Add(stringToAdd, 1);
                    }
                    characterCount++;
                }
            }

            return characterFrequencyDictionary;

        }


    }
}
