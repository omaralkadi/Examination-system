using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal abstract class Exaam
    {
        public double TimeOfExam { get; set; }
        public int NumOfQuestion { get; set; }
        public abstract Question[] FillExam();

        public abstract void StartExam(Question[] ques);

        protected Exaam(double timeOfExam, int numOfQuestion)
        {
            TimeOfExam = timeOfExam;
            NumOfQuestion = numOfQuestion;
        }





    }
}
