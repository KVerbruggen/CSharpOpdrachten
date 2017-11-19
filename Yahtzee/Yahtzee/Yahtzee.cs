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
                        score = XOfAKind(3, Dice);
                        break;
                    case ScoreType.FOUROFAKIND:
                        score = XOfAKind(4, Dice);
                        break;
                    case ScoreType.SMALLSTRAIGHT:
                        // TO-DO
                        break;
                    case ScoreType.LARGESTRAIGHT:
                        // TO-DO
                        break;
                    case ScoreType.FULLHOUSE:
                        // TO-DO
                        break;
                    case ScoreType.YAHTZEE:
                        if (IsYahtzee(Dice))
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
                    default:
                        break;
                }
            }
            Scores[CurrentPlayer][((int)scoreType) - 1] = score;

            EndTurn();

            return score;
        }

        private void EndTurn()
        {
            CurrentPlayer = (CurrentPlayer + 1) % nrOfPlayers;
            CurrentRoll = 0;
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
