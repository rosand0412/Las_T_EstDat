using System.Collections;

namespace ChavezHuertas_HristoAndy_Final_EST_DAT
{
    public class Grafo
    {
        private Dictionary<string, List<string>> listaAdyacentes;
        public Grafo()
        {
            // Creamos un diccionario que almacenara los pares clave y valor.
            this.listaAdyacentes = new Dictionary<string, List<string>>();
        }
        
        public void agregarAmistad(string persona1, string persona2)
        {
            /*
             * Si alguna de las dos personas a las que se les intenta crear una
             * relación de amistad no existe en el diccionario, se les creará
             * su lista de amistades.
             */
            if (!listaAdyacentes.ContainsKey(persona1)) 
                this.listaAdyacentes[persona1] = new List<string>();
            if (!listaAdyacentes.ContainsKey(persona2))
                this.listaAdyacentes[persona2] = new List<string>();

            // Las personas se hacen amigos el uno del otro.
            this.listaAdyacentes[persona1].Add(persona2);
            this.listaAdyacentes[persona2].Add(persona1);
        }

        public void mostrarAmigos()
        {
            foreach(KeyValuePair<string, List<string>> usuario in listaAdyacentes)
            {
                // Imprimimos los valores clave.
                Console.WriteLine(usuario.Key + " es amigo de:");

                foreach(string amigo in usuario.Value) 
                {
                    // Imprimimos la lista de amigos de los valores clave.
                    Console.Write(amigo + " ");
                }

                // Hacemos un salto de lineas para separar las relaciones de
                // amistad.
                Console.WriteLine("\n");
            }
        }
    }
}
