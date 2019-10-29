using System;
using System.Data.Entity.Core.EntityClient;
using System.Linq;

namespace EntityFrameworkTest
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MiClase<int> entero = new MiClase<int>(5);
            entero.Mostrar();
            MiClase<string> strings = new MiClase<string>("aloH");
            strings.Mostrar();
            MiClase<double> dobles = new MiClase<double>(2.0);
            dobles.Mostrar();
            entero.Valor = 6;
            entero.Mostrar();
            entero.Default();
            strings.Default();
            dobles.Default();
            Console.WriteLine("hola".Reversa());
        }
    }


    public static class StringExtensions
    {
        public static String Reversa(this string v)
        {
            char[] array = v.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }

    class MiClase<T>
    {
        public T Valor { get; set; }

        public MiClase(T valor)
        {
            this.Valor = valor;
        }

        public void Mostrar()
        {
            Console.WriteLine(this.Valor);
        }

        public T Default()
        {
            this.Valor = default(T);
            return Valor;
        }
    }
}