//Escribe un programa que determine si un año ingresado por el usuario es bisiesto o no (los años bisiestos son aquellos que son multiplos de 4,
//exceptuando los multipos de 100, los multiplos de 400 si son bisiestos

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un año para saber si es bisiesto o no: ");
            int ano = int.Parse(Console.ReadLine());

            if (ano % 4 == 0 && (ano % 100 != 0 || ano % 400 == 0))
            {
                Console.WriteLine("El año que ingreso {0}, es un año bisiesto.", ano);
            }

            else
            {
                Console.WriteLine("El año que ingreso {0}, no es un año bisiesto.", ano);
            }
            Console.ReadKey();
        }

    }
}
