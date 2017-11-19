using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee
{
    public class ButtonScore : Button
    {
        public ScoreType ScoreType { get; private set; }

        public ButtonScore(ScoreType scoreType)
        {
            ScoreType = scoreType;
        }

        public ButtonScore(int scoreType) : this((ScoreType)scoreType)
        {
        }

    }
}
