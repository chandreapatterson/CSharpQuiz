using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGenerator_Sn
{
    public class Question
    {
        public string Text { get; set; }
        public List<string> Choices { get; set; }
        public int AnswerIndex { get; set; } // 1-based index

        public Question(string text, List<string> choices, int answerIndex)
        {
            Text = text;
            Choices = choices;
            AnswerIndex = answerIndex;
        }
    }
}
