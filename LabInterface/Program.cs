using System;

namespace LabInterface
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            TipoDato t = new TipoDato(12,"DNI");
            Console.WriteLine($"Num {t.numero = 5}");
        }
    }
}