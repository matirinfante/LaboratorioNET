using System.Linq;

namespace Lab1
{
    public static class Extension
    {
        public static string Reversa(this string cadena)
        {
            var cad = cadena.ToCharArray();
            return cad.Reverse().ToString();
        }
    }
}