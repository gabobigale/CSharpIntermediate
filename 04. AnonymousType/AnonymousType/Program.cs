using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousType
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable anonymous
            var myAnonymousObj = new { Name = "Jhon", Age = 32 };

            var number = 15; // the number is of type int
            var word = "example"; //the word is of type string
            var money = 987.32; //the money is of type double

            //Nullable types
            int? numberNull = null; // with this (?) can assign a null into a var
            int anotherNum = 500;
            //anotherNum = numberNull; //Can't assign a int nullable into a int not nullable

            Console.WriteLine($"The name of myAnonymousObject is {myAnonymousObj.Name}, the age is {myAnonymousObj.Age}");

            //Validation of a nullable variable
            Console.WriteLine("Show a variable with nullable type");
            if (numberNull.HasValue) //retunr true or false
            {
                Console.WriteLine(numberNull.Value);
            }
            else
            {
                Console.WriteLine("Has a null value");
            }

            Console.ReadKey();
        }
    }
}
