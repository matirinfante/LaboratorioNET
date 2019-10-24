using System;
using System.Runtime.InteropServices;

namespace LaboratorioNET
{
    internal class Program
    {
        public static void Main(string[] args)
        {    
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Clear();
            var calculadora = new Calculadora()
            {
                Numeros = new Numero(),
                //Operacion = new Suma(),
            };
            bool salir = false;
            int op;
            double n1, n2;
            do
            {
                Console.WriteLine("Ingrese el primer numero a operar: ");
                double.TryParse(Console.ReadLine(), out n1);
                Console.WriteLine("Ingrese el segundo numero a operar: ");
                double.TryParse(Console.ReadLine(), out n2);

                calculadora.Numeros.Num1 = n1;
                calculadora.Numeros.Num2 = n2;
                Console.WriteLine("Ingrese la operacion deseada:\n1)Suma\n2)Resta\n3)Producto\n4)Division");
                int.TryParse(Console.ReadLine(), out op);
                switch (op)
                {
                    case 1:
                        calculadora.Operacion = new Suma(calculadora.Numeros);
                        break;
                    case 2:
                        calculadora.Operacion = new Resta(calculadora.Numeros);
                        break;
                    case 3:
                        calculadora.Operacion = new Producto(calculadora.Numeros);
                        break;
                    case 4:
                        calculadora.Operacion = new Division(calculadora.Numeros);
                        break;
                }

                Console.WriteLine($"Resultado: {calculadora.Operacion.calcular()}\nDesea continuar?(s/n):");
                salir = Console.ReadLine().ToLower() == "n" ? true : false;
                Console.Clear();
            } while (!salir);
        }
    }
}