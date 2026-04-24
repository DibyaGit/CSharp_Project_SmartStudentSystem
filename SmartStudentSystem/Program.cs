using System;

namespace SmartStudentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManager sm = new StudentManager();

            // Adding some starting data
            sm.AddStudent(new Student(101, "Dibya", 85));
            sm.AddStudent(new Student(105, "Rahul", 70));
            sm.AddStudent(new Student(102, "Amit", 95));

            Console.WriteLine("Welcome to Smart Student System");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("1. Show Algorithm Comparison Table");
            Console.WriteLine("2. Sort Students by Marks");
            Console.WriteLine("3. Save First Student to File");
            Console.WriteLine("4. Exit");
            Console.Write("\nChoose an option: ");

            string? choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("\nAlgo | Time Complexity | Space | Best Use");
                Console.WriteLine("Bubble Sort | O(n^2) | O(1) | Small data");
                Console.WriteLine("Linear Search | O(n) | O(1) | Unsorted data");
            }
            else if (choice == "2")
            {
                sm.BubbleSortByMarks();
                Console.WriteLine("Data sorted! (Check the logic in StudentManager)");
            }
            else if (choice == "3")
            {
                FileHelper.WriteToFile(sm[0].ToString());
                FileHelper.ReadFile();
            }

            Console.WriteLine("\nTask complete. Press any key to exit...");
            Console.ReadKey();
        }
    }
}