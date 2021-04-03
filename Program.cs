using System;

namespace A133590.Ejercicio36
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 36");
            Console.WriteLine("Programa que recibe ingresos hasta que el mismo sea una fecha válida.");
            DateTime ingreso;
            Console.Write("Por favor, ingrese una fecha: ");
            while (!DateTime.TryParse(Console.ReadLine(), out ingreso))
            {
                Console.Write("Ingreso inválido, intente nuevamente: ");
            }
            Console.WriteLine("Ingreso válido.")
            Console.WriteLine("Presione cualquier tecla para continuar..");
            Console.ReadKey();
        }
    }
}
