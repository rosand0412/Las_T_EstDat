using System.Text;

namespace Ejercicio1
{
    public class Persona
    {
        private string nombre;
        private int edad;

        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public string getNombre() { return this.nombre; }

        public int getEdad() { return this.edad; }

        public void setNombre(string nombre) { this.nombre = nombre; }

        public void setEdad(int edad) { this.edad = edad; }

        public void saludoAnciano()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Hola..mmmm... yo soy " + this.getNombre() + ". ");
            sb.AppendLine("Soy el mayor de toda esta gente.");
            sb.Append("Tengo " + this.getEdad() + " años. ");
            sb.AppendLine("Ojala recordara porqué digo esto.");
            Console.WriteLine(sb);
        }

        public void saludoJoven()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Hola yo soy " + this.getNombre() + ". ");
            sb.AppendLine("Soy el más joven del grupo.");
            sb.Append("Tengo " + this.getEdad() + " años. ");
            sb.AppendLine("Me siento lleno de vida.");
            Console.WriteLine(sb);
        }
    }
}
