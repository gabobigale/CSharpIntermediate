using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Student studentOver = new Student("Gabriel", "Jimenez");
            
            Console.WriteLine($"Full name is: {student.GetFullName()}");
            Console.WriteLine($"Full name over is: {studentOver.GetFullName()}");
            Console.ReadKey();
        }
    }
}
