using System;

namespace EvenorOddChecker
{
    internal class Program
    {
        public static string OddEvenChecker(string number)
        {
            string result = "";
            try
            {
                int intnumber = Convert.ToInt32(number);
                if (intnumber % 2 == 1)
                    result = "odd";
                else
                    result = "even";
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Entered value must be an integer. Error: " + ex.Message);
                Console.WriteLine();
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Entered value was too large. Please enter a value less than 2.4 billion. Error: " + ex.Message);
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong. Error: " + ex.Message);
                Console.WriteLine();
            }
            return result;
        }
        static void Main(string[] args)
        {
            string evenOrOdd;
            do
            {
                Console.WriteLine("Even or Odd Checker\n");
                Console.Write("Enter an integer: ");
                string number = Console.ReadLine();
                evenOrOdd = OddEvenChecker(number);
            }
            while (evenOrOdd == "");
            Console.WriteLine("This is an " + evenOrOdd + " number");
        }
    }
}
