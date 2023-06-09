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

        public string getNombre()
        {
            return this.nombre;
        }

        public int getEdad()
        {
            return this.edad;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void setEdad(int edad)
        {
            this.edad = edad;
        }
    }
}
