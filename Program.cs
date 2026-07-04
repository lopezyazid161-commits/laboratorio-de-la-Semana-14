using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio04_sem14
{
    internal class Programt
    {
        static string NormalizarCodigo(string codigo)
        {
            codigo = codigo.Trim();
            codigo =codigo.Replace("-", "");
            codigo = codigo.ToUpper();


            return codigo;
        }
        static bool TieneLongitudValida(string codigo)
        {
            return codigo.Length == 8;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un código de comprobante: ");
            string codigoIngresado = Console.ReadLine();

            string  codigoNormalizado = NormalizarCodigo(codigoIngresado);
            Console.WriteLine("Código normalizado: " + codigoNormalizado);
            if ( TieneLongitudValida(codigoNormalizado))
            {
                Console.WriteLine("Codigo valido ");
            }
            else
            {
                Console.WriteLine("Código inválido. Debe tener 8 caracteres.");
            }
            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey(); 
        }  
    }
}

