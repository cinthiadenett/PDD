using System;
using System.Xml;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();

            int dado = 1;
            if (dado == 1)
            {
                string mensaje = "te ganaste un auto";
                Console.WriteLine(mensaje);

            }
            else if (dado == 2)
            {
                string mensaje = "te ganaste una moto";
                Console.WriteLine(mensaje);

            }
            else 
            {
               string mensaje = "segui particípando";
            }
            Console.WriteLine(mensaje); 
        }
    }
}
