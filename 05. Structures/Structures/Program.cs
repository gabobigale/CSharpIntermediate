using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Example of structure");

            Console.WriteLine("Hours:");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Minutes:");
            int minutes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Seconds:");
            int seconds = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Display time structure");
            Time time = new Time(hours, minutes, seconds);
            time.PrintTime();

            Console.ReadKey();
        }
    }
}
