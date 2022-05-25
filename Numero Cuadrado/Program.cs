using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero_Cuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            // Alumno: Jorge Octavio Antunez Partida - 21211910

            // Declaracion de Variables
            int num;
            bool rep;

            do // Ciclo do-while asta no cometer errores
            {
                Console.Clear();
                try
                {
                    Console.WriteLine("-Elevar un número al cuadrado-\n");
                    // Asignar Valor a la Variable "num"
                    Console.Write("   Número: ");
                    num = int.Parse(Console.ReadLine());

                    // Imprimir Resultado
                    Console.WriteLine("\n   Resultado: " + Math.Pow(num, 2));
                    rep = false;
                }
                // Excepciones
                catch (FormatException)
                {
                    Console.WriteLine("\n!El dato tiene que ser un número entero¡");
                    Console.ReadKey();
                    rep = true;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("\n!El dato es demasiado grande¡");
                    Console.ReadKey();
                    rep = true;
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                    Console.ReadKey();
                    rep = true;
                }
            }
            while (rep == true);

            // Salir del Programa
            Console.Write("\nPreciona ENTER para salir. . .");
            Console.ReadKey();
        }
    }
}