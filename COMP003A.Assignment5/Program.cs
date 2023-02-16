/*
 * Author: Matthew Tan
 * Course: COMP003A
 * Purpose: Assignment Week 5
 * 
*/
using System.Transactions;

namespace COMP003A.Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("\tTriangle Section");
            Console.WriteLine("".PadRight(50, '*'));
            Console.Write("Enter a single character: ");
            string inputCharacter = Console.ReadLine();
            Console.Write("Enter a positive whole number: ");
            int limit = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= limit; i++)
            {
                Console.WriteLine(inputCharacter);
                inputCharacter +=;
            }
        } // main close

        /// <summary>
        /// PrintSeparator() method with no parameters and return value
        /// </summary>
        static void PrintSeparator()
        {
            Console.WriteLine("**************************************************");
        }

        /// <summary>
        /// PrintSeparator() with one string parameters and no value
        /// </summary>
        /// <param name="separator">Separated input</param>
        static void PrintSeparator(string separator)
        {
            PrintSeparator(separator);
            PrintSeparator();
        }
    }
}