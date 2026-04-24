using System;
using System.IO;

namespace SmartStudentSystem
{
    public static class FileHelper
    {
        private static string fileName = "Records.txt";

        public static void WriteToFile(string data)
        {
            File.WriteAllText(fileName, data);
            Console.WriteLine("Data successfully saved to Records.txt");
        }

        public static void ReadFile()
        {
            if (File.Exists(fileName))
            {
                string content = File.ReadAllText(fileName);
                Console.WriteLine("\n--- Stored File Content ---");
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine("No file found to read.");
            }
        }
    }
}