namespace LaboratorioNET
{
    public class Division : Operacion
    {
        public Division()
        {
        }

        public Division(Numero numeros) : base(numeros)
        {
        }

        public override double calcular()
        {
            return _numeros.Num1 / _numeros.Num2;
        }
    }
}