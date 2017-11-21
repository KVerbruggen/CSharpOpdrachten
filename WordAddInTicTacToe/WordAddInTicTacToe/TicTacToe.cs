using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordAddInTicTacToe
{
    public class TicTacToe
    {
        private int currentPlayer;
        public int?[,] Field { get; private set; }
        public int CurrentPlayer
        {
            get { return currentPlayer; }
            private set
            {
                currentPlayer = value % 2;
            }
        }
        public TicTacToe()
        {
            Field = new int?[3, 3];
        }

        public bool Play(int x, int y)
        {
            if (Field[x, y] == null)
            {
                Field[x, y] = CurrentPlayer;
                return true;
            }
            return false;
        }

        public void EndTurn()
        {
            CurrentPlayer++;
        }

        public int CheckFinish(int x, int y)
        {
            if (Field[x, 0] == Field[x, 1] && Field[x, 0] == Field[x, 2])
            {
                return 1;
            }
            else if (Field[0, y] == Field[1, y] && Field[0, y] == Field[2, y])
            {
                return 2;
            }
            else if (Field[0, 0] != null && Field[0, 0] == Field[1, 1] && Field[0, 0] == Field[2, 2])
            {
                return 3;
            }
            foreach (int? i in Field)
            {
                if (i == null)
                {
                    return 0;
                }
            }
            return -1;
        }
    }
}
