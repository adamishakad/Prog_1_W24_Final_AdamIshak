using System.Diagnostics;
using System.Xml.Serialization;

namespace Prog_1_W24_Final_AdamIshak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] studentName = { "Alice", "Bob", "Charlie", "David", "Eve" };
            int[] grades = { 85, 92, 78, 88 };

            while (true)
            {
                //Console.WriteLine("1. Display all names, grades, and letter grades");
                //Console.WriteLine("2. Display average grade and letter grade");
                //Console.WriteLine("3. Change a grade");
                //Console.WriteLine("4. Exit");

               // Console.Write("Enter your choice: ");
               //int choice = int.Parse(Console.ReadLine());

               // Console.WriteLine("Display All studentNames, grades");
                //Console.WriteLine("Display Average AndLetter Grade grades");
                //Console.WriteLine("Exiting program");
               // Console.WriteLine("Menu");
                //Console.WriteLine("Invalid choice. Please try again.");

                

            }
            static void DisplayAll(string[] names, int[] grades)
            {
                Console.WriteLine("All names, grades, and letter grades:");
                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine($"Name: {names[i]}, Grade: {grades[i]}, Letter Grade: {(grades[i])}");

                }
                static void DisplayAverageAndLetterGrade(int[] grades)
                {
                    int sum = 0;
                    foreach (int grade in grades)
                    {
                        sum += grade;
                    }
                    double average = (double)sum / grades.Length;

                    Console.WriteLine($"Average grade: {average}, Letter Grade: {((int)average)}");
                }
                static void ChangeGrade(string[] names, int[] grades)
                {
                    Console.Write("Enter the name of the student whose grade you want to change: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter the new grade: ");
                    int newGrade = int.Parse(Console.ReadLine());

                    for (int i = 0; i < names.Length; i++)

                        if (names[i] == name)
                        {
                            grades[i] = newGrade;
                            Console.WriteLine($"Grade for {name} changed to {newGrade}");
                        }
                }

                //static char GetLetterGrade(int grade)
                //if (grade >= 90)
                {
                    Console.WriteLine("A");
                }
                 else if (grade >= 80)
                {
                    Console.WriteLine("B");
                }
                else if (grade >= 70)
                {
                    Console.WriteLine("C");
                }
                else if (grade >= 60)
                {
                    Console.WriteLine("D");
                }
                else (grades >= 50)
                {
                    Console.WriteLine("F");
                }


            }
            


        }

    }
   
}
