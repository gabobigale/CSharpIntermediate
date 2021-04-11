using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Properties Program");
           
            Student student = new Student("Gabriel", "Jimenez");
            Console.WriteLine($"Initial Name: {student.Name} {student.LastName}");
            Console.WriteLine();

            Console.WriteLine("Access to modifiers Program");
            Console.WriteLine("Set new Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Set new LastName: ");
            string lastName = Console.ReadLine();

            student.Name = name;
            student.LastName = lastName;
            Console.WriteLine($"New Name: {student.Name} {student.LastName}");

            Console.ReadKey();
        }
    }
}
