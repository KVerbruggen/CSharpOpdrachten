using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace FlagsOfTheWorld
{
    public class Category
    {
        #region Properties

        public Image Icon { get; private set; }
        public string Name { get; private set; }
        public List<Flag> Flags { get; private set; }

        #endregion

        #region constructors

        public Category(string name, Image icon)
        {
            Name = name;
            Icon = icon;
            Flags = new List<Flag>();
        }

        public Category(string name, string iconURI)
        {
            Name = name;
            Icon = Main.TryImageFromFile(iconURI);
            Flags = new List<Flag>();
        }

        #endregion

        #region Custom getters/setters

        public void AddFlag(Flag flag)
        {
            Flags.Add(flag);
        }

        public void SetFlags(List<Flag> flags)
        {
            Flags = flags;
        }

        public void AddFlags(string[] flagIDs)
        {
            foreach (String flagID in flagIDs)
            {
                foreach (Flag flag in Main.flags)
                {
                    if (flag.Id == flagID)
                    {
                        AddFlag(flag);
                    }
                }
            }
        }

        #endregion

    }
}
