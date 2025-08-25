using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C__Exam.Question;

namespace C__Exam.Exam
{
    internal class Practical : Base_Exam
    {
        public Practical(DateTime timeOfExam, int numberOfQuestions, List<Base_Question>? _questions)
        : base(timeOfExam, numberOfQuestions, _questions)
        { }
        public override void ShowExam()
        {
            if (Subject != null)
            {
                Console.WriteLine($"--- Final Exam for {Subject.SubjectName}");
            }
            Console.WriteLine($"Time: {Time_of_exam}");
            Console.WriteLine($"Number of Questions: {Number_of_Questions}");
            Console.WriteLine("========================================");


        }
        public override void StartExam()
        {
            Console.WriteLine($"\n--- Starting Practical Exam for {Subject?.SubjectName} ---");

          
            List<Mcq_Class> answeredQuestions = new List<Mcq_Class>();

            foreach (var q in questions)
            {
                q.Display();

                if (q is Mcq_Class mcq)
                {
                    int userAnswer;
                    bool validInput = false;

                   
                    do
                    {
                        if(mcq.Answers_List == null || mcq.Answers_List.Count == 0)
                        {
                            Console.WriteLine("No answers available for this question.");
                            break;
                        }

                        Console.Write($"Enter your choice (1-based index) ");
                        string? input = Console.ReadLine();

                        if (int.TryParse(input, out userAnswer) &&
                            userAnswer >= 1 && userAnswer <= mcq.Answers_List.Count)
                        {
                            validInput = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a number within the range.");
                        }

                    } while (!validInput);

                
                    answeredQuestions.Add(mcq);
                }
            }
            Console.WriteLine("============================================");
            
            Console.WriteLine("\n--- Correct Answers and Question Details ---");
            foreach (var mcq in answeredQuestions)
            {
                
                Console.WriteLine($"The Header of the question: {mcq.Header_of_the_question}");
                Console.WriteLine($"The Body of the question: {mcq.Body_of_the_question}");
                Console.WriteLine($"The Correct Answer is in index : {mcq.CorrectAnswerId} ");
                Console.WriteLine("============================================");
            }
        }


    }
}

