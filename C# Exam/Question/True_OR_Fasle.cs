using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace C__Exam.Question
{
    internal class True_OR_Fasle : Base_Question
    {
        public bool CorrectAnswer { get; set; }

        public True_OR_Fasle(string header, string body, decimal mark, bool correctAnswer)
        : base(header, body, mark)
        {
           
            CorrectAnswer = correctAnswer;
        }

        public override void Display()
        {
            Console.WriteLine($"The Header of the Question = {Header_of_the_question}");
            Console.WriteLine($"The Body of the Question = {Body_of_the_question}");
            Console.WriteLine($"The Grade of the Question = {Mark}");
            Console.WriteLine($"The Correct answer = {CorrectAnswer}");
      
        }
        public override bool CheckAnswer(object userAnswer)
        {
            if (userAnswer == null)
                return false;
            bool choice = (bool)userAnswer;
            return choice == CorrectAnswer;
        }




    }
}
