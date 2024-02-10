using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Question
    {

        public string Header { get; set; }
        public string Body { get; set; }
        public double Mark { get; set; }
        public Answers[] Answers { get; set; }
        public int CorrectAnswer { get; set; }

        public Question()
        {

        }
        public Question(string header, string body, double mark, Answers[] answers, int correctAnswer)
        {
            Header = header;
            Body = body;
            Mark = mark;
            Answers = answers;
            CorrectAnswer = correctAnswer;
        }

        public Question[] CreateQuestionsOfExam(int NumberOfQuestion)
        {
            Question[] questions = new Question[NumberOfQuestion];
            for (int i = 0; i < NumberOfQuestion; i++)
            {
                questions[i] = new Question();
            }
            return questions;
        }

        public void InserDataOfQuestions(Question[] questions, int ExamType)
        {
            for (int i = 0; i < questions.Length; i++)
            {
                string header, body;
                double Mark;
                int CorrectAnswer;

                if (ExamType == 1) // final 
                {
                    Console.Write($"Question {i+1}:  (True||False) => 1 Or (MCQ) Questions =>2: ");
                    int typeOfQuestions;
                    bool flage;
                    do
                    {
                        flage = int.TryParse(Console.ReadLine(), out typeOfQuestions);
                    } while (!flage);

                    if (typeOfQuestions == 1)
                    {
                        header = "(True||False) Questions";
                        Console.Write("Enter Body Of Question: ");
                        body = Console.ReadLine();

                        do
                        {
                            Console.Write("Enter Mark of Question: ");
                            flage = double.TryParse(Console.ReadLine(), out Mark);
                        } while (!flage);


                        int NumberOfAnswers = 2;

                        Answers ans = new Answers();
                        Answers[] x = ans.CreateAnswersOfQuestions(NumberOfAnswers);
                        Answers[] AnswerData = ans.InsertDataInAnswers(x, 1);
                        questions[i].Answers = AnswerData;

                        Console.Write("What is the Correct Answer (True)=>1 (False)=> 0 : ");
                        do
                        {
                            flage = int.TryParse(Console.ReadLine(), out CorrectAnswer);
                        } while (!flage);
                        Console.WriteLine("-------------------------------------------------------------");
                        questions[i].Header = header;
                        questions[i].Body = body;
                        questions[i].Mark = Mark;
                        questions[i].CorrectAnswer = CorrectAnswer;

                    }

                    else if(typeOfQuestions==2)
                    {
                        header = "Mcq Quesions";
                        Console.Write("Enter Body Of Question: ");
                        body = Console.ReadLine();

                        do
                        {
                            Console.Write("Enter Mark of Question: ");
                            flage = double.TryParse(Console.ReadLine(), out Mark);
                        } while (!flage);


                        int NumberOfAnswers;

                        Console.Write("Number Of Answers: ");
                        do
                        {
                            flage = int.TryParse(Console.ReadLine(), out NumberOfAnswers);
                        } while (!flage);

                        Answers ans = new Answers();
                        Answers[] x = ans.CreateAnswersOfQuestions(NumberOfAnswers);
                        Answers[] AnswerData = ans.InsertDataInAnswers(x, 2);

                        questions[i].Answers = AnswerData;

                        Console.Write("What is the Correct Answer: ");
                        do
                        {
                            flage = int.TryParse(Console.ReadLine(), out CorrectAnswer);
                        } while (!flage);

                        questions[i].Header = header;
                        questions[i].Body = body;
                        questions[i].Mark = Mark;
                        questions[i].CorrectAnswer = CorrectAnswer;

                    }
              

                }

                else if (ExamType == 2) // practical
                {
                    bool flage;
                    header = "Mcq Quesions";
                    Console.Write($"Enter Body Of Question{i+1}: ");
                    body = Console.ReadLine();

                    do
                    {
                        Console.Write("Enter Mark of Question: ");
                        flage = double.TryParse(Console.ReadLine(), out Mark);
                    } while (!flage);


                    int NumberOfAnswers;

                    Console.Write("Number Of Answers: ");
                    do
                    {
                        flage = int.TryParse(Console.ReadLine(), out NumberOfAnswers);
                    } while (!flage);

                    Answers ans = new Answers();
                    Answers[] x = ans.CreateAnswersOfQuestions(NumberOfAnswers);
                    Answers[] AnswerData = ans.InsertDataInAnswers(x, 2);

                    questions[i].Answers = AnswerData;

                    Console.Write("What is the Correct Answer: ");
                    do
                    {
                        flage = int.TryParse(Console.ReadLine(), out CorrectAnswer);
                    } while (!flage);


                    questions[i].Header = header;
                    questions[i].Body = body;
                    questions[i].Mark = Mark;
                    questions[i].CorrectAnswer = CorrectAnswer;
                }


            }

        }

    }

}


