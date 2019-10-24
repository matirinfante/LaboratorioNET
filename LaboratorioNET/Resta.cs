namespace LaboratorioNET
{
    public class Resta : Operacion
    {
        public Resta()
        {
            
        }
        public Resta(Numero numeros) : base(numeros)
        {
        }

        public override double calcular()
        {
            return _numeros.Num1 - _numeros.Num2;
        }
    }
}