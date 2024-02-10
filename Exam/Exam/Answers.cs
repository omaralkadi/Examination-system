using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Answers
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }

        public Answers()
        {

        }
        public Answers(int answerId, string answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        }

        public Answers[] CreateAnswersOfQuestions(int NumberOfAnswers)
        {
            Answers[] ans = new Answers[NumberOfAnswers];
            for (int i = 0; i < NumberOfAnswers; i++)
            {
                ans[i] = new Answers();
            }
            return ans;
        }

        public Answers[] InsertDataInAnswers(Answers[] ans, int number)
        {
            if (number == 2)
            {
                for (int i = 0; i < ans.Length; i++)
                {
                    if (number == 2)
                    {
                        bool flage;
                        int answerId;
                        do
                        {
                            Console.Write("Enter Answer Number: ");
                            flage = int.TryParse(Console.ReadLine(), out answerId);
                        } while (!flage);

                        Console.Write("Enter Answer Body: ");
                        string body = Console.ReadLine();

                        ans[i].AnswerId = answerId;
                        ans[i].AnswerText = body;

                    }

                }
            }
            else if (number == 1)
            {
                for (int i = 0; i < 2; i++)
                {
                    ans[0].AnswerId = 1;
                    ans[0].AnswerText = "True";

                    ans[1].AnswerId = 0;
                    ans[1].AnswerText = "False";

                }

            }

            return ans;


        }


    }
}
