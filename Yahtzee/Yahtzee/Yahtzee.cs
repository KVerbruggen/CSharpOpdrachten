using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    public enum UpperScoreType
    {
        THREEOFAKIND,
        FOUROFAKIND,
        SMALLSTRAIGHT,
        LARGESTRAIGHT,
        FULLHOUSE,
        YAHTZEE
    }

    public class Yahtzee
    {
        private Random random = new Random();
        private bool gameStarted = false;
        private bool hadYahtzee = false;
        private int currentPlayer = 1;
        private int nrOfPlayers = 0;

        private int[] TotalScore { get; set; }
        private int[] Dice { get; set; }
        public int NrOfPlayers
        {
            get { return nrOfPlayers;  }
            set
            {
                if (!gameStarted && value <= 6)
                {
                    nrOfPlayers = value;
                }
            }
        }

        public Yahtzee(int nrOfPlayers = 1)
        {
            Dice = new int[5];
            this.nrOfPlayers = nrOfPlayers;
        }

        public int[] RollDice(bool[] rollDie)
        {
            if (!gameStarted)
            {
                TotalScore = new int[nrOfPlayers];
                Array.Clear(TotalScore, 0, TotalScore.Count());
            }
            for (int i = 0; i < Dice.Count(); i++)
            {
                if (rollDie[i])
                {
                    Dice[i] = random.Next(1, 7);
                }
            }
            return Dice;
        }

        public int[] RollDice()
        {
            return RollDice(new bool[] { true, true, true, true, true });
        }

        public int CalculateScore(int lowerScoreType, int[] dice)
        {
            int score = 0;
            foreach (int die in dice)
            {
                if (die == lowerScoreType)
                {
                    score += lowerScoreType;
                }
            }
            TotalScore[currentPlayer] += score;

            currentPlayer = (currentPlayer + 1) % nrOfPlayers;

            return score;
        }

        public int CalculateScore(UpperScoreType upperScoreType, int[] dice)
        {
            int score = 0;
            switch (upperScoreType)
            {
                case UpperScoreType.THREEOFAKIND:
                    score = XOfAKind(3, dice);
                    break;
                case UpperScoreType.FOUROFAKIND:
                    score = XOfAKind(4, dice);
                    break;
                case UpperScoreType.SMALLSTRAIGHT:
                    // TO-DO
                    break;
                case UpperScoreType.LARGESTRAIGHT:
                    // TO-DO
                    break;
                case UpperScoreType.FULLHOUSE:
                    // TO-DO
                    break;
                case UpperScoreType.YAHTZEE:
                    if (IsYahtzee(dice))
                    {
                        if (hadYahtzee)
                        {
                            score = 100;
                        }
                        else
                        {
                            hadYahtzee = true;
                            score = 50;
                        }
                    }
                    break;
            }
            TotalScore[currentPlayer] += score;

            currentPlayer = (currentPlayer + 1) % nrOfPlayers;

            return score;
        }

        private static bool IsYahtzee(int[] dice)
        {
            for (int i = 1; i < dice.Count(); i++)
            {
                if (dice[i] != dice[0])
                {
                    return false;
                }
            }
            return true;
        }

        private static int XOfAKind(int x, int[] dice)
        {
            int score = 0;
            int[] amountOfNumber = new int[6] { 0, 0, 0, 0, 0, 0 };
            foreach (int die in dice)
            {
                amountOfNumber[die - 1]++;
                score += die;
            }
            foreach (int numberAmount in amountOfNumber)
            {
                if (numberAmount >= x)
                {
                    return score;
                }
            }
            return 0;
        }
    }
}
