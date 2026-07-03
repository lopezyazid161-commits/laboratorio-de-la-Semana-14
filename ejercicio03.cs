using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static bool ContieneClave(string comentario, string clave)
        {
            // Normalización del comentario: quitar espacios extremos y convertir a minúsculas.
            string texto = comentario.Trim().ToLower();

            // Normalización de la palabra clave.
            string buscar = clave.Trim().ToLower();

            // Método que verifica si 'texto' contiene la palabra clave 'buscar'.
            return texto.Contains(buscar);
        }

        static void Main()
        {
            Console.Write("Ingrese el comentario del estudiante: ");
            // Lectura del comentario.
            string comentario = Console.ReadLine();

            Console.Write("Ingrese la palabra clave a buscar: ");
            // Lectura de la palabra clave.
            string clave = Console.ReadLine();

            // Llamada a la función.
            if (ContieneClave(comentario, clave))
            {
                Console.WriteLine("El comentario contiene la palabra clave.");
            }
            else
            {
                Console.WriteLine("El comentario no contiene la palabra clave.");
            }
        }
    }
}
