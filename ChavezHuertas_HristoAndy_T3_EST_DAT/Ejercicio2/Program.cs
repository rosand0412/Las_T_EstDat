using System.IO;

namespace Ejercicio2
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

            // Valida que el archivo exista.
            if (File.Exists(fullPath))
            {
                string line;

                // Instancia de un árbol de busqueda binario.
                ABB abb = new ABB();

                // Se prepara el archivo para ser leido.
                using(StreamReader sr = new StreamReader(fullPath))
                {
                    // Si la linea no es nula, se lee la siguiente linea
                    // y se asigna el la cadena a line.
                    while ((line = sr.ReadLine()) is not null)
                    {
                        // Dado que el árbol solo acepta enteros, tenemos que
                        // convertir el valor de cada linea a entero.
                        abb.add(new Node(int.Parse(line)));
                    }
                }

                // Imprime en consola.
                abb.inOrdenPrint();

                // Nombre del archivo con los datos ordenados.
                string fileNameOrdered = "numerosOrdenados.txt";
                fullPath = path + "\\" + fileNameOrdered;

                // Trasladamos el árbol ordenado al archivo de texto,
                // numerosOrdenados.txt
                abb.inOrdenWriteToFile(fullPath);
            }
            else
            {
                Console.WriteLine("El archivo no existe.");
                Console.WriteLine("Ejecute el ejercicio 1.");
            }
        }
    }
}
