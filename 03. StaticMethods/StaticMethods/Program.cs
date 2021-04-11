using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StaticMethods
{
    public static class StringExtensions
    {
        public static string FirstLetterUpperCaseStatic(this string word)
        { 
            //upper letter
            word = Char.ToUpper(word[0]) + word.Substring(1);

            //Console.WriteLine($"UpperCase Letter: {word}");
            return word;
        }
    }

    class Program
    {
        public const int constNumber = 20;

        public static void SqrtNumber()
        {
            Console.WriteLine("Enter a number for SQRT:");
            int number = Convert.ToInt32(Console.ReadLine());

            double result = Math.Sqrt(number);
            Console.WriteLine($"Sqrt number of {number} is: {result}");
        }

        public static void FirstLetterUpperCase()
        {
            Console.WriteLine("Enter a word:");
            string word = Console.ReadLine();

            //upper letter
            word = Char.ToUpper(word[0]) + word.Substring(1);
            Console.WriteLine($"UpperCase Letter: {word}");
        }

        public static void FirstLetterUpperCaseStatic()
        {
            Console.WriteLine("Enter a word:");
            string word = Console.ReadLine();

            //upper letter
            //word = Char.ToUpper(word[0]) + word.Substring(1);
            word.FirstLetterUpperCaseStatic();
            Console.WriteLine($"UpperCase Letter as Extension: {word}");
        }
        
        static void Main(string[] args)
        {
            //(Ctrl + K + C (comment) / Ctrl + K + U (uncomment))

            //if we try to modify, we can't  
            //constNumber = 200;
            //Can't create a instance of a static class
            //TestClass testClass = new TestClass();

            Console.WriteLine("Menu: 1. SqrtNumber, 2. FirstLetterUpper");
            int numberMenu = Convert.ToInt32(Console.ReadLine());

            switch (numberMenu)
            {
                case 1:
                    //Sqrt method
                    SqrtNumber();
                    break;
                case 2:
                    //First Letter Uppercase method
                    FirstLetterUpperCase();
                    break;
                case 3:
                    //Extension method (i use 2 lines to understand)
                    FirstLetterUpperCaseStatic();
                    break;
                default:
                    Console.WriteLine("None Choice");
                    break;
            }

            Console.ReadKey();
        }
    }
}
