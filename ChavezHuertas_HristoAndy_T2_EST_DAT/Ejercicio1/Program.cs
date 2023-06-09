using System.Collections.Generic;

namespace Ejercicio1
{
    class Program
    {
        LinkedList<Persona> l = new LinkedList<Persona>();

        static void Main(string[] args)
        {
            string rpta = "";
            string nombre = "";
            int edad;
            do
            {
                // Ingresamos el nombre de la persona.
                Console.WriteLine("Ingrese el nombre de la persona: ");
                nombre = Console.ReadLine();

                // Ingresamos la edad de la persona

                Console.WriteLine("¿Desea ingresar más personas?. Responda con [s/S]");
                Console.WriteLine("CUALQUIER OTRO VALOR SERA CONSIDERADO COMO NO");
                rpta = Console.ReadLine();
            } while (rpta.Equals("S") || rpta.Equals("s"));
        }
    }

}
