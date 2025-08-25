using System.Text.RegularExpressions;
using C__Exam.Exam;
using C__Exam.Question;

namespace C__Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
        


            Console.WriteLine("Enter Subject Name:");
            string subjectName = Console.ReadLine()! ;

            Subject subject = new Subject(1, subjectName);

           
          
            bool valid_number = false;
            int examType;
            do
            {
                Console.WriteLine("Please enter a valid exam type (1 for Final, 2 for Practical):");
                valid_number = int.TryParse(Console.ReadLine(), out  examType);
               
            } while (!valid_number || (examType != 1 && examType != 2));
           

  
            int duration;
            do
            {
                Console.WriteLine("Enter Exam Duration in minutes (30-180):");
                duration = int.Parse(Console.ReadLine()!);
            } while (duration < 30 || duration > 180);



            bool valid_02 = false;
            int num_of_qestions;
            do
            {
                Console.WriteLine("Please enter Number of Questions ");
                valid_02 = int.TryParse(Console.ReadLine(), out num_of_qestions);

            } while (!valid_02 || num_of_qestions<=0 );



            List<Base_Question> questions = new List<Base_Question>();



            for (int i = 0; i < num_of_qestions; i++)
            {
                Console.WriteLine($"\nQuestion {i + 1}:");
              
                bool valid_03 = false;
                int qType;
                do
                {
                    Console.WriteLine("Enter Question Type (1 for True/False, 2 for MCQ):");
                    valid_03 = int.TryParse(Console.ReadLine(), out qType);

                    if(examType == 2 && qType == 1)
                    {
                        Console.WriteLine("Invalid input. For Practical exam only MCQ is allowed.");
                        valid_03 = false;
                       
                    }

                } while (!valid_03 || (qType != 1 && qType != 2));

                

                Console.WriteLine("Enter Question Body:");
                string body = Console.ReadLine()!;

              

                bool v = false;
                decimal mark;
                do
                {
                    Console.WriteLine("Enter Question Mark:");
                    v = decimal.TryParse(Console.ReadLine(), out mark);

                } while (!v || mark <= 0);

                if (qType == 1)
                {
                    bool correct;
                    string? input;

                    do
                    {
                        Console.WriteLine("Enter Correct Answer (true/false only ):");
                        input = Console.ReadLine();

                        if (!bool.TryParse(input, out correct))
                        {
                            Console.WriteLine("Invalid input. Please enter true/false only.");
                        }

                    } while (!bool.TryParse(input, out correct));

                   
                    if (questions is not null)
                        questions.Add(new True_OR_Fasle("True or False Question", body, mark, correct));

                }
                else if (qType == 2)
                {
                    List<Answer> answers = new List<Answer>();

                    bool valid_04 = false;
                    int numChoices;
                    do
                    {
                        Console.WriteLine("Enter number of choices:");
                        valid_04 = int.TryParse(Console.ReadLine(), out numChoices);

                    } while (!valid_04 || numChoices <= 0);

                   
                    for (int j = 0; j < numChoices; j++)
                    {
                        Console.WriteLine($"Choice {j + 1} text:");

                        string ansText = Console.ReadLine()!;

                        answers.Add(new Answer(j + 1, ansText));
                    }

                    bool valid_05 = false;
                    int correctIndex;
                    do
                    {
                        Console.WriteLine("Enter Correct Answer number (1-based index):");
                        valid_05 = int.TryParse(Console.ReadLine(), out correctIndex);
                      
                    } while (!valid_05 || correctIndex <= 0 || correctIndex > numChoices);
                 
                   
                    if(questions is not null)
                    questions.Add(new Mcq_Class("Mcq Question", body, mark, answers, correctIndex));
                }
            }

            Base_Exam exam;
            DateTime examTime = DateTime.Now.AddSeconds(duration); 
            if (examType == 1)
                exam = new Final(examTime, num_of_qestions, questions);
            else
                exam = new Practical(examTime, num_of_qestions, questions);

            subject.CreateExam(exam);
            Console.WriteLine("\n--- Exam Created ---");
            Console.WriteLine("==================================");
            exam.ShowExam();
           
            Console.WriteLine("Do you want start exam now (Y / N)?");
            bool valid006 = false;
            char ch;
            do
            {
                valid006 = char.TryParse(Console.ReadLine(), out ch);
                if (!valid006 || (ch != 'y' && ch != 'Y' && ch != 'n' && ch != 'N'))
                {
                    Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
                }
            } while (!valid006 || (ch != 'y' && ch != 'Y' && ch != 'n' && ch != 'N'));
            if (ch == 'y' || ch == 'Y')
            {
                exam.StartExam();
                Console.WriteLine("Thank You ");
                Console.WriteLine("==================================");
            }
            else if (ch == 'N' || ch == 'n')
            {
                Console.WriteLine("You can start the exam later.");
            }
            

         
        }
    }
}
