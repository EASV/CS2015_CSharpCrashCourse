using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    public class ConsoleMenu
    {
        private List<Question> questions;
        public ConsoleMenu(List<Question> questions = null)
        {
            this.questions = questions ?? new List<Question>();
        }

        public Dictionary<int, Question> ListQuestions() {
            var questionDictionary = new Dictionary<int, Question>();
            int position = 1;
            string menuMessage = "Welcome to the Menu, select a question below";
            foreach (var question in questions)
            {
                questionDictionary.Add(position, question);
                position++;
                string.Join(
                Environment.NewLine,
                menuMessage,
                question.GetQuestionText());
            }
            return questionDictionary;
        }

        public void ExecuteQuestionAnswer(Question q)
        {
            q.GetQuestionAnswer();
        }

        public void ClearMenu()
        {
            Console.Clear();
        }
    }
}
