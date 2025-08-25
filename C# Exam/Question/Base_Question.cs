using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace C__Exam.Question
{
    internal abstract class  Base_Question
    {
       public string? Header_of_the_question { get; set; }
        public string? Body_of_the_question { get; set; }
        public decimal Mark { get; set; }
        public List<Answer>? Answers_List { get; set; }

        protected Base_Question()
        {

        }
        public Base_Question(string header, string body, decimal mark)
        {
            Header_of_the_question = header;
            Body_of_the_question = body;
            Mark = mark;
        }


        public Base_Question(string Header_of_the_question, string Body_of_the_question, decimal Mark, List<Answer> Answers_List)
        {
            this.Header_of_the_question = Header_of_the_question;
            this.Body_of_the_question = Body_of_the_question;
            this.Mark = Mark;
            this.Answers_List = Answers_List;

        }



        public abstract void Display();


        public abstract bool CheckAnswer(object userAnswer);


    }
}
