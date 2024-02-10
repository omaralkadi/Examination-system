using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }

        public Exaam ExamOfTheSubject { get; set; }

        public void CreateExam()
        {
            bool flage;
            int type,time,numerOfQuestions;
            do
            {
                Console.Write("Select Type Of Exam You Want To Create (1 for Final 2 for practical): ");
                flage = int.TryParse(Console.ReadLine(),out type);
            } while (!flage);

            do
            {
                Console.Write("Enter Time Of Exam in Minutes: ");
                flage = int.TryParse(Console.ReadLine(), out time);
            } while (!flage);

            do
            {
                Console.Write("Number Of Questions: ");
                flage = int.TryParse(Console.ReadLine(), out numerOfQuestions);
            } while (!flage);

            if (type == 1)
            {
                Exaam exam = new FinalExam(time,numerOfQuestions); 

                this.ExamOfTheSubject = exam;

            }
            else if (type == 2)
            {
                Exaam exam = new PracticalExam(time, numerOfQuestions);

                this.ExamOfTheSubject = exam;
            }
          
        }
        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }


    }
}
