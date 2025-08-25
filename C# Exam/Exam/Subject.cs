using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Exam.Exam
{
    internal class Subject
    {
        public int SubjectId { get; set; }      
        public string? SubjectName { get; set; } 
        public Base_Exam? Exam { get; set; }

        public Subject(int id, string name)
        {
            SubjectId = id;
            SubjectName = name;
        }
        public void CreateExam(Base_Exam exam)
        {
            if (exam is not null)
            {
                Exam = exam;
                exam.Subject = this;
            }
        }

   
      



    }
}
