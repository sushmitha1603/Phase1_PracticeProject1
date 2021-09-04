using System;
using System.IO;

namespace student
{
    class Program
    {
        static void Main(string[] args)
        {
            string fpath = @"C:\Practice_project\Student.txt";
            StreamReader sr = new StreamReader(fpath);
            string fileContent = sr.ReadToEnd();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*****Welcome to Rainbow School**** \n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Displaying the student details");
            Console.WriteLine(fileContent);       
            sr.Close();
        }
    }
}
