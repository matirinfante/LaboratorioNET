using System;
using System.Diagnostics.CodeAnalysis;

namespace Lab2
{
    internal class Program
    {
        public delegate int Funcion(int n1, int n2);

        public static void Main(string[] args)
        {
            Funcion suma = (n1, n2) => Sumar(n1, n2);
            Funcion resta = (n1, n2) => Restar(n1, n2);

            Funcion metodoAnonimo = delegate(int n1, int n2) { return n1 * n2; };
            Funcion expLambda = (n1, n2) => 0;

            Action<int> action = (value) => Console.WriteLine(value);

            Func<int, int, int> funcionSuma = (x, y) => x + y;
            
            
        }

        public static int Sumar(int n1, int n2)
        {
            return n1 + n2;
        }

        public static int Restar(int n1, int n2)
        {
            return n1 - n2;
        }
    }
}