namespace EntityFrameworkTest
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }

        public Persona()
        {
        }

        public Persona(string nombre, string apellido, int edad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre} Apellido: {Apellido} Edad: {Edad}";
        }
    }
}