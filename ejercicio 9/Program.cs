using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nota;
            Console.WriteLine("ingrese una nota:");
            nota = Convert.ToInt32(Console.ReadLine()); 

            while (nota<0 || nota > 20) 
            {
                Console.WriteLine("el valor es incorrecto");
                Console.WriteLine("ingrese una nota entre 0 y 20:");
                nota = Convert.ToInt32(Console.ReadLine());
            }
            if (nota >= 16)
            {
                Console.WriteLine("excelente");
            }
            else if (nota == 14 || nota == 15)
            { Console.WriteLine("Muy Bueno")}
            else if (nota >= 11 || nota <= 13)
            { Console.WriteLine("Bueno")
                    }
            else {
                Console.WriteLine("insuficiente")}
        }
    }
}
