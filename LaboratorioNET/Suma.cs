using System.Diagnostics;

namespace LaboratorioNET
{
    public class Suma : Operacion
    {
        public Suma()
        {
            
        }
        public Suma(Numero numeros) : base(numeros)
        {
        }

        public override double calcular()
        {
            return _numeros.Num1 + _numeros.Num2;
        }
    }
}