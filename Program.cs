using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juegodeadivinar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int random = rnd.Next(1,100);
            Console.WriteLine(random);
            int intentos = 5;
            int usuario;
            do {
                    Console.WriteLine("Ingrese un número con el que desee participar (solo entre 1 y 99)");
                    usuario = int.Parse(Console.ReadLine());
                if (usuario < 1 || usuario > 99)
                {
                    Console.WriteLine("Aviso: Ingrese un número solo dentro del rango por favor");
                }
                else
                {
                    if (random > usuario)
                    {
                        Console.WriteLine("El número que busca es mayor");
                        intentos--;
                       
                    }
                    else
                    {
                        if (random < usuario) 
                        {
                            Console.WriteLine("El número que busca es menor");
                            intentos--;
                           
                        }
                       
                    }
                }
            } while (random != usuario && intentos > 0);
            if (intentos == 0)
            {
                Console.WriteLine("Lamentablemente ha agotado sus intentos, el número era: {0}",random);
            }
            if (random == usuario)
            { 
                Console.WriteLine("Felicidades adivino el número era: {0}", random); 
            }
            Console.ReadKey();
        }
    }
}
