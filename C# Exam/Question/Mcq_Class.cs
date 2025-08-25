using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace C__Exam.Question
{
    internal class Mcq_Class : Base_Question
    {
        public int CorrectAnswerId { get; set; }


        public Mcq_Class(string header, string body, decimal mark, List<Answer> answers, int correctAnswerId)
            : base(header, body, mark)
        {
            Answers_List = answers;
            CorrectAnswerId = correctAnswerId;
        }




        public override void Display()
        {
           
            Console.WriteLine($"The Body of the Question = {Body_of_the_question}");
           
            Console.WriteLine("The Choices is ");
            if (Answers_List != null)
            {
                for (int i = 0; i < Answers_List.Count; i++)
                {
                    Console.WriteLine($"{Answers_List[i].AnswerId}. {Answers_List[i].AnswerText}");
                }
            }
            Console.WriteLine($"The Grade of the Question = {Mark}");
           

        }

        public override bool CheckAnswer(object userAnswer)
        {
            if (userAnswer == null)
                return false;
            int choice = (int)userAnswer;
            return choice == CorrectAnswerId;
        }

    }
}
