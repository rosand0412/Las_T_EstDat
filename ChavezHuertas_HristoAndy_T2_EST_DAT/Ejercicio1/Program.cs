namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos la lista de personas.
            ListaPersonas l = new ListaPersonas();
            
            // Respuesta del usuario. Controla si se ingresa o no más personas.
            string rpta = "";

            // Atributos de las personas.
            string nombre = "";
            int edad;

            do
            {
                // Ingresamos el nombre de la persona.
                Console.WriteLine("Ingrese el nombre de la persona: ");
                nombre = Console.ReadLine();

                // Ingresamos la edad de la persona
                Console.WriteLine("Ingrese la edad de la persona: ");
                edad = int.Parse(Console.ReadLine());

                // No se pueden ingresar edades menores a cero.
                while(edad < 0)
                {
                    Console.WriteLine("Ingrese una edad válida:");
                    edad = int.Parse(Console.ReadLine());
                }

                // Creamos un objeto persona.
                Persona p = new Persona(nombre, edad);

                // Agregamos a las personas creadas a la lista.
                l.agregarPersona(p);

                Console.WriteLine("¿Desea ingresar más personas?. Responda con [s/S]");
                Console.WriteLine("CUALQUIER OTRO VALOR SERA CONSIDERADO COMO NO");
                rpta = Console.ReadLine();
            } while (rpta.Equals("S") || rpta.Equals("s"));

            // Salidas que espera el ejercicio.
            Console.WriteLine("=======RESULTADO======");
            Console.WriteLine("La cantidad de personas es: " + l.cantPerson());
            Console.WriteLine("El promedio de edad es: " + l.promEdad());
            l.personMayor();
            l.personMenor();
        }
    }

}
