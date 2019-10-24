namespace LaboratorioNET
{
    public abstract class Operacion
    {
        protected Numero _numeros;

        protected Operacion()
        {
        }

        protected Operacion(Numero numeros)
        {
            _numeros = numeros;
        }

        public virtual double calcular()
        {
            throw new System.NotImplementedException();
        }
    }
}