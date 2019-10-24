namespace LaboratorioNET
{
    public class Calculadora
    {
        public Numero Numeros { get; set; }
        public Operacion Operacion { get; set; }

        public Calculadora()
        {
        }

        public Calculadora(Numero numeros, Operacion operacion)
        {
            this.Numeros = numeros;
            this.Operacion = operacion;
        }
    }
}