using System.Collections.Generic;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nombre del archivo.
            string fileName = "numerosAleatorios.txt";

            // Ruta del archivo. En esta ocasión elegiremos guardarlo en la 
            // carpeta documentos del usuario que ejecuta la aplicación.
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Ruta completa del archivo.
            string fullPath = path + "\\" + fileName;

            // Conjunto de valores que no contiene duplicados. 
            HashSet<int> myHashSet = new HashSet<int>();

            // Instancio de Random
            Random rnd = new Random();

            // Bandera que me indica si es un elemento se agregó a la lista.
            bool isUniq;

            // Ultimo elemento que ingresa a la colección.
            int lastElem;
            
            /*
             * Se agregaran 500 elementos a la colección. Mientras estos
             * elementos que ingresan a la lista sean distintos, seran escritos
             * en el archivo de texto "numerosAleatorios.txt"
             */
            while (myHashSet.Count() < 20)
            {
                lastElem = rnd.Next(1, 6500);
                
                // Retorna true si el elemento se agregó a la colección.
                isUniq = myHashSet.Add(lastElem);

                // Si el elemento se agregó se escribe en el archivo.
                if (isUniq)
                {
                    using (StreamWriter sw = File.AppendText(fullPath))
                    {
                        sw.WriteLine(lastElem);
                    }
                }
            }
        }
    }
}
