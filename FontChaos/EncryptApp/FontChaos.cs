using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Text;

namespace FontChaos
{
    public static class FontChaos
    {
        private static float minFontSize = 16;
        private static float maxFontSize = 20;

        private static FontCollection InstalledFonts { get; set; }

        private static Random Random;

        static FontChaos()
        {
            Random = new Random();
            InstalledFonts = new InstalledFontCollection();
        }

        public static RichString[] Chaotify(string input)
        {
            RichString[] output = new RichString[input.Length];
            int i = 0;
            for(int index = 0; i < input.Length; i++)
            {
                int subStringSize = Random.Next(1, 3);
                if ((index + subStringSize) > input.Length)
                {
                    subStringSize = input.Length - index;
                }
                output[i] = randomizeString(input.Substring(index, subStringSize), Random);
                if (subStringSize == (input.Length - index))
                {
                    break;
                }
                index += subStringSize;
            }
            Array.Resize<RichString>(ref output, i + 1);
            return output;
        }

        public static RichString randomizeString(string input, Random random)
        {
            float randomEmSize = random.Next(Convert.ToInt32(minFontSize * 100), Convert.ToInt32(maxFontSize * 100)) / 100;
            FontFamily randomFontFamily = InstalledFonts.Families[random.Next(InstalledFonts.Families.Length)];
            FontStyle randomFontStyle = (FontStyle)random.Next(Convert.ToInt32(FontStyle.GetValues(typeof(FontStyle)).Cast<FontStyle>().Last<FontStyle>()));

            Font randomFont = new Font(randomFontFamily, randomEmSize, randomFontStyle);
            return new RichString(input, randomFont);
        }
    }
}
