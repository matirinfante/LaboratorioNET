namespace LaboratorioNET
{
    public class Numero
    {
        private double num1;
        private double num2;

        public Numero()
        {
        }

        public Numero(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public double Num1
        {
            get => num1;
            set => num1 = value;
        }


        public double Num2
        {
            get => num2;
            set => num2 = value;
        }
    }
}