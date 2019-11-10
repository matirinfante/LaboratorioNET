using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityFrameworkTest
{
    internal class Program
    {
        delegate void Referencia(String mensaje);

        delegate void Referencia2(String mensaje);

        delegate string ActionRef<T>(ref string s);

        public static void Main(string[] args)
        {
            /*
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
            var numero = "cinco";
            Console.WriteLine(numero.Length);
            Console.ReadKey();
            var anonimo = new {mensaje = "asfasfa"};
            Console.WriteLine(anonimo.mensaje);
            MiClaseParcial parcial = new MiClaseParcial();
            parcial.imprimir1();
            parcial.imprimir2();
            Referencia refDelegado = Console.WriteLine;
            refDelegado("assfas");
            Referencia2 refDelegado2 = mensaje => Console.WriteLine();
            refDelegado2("mensaje 2");
            
            Action<String> action = s =>
            {
                s = s.Replace(' ', '-');
                s = s.ToLower();
                Console.WriteLine(s);
            };
            
            string str = "HOLA COMO ANDAS";
            action(str);
            
            ActionRef<String> actionRef = (ref string s) =>
            {
                s = s.Replace(" ", "-");
                s = s.ToLower();
                return s;
            };
            
            Console.WriteLine($"normalito = {str}");
            actionRef(ref str);
            Console.WriteLine($"modified by reference = {str}");
            Func<int, int, int> f = (n1, n2) => n1 * n2;
            Console.WriteLine(f(1, 2));
            */
            //LINQ
            /*var valores = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9};
            var pares = valores
                .Where(x => x % 2 == 0)
                .ToList();
            foreach (var p in pares)
            {
                Console.WriteLine(p);
            }*/


            List<Persona> lPersonas = new List<Persona>();

            for (int i = 0; i < 80; i++)
            {
                lPersonas.Add(new Persona()
                {
                    Nombre = $"Persona{i}",
                    Apellido = $"Apellido{i}",
                    Edad = i,
                });
            }

            var query = from persona in lPersonas
                where persona.Edad > 21
                orderby persona.Edad descending
                select persona;

            var queryLinq = lPersonas.Where(persona => persona.Edad > 50).OrderByDescending(persona => persona.Edad);
            /*foreach (var persona in query)
            {
                Console.WriteLine(persona);
            }*/

            foreach (var p in queryLinq)
            {
                Console.WriteLine(p);
            }

            Console.ReadKey();
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

    public class MiClase<T>
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

    partial class MiClaseParcial
    {
        public void imprimir1()
        {
            Console.WriteLine("parte 1");
        }
    }

    partial class MiClaseParcial
    {
        public void imprimir2()
        {
            Console.WriteLine("parte 2");
        }
    }
}