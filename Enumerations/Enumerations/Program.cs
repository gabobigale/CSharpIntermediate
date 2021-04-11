using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Santhi Como estas ?");
            Console.WriteLine("TU PUEDES TODO LO QUE TE PROPONGAS");

            Console.WriteLine("Que quieres hacer");
            Console.WriteLine("Si deseas suma presiona 1, resta presiona 2");
            int opcion = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa el primer numero");
            long num1 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo numero");
            long num2 = Convert.ToInt64(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine($"La suma es: {num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($"La resta es: {num1 - num2}");
                    break;
                default:
                    break;
            }

            Console.ReadKey();

        }
    }
}
