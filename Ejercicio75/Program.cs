using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio75
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool verdad = true;
            string Vacio = "";
            Stack<string> pila = new Stack<string>();
            while (verdad)
            {
                Console.WriteLine("Ingresa un dato alfanúmerico");
                string Dato = Console.ReadLine();
                if (Dato == Vacio)
                {
                    verdad = false;
                }
                else
                {
                    pila.Push(Dato);
                }
            }
            while (pila.Count > 0)
            {
                string dato = pila.Pop();
                Console.WriteLine(dato);
            }
        }
    }
}
