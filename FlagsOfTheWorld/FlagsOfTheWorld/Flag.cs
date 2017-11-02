using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FlagsOfTheWorld
{
    public class Flag
    {
        public Image Image { get; private set; }
        public String Id { get; private set; }
        public String Name { get; private set; }

        public Flag(String id, String name, Image image)
        {
            Image = image;
            Id = id;
            Name = name;
        }

        public Flag(String id, String name, String imageURI)
        {
            Id = id;
            Name = name;
            try {
                Image = Image.FromFile(imageURI);
            }
            catch (FileNotFoundException)
            {
                Image = null;
            }

        }

    }
}
