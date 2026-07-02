using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static bool CodigoValido(string ingresado, string esperando)
        {
            string codigoIngresadoNormalizado = ingresado.Trim().ToUpper();
            string codigoEsperandoNormalizado = esperando.Trim().ToUpper();

            return codigoIngresadoNormalizado.CompareTo(codigoEsperandoNormalizado) == 0;
        }

        static void Main(string[] args)
        {
            Console.Write("Codigo esperado: ");
            string esperado = Console.ReadLine();

            Console.Write("Codigo ingresado: ");
            string ingresado = Console.ReadLine();

            if (CodigoValido(ingresado, esperado))
            {
                Console.WriteLine("Codigo aceptado.");
            }
            else
            {
                Console.WriteLine("Codigo no concide.");
            }
        }
    }
}
