using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C__Exam.Question;

namespace C__Exam.Exam
{
    internal abstract class Base_Exam
    {
        public DateTime Time_of_exam { get;  set; }
        public int Number_of_Questions { get;  set; }
        public List<Base_Question> questions { get; set; }  //Aggregation
        public Subject? Subject { get; set; }
        public Base_Exam()
        {
            questions = new List<Base_Question>();
        }
        public Base_Exam(DateTime timeOfExam, int numberOfQuestions, List<Base_Question>? _questions)
        {
            Time_of_exam = timeOfExam;
            Number_of_Questions = numberOfQuestions;
            questions = _questions ?? new List<Base_Question>();
        }
        public abstract void ShowExam();
        public void AddQuestion(Base_Question q)
        {
            if (questions is not null)
                if (questions.Count < Number_of_Questions)
                    questions.Add(q);
        }
        public abstract void StartExam();
    }
}
