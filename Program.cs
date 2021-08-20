using System;

namespace Practical
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Please proved your ICAS number: ");
            int icas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please provide your course name: small change");
            string subject = Console.ReadLine();

            Console.WriteLine("Student " + icas + " is in the " + subject + " course.");
        }
    }
}
