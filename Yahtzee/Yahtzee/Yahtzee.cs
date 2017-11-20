using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    public enum ScoreType
    {
        UPPERONE = 1,
        UPPERTWO = 2,
        UPPERTHREE = 3,
        UPPERFOUR = 4,
        UPPERFIVE = 5,
        UPPERSIX = 6,
        THREEOFAKIND = 7,
        FOUROFAKIND = 8,
        SMALLSTRAIGHT = 9,
        LARGESTRAIGHT = 10,
        FULLHOUSE = 11,
        YAHTZEE = 12
    }

    public class Yahtzee
    {
        private Random random = new Random();

        private bool gameStarted = false;
        private bool hadYahtzee = false;
        private int nrOfPlayers = 0;

        public int?[][] Scores { get; private set; }
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
        public int CurrentPlayer { get; private set; }
        public int CurrentRoll { get; private set; }

        public Yahtzee(int nrOfPlayers = 1)
        {
            Dice = new int[5];
            this.nrOfPlayers = nrOfPlayers;
        }

        public void StartGame()
        {
            Scores = new int?[nrOfPlayers][];
            for (int i = 0; i < nrOfPlayers; i++)
            {
                Scores[i] = new int?[Enum.GetNames(typeof(ScoreType)).Length];
            }
            gameStarted = true;
            CurrentPlayer = 0;
            CurrentRoll = 0;
            Dice = new int[5];
        }
        public int[] RollDice(bool[] diceToRoll = null)
        {
            diceToRoll = diceToRoll ?? new bool[]{ true, true, true, true, true };
            if (!gameStarted)
            {
                StartGame();
            }
            CurrentRoll = (CurrentRoll + 1) % 4;
            if (CurrentRoll == 0)
            {
                return null;
            }
            for (int i = 0; i < Dice.Count(); i++)
            {
                if (diceToRoll[i])
                {
                    Dice[i] = random.Next(1, 7);
                }
            }
            return Dice;
        }

        private int CalculateScore(int upperScoreType)
        {
            int score = 0;
            foreach (int die in Dice)
            {
                if (die == upperScoreType)
                {
                    score += upperScoreType;
                }
            }

            return score;
        }

        public int CalculateScore(ScoreType scoreType)
        {
            int score = 0;
            if ((int)scoreType <= 6)
            {
                score = CalculateScore((int)scoreType);
            }
            else
            {
                switch (scoreType)
                {
                    case ScoreType.THREEOFAKIND:
                        if(IsXOfAKind(3, Dice))
                        {
                            score = Dice.Sum();
                        }
                        break;
                    case ScoreType.FOUROFAKIND:
                        if (IsXOfAKind(4, Dice))
                        {
                            score = Dice.Sum();
                        }
                        break;
                    case ScoreType.SMALLSTRAIGHT:
                        if (HasConsecutiveFaces(4, Dice))
                        {
                            score = 30;
                        }
                        break;
                    case ScoreType.LARGESTRAIGHT:
                        if (HasConsecutiveFaces(5, Dice))
                        {
                            score = 40;
                        }
                        break;
                    case ScoreType.FULLHOUSE:
                        if (IsFullHouse(Dice))
                        {
                            score = 25;
                        }
                        break;
                    case ScoreType.YAHTZEE:
                        /*
                        // deprecated function
                        if (IsYahtzee(Dice))
                        */
                        if (IsXOfAKind(5, Dice))
                        {
                            if (hadYahtzee)
                            {
                                score = 100;
                            }
                            else
                            {
                                score = 50;
                                hadYahtzee = true;
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            Scores[CurrentPlayer][((int)scoreType) - 1] = score;

            return score;
        }

        public void EndTurn()
        {
            CurrentPlayer = (CurrentPlayer + 1) % nrOfPlayers;
            CurrentRoll = 0;
        }

        /*
        // Deprecated function "IsYahtzee". Not necessary because of IsXOfAKind, but slightly faster.
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
        */
        
        /*
        // New possible short version for IsYahtzee. Still not necessary because of IsXOfAkind
        private static bool IsYahtzee(int[] dice)
        {
            return NumberAmounts(dice).Contains(5);
        }
        */

        private static bool IsXOfAKind(int x, int[] dice)
        {
            // Check if collection contains item larger than x.
            // Based on: https://stackoverflow.com/questions/13972621/check-whether-the-list-contains-item-greater-than-a-value-in-c-sharp
            return NumberAmounts(dice).Any(number => number >= x);
        }

        private static int[] NumberAmounts(int[] dice)
        {
            int[] numberAmount = new int[6] { 0, 0, 0, 0, 0, 0 };
            foreach (int die in dice)
            {
                numberAmount[die - 1]++;
            }
            return numberAmount;
        }

        private static bool HasConsecutiveFaces(int amountOfConsecutiveFaces, int[] dice)
        {
            int lowestFace = dice.Min();
            for (int i = 0; i < amountOfConsecutiveFaces; i++)
            {
                int currentFaceToCheck = lowestFace + i;
                bool found = false;
                foreach (int die in dice)
                {
                    if (die == currentFaceToCheck)
                    {
                        found = true;
                    }
                }
                if (!found)
                {
                    return false;
                }
            }
            return true;
        }

        private static bool IsFullHouse(int[] dice)
        {
            int[] numberAmount = NumberAmounts(dice);
            return (numberAmount.Contains(3) && numberAmount.Contains(2));
        }

        public int GetTotalScore(int player)
        {
            int totalScore = 0;
            foreach (int? i in Scores[player])
            {
                if (i != null)
                {
                    totalScore += (int)i;
                }
            }
            return totalScore;
        }
    }
}
