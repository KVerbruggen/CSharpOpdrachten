using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace FlagsOfTheWorld
{
    public class Flag
    {

        #region Properties

        public string Id { get; private set; }
        public string[] Country { get; private set; }
        public Image Image { get; private set; }

        #endregion

        #region constructors

        private Flag(string id, string[] countryNames)
        {
            Id = id;
            Country = countryNames;
        }

        public Flag(string id, string[] countryNames, Image image) : this(id, countryNames)
        {
            Image = image;
        }

        public Flag(string id, string[] countryNames, string imageURI) : this(id, countryNames)
        {
            Image = Main.TryImageFromFile(imageURI);
        }

        public Flag(string id, string countryName, Image image) : this(id, new string[1] { countryName }, image)
        { }
        public Flag(string id, string countryName, string imageURI) : this(id, new string[1] { countryName }, imageURI)
        { }

        #endregion

    }
}
