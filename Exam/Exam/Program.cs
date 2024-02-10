using Exam;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Subject sub=new Subject(1,"c#");
        sub.CreateExam();
        Question[] questions=sub.ExamOfTheSubject.FillExam();
        sub.ExamOfTheSubject.StartExam(questions);

    }
}

