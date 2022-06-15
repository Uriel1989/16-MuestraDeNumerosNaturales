using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _16_MuestraDeNumerosNaturales
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;


            Console.WriteLine("Ingrese un numero entero y positivo: ");

            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {

                Console.WriteLine("Los numeros naturales son: " + i);
            }
            Console.ReadKey();
        }
    }
}
