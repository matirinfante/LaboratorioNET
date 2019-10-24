namespace LaboratorioNET
{
    public class Producto : Operacion
    {
        public Producto()
        {
            
        }
        public Producto(Numero numeros) : base(numeros)
        {
            
        }

        public override double calcular()
        {
            return _numeros.Num1 * _numeros.Num2;
        }
    }
}