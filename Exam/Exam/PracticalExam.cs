using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class PracticalExam : Exaam //mcq
    {
        
        public PracticalExam(double timeOfExam, int numOfQuestion) : base(timeOfExam, numOfQuestion)
        {
            
        }

        public override Question[] FillExam()
        {
            Question question = new Question();
            Question[] ques = question.CreateQuestionsOfExam(NumOfQuestion);
            question.InserDataOfQuestions(ques, 2);

            return ques;

        }

        public override void StartExam(Question[] ques)
        {
            Console.Clear();
            Console.Write("Do you Want To Stat Exam(Y|N): ");
            if (Console.ReadLine().Equals("y", StringComparison.OrdinalIgnoreCase))
            {
                List<int> result = new List<int>();

                for (int i = 0; i < ques.Length; i++)
                {
                    Console.WriteLine($"{ques[i].Header} \n{ques[i].Body}");
                    for (int j = 0; j < ques[i].Answers.Length; j++)
                    {
                        Console.Write($"{ques[i].Answers[j].AnswerId}-{ques[i].Answers[j].AnswerText}             ");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("-----------------------------------------------------------");

                    bool flage;
                    int res;
                    do
                    {
                        Console.Write("Chosse the Correct Answer: ");
                        flage = int.TryParse(Console.ReadLine(), out res);
                        Console.WriteLine("-------");

                    } while (!flage);

                    result.Add(res);

                }

                double Usermark = 0;
                double TotalMark = 0;
                for (int x = 0; x < ques.Length; x++)
                {
                    TotalMark += ques[x].Mark;
                    if (ques[x].CorrectAnswer == result[x])
                    {
                        Usermark += ques[x].Mark;
                    }
                }
                Console.WriteLine($"=============Your Exam Grade is {Usermark} from {TotalMark}================");

                Console.WriteLine("=============================================================");

            }
            else
            {
                Console.WriteLine("See You Again!!!");
            }

            Console.WriteLine("Correct Answers !");
            for (int i = 0; i < ques.Length; i++)
            {

                Console.WriteLine($"{ques[i].Header} \n{ques[i].Body}");
                Console.WriteLine($"Correcr Answer: {ques[i].CorrectAnswer}");
                Console.WriteLine("-----------------------------------------------------------");

            }


        }

    }

}
