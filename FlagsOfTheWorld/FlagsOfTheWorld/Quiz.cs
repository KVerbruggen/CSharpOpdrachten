using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace FlagsOfTheWorld
{
    public class Quiz
    {
        private List<Flag> Flags { get; set; }
        public int Score { get; private set; }
        public int QuestionIndex { get; private set; }

        public Quiz(List<Flag> flags)
        {
            Flags = new List<Flag>();
            Flags = flags.ToList();
            Main.Shuffle(Flags);
            QuestionIndex = 0;
        }

        public Quiz(List<Flag> flags, int amountOfQuestions)
        {
            Flags = new List<Flag>();
            Flags = flags.ToList();
            Main.Shuffle(Flags);
            Flags = Flags.Take(amountOfQuestions).ToList();
            QuestionIndex = 0;
        }

        public int GetQuestionCount()
        {
            return Flags.Count;
        }

        public Flag GetNextQuestion()
        {
            Flag answer = null;
            if (Flags.Count == 0 || QuestionIndex > Flags.Count - 1)
            {
                answer = null;
            }
            else
            {
                answer = Flags[QuestionIndex];
            }
            return answer;
        }

        public bool Answer(string input)
        {
            bool isCorrect = false;
            foreach(string country in Flags[QuestionIndex].Country)
            {
                if (string.Compare(country, input, CultureInfo.CurrentCulture, CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace) == 0)
                {
                    Score++;
                    isCorrect = true;
                }
            }
            QuestionIndex++;
            return isCorrect;
        }

        public bool CheckFinished()
        {
            return Flags.Count == 0 || QuestionIndex > Flags.Count - 1;
        }

        public int GetMaxScore()
        {
            return Flags.Count;
        }


    }
}
