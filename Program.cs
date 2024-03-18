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
                int sum = 0;
                foreach (int grade in grades)
                {
                    sum += grade;
                    Console.WriteLine("sum");
                }
            }


        }

    }
   
}
