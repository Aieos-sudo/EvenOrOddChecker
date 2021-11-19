using System;

namespace EvenorOddChecker
{
    internal class Program
    {
        public static string OddEvenChecker(string number)
        {
            int intnumber = Convert.ToInt32(number);
            if (intnumber % 2 == 1)
                return "odd";
            else
                return "even:";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Even or Odd Checker\n");
            Console.Write("Enter an integer: ");
            string number = Console.ReadLine();
            string evenOrOdd = OddEvenChecker(number);
            Console.WriteLine("This is an " + evenOrOdd +" number");
        }
    }
}
