using System;

namespace CCAD16Demothing
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, please check out this Assignment 1.1.");
            Console.WriteLine("");
            Console.WriteLine("Please enter your name.");
            string myName = Console.ReadLine();
            Console.WriteLine("");
            // This is a note
            Console.WriteLine(myName);
            Console.WriteLine("");
            Console.WriteLine("Please enter your age.");
            double myage = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("It's just a number anyways.");
            Console.WriteLine("");
            Console.WriteLine("How tall are you?");
            string myheight = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Also, what is your current address?");
            string myaddress = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine($"So to conclude {myName}, you are {myage} years old and are {myheight}, currently located at {myaddress}.");
            Console.WriteLine("");
            Console.WriteLine("Do you have any questions?");
            string question = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("This concludes this practice program for assignment 1.1.");
            Console.WriteLine("");
            Console.WriteLine("Just kidding, now lets do math.");
            Console.WriteLine("");
            Console.WriteLine("Now please give me a number.");
            string first = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Now please give another number.");
            string second = Console.ReadLine();


            Console.WriteLine("");
            Console.WriteLine($"So, {first}+{second}.);
            Console.WriteLine();

        }
    }
}
