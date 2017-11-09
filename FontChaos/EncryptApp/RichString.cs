using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FontChaos
{
    public struct RichString
    {
        public string Content { get; private set; }
        public Font Font { get; private set; }

        public RichString(string content, Font font)
        {
            Content = content;
            Font = font;
        }
    }
}
