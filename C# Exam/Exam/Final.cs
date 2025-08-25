using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using C__Exam.Question;

namespace C__Exam.Exam
{
    internal class Final: Base_Exam
    {
        public Final(DateTime timeOfExam, int numberOfQuestions, List<Base_Question>? _questions) : base(timeOfExam, numberOfQuestions,_questions)
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
            Console.WriteLine($"--- Starting Final Exam for {Subject?.SubjectName} ---");
            decimal totalMarks = 0;

            foreach (var q in questions)
            {
                q.Display();
               

                bool isCorrect = false;

                if (q is True_OR_Fasle tf)
                {
                    Console.Write("Enter answer (true/false only): ");
                    string? input;
                    bool userAnswer;

                    do
                    {
                        input = Console.ReadLine();

                        if (!bool.TryParse(input, out userAnswer))
                        {
                            Console.WriteLine("Invalid input. Please enter 'true' or 'false' only.");
                            Console.Write("Enter answer (true/false only): ");
                        }

                    } while (!bool.TryParse(input, out userAnswer));

                    
                    isCorrect = tf.CheckAnswer(userAnswer);


                }
                else if (q is Mcq_Class mcq)
                {
                    int userAnswer;
                    bool validInput = false;

                    do
                    {
                        Console.Write("Enter Correct Answer number (1-based index):");
                        string? userInput = Console.ReadLine();

                        if (int.TryParse(userInput, out userAnswer))
                        {
                            if (mcq.Answers_List != null)
                            {
                                if (userAnswer >= 1 && userAnswer <= mcq.Answers_List?.Count)
                                {
                                    isCorrect = mcq.CheckAnswer(userAnswer);
                                    validInput = true;
                                }
                                else
                                {
                                    Console.WriteLine(" Invalid choice. Please enter a number within the range of options.");
                                }
                            }
                           
                        }
                    } while (!validInput);
                }


                if (isCorrect)
                {
                    totalMarks += q.Mark;
                    Console.WriteLine(" Correct Answer \n");
                    Console.WriteLine("==================================");
                }
                else
                {
                    Console.WriteLine($" Wrong Answer");
                    Console.WriteLine("==================================");
                }
            }

            decimal maxMarks = 0;
            foreach (var q in questions)
                maxMarks += q.Mark;

            Console.WriteLine($"Final Grade: {totalMarks}/{maxMarks}");


        }

    }
}
