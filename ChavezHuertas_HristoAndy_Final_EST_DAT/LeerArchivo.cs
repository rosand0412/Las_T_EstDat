// IMPORTANTE:
// EL ARCHIVO Amistades.txt DEBE DE ESTAR EN LA CARPETA DOCUMENTOS DEL USUARIO. 
// EL PROGRAMA FUNCIONA SOLO EN WINDOWS.

using System;
using System.IO;

namespace ChavezHuertas_HristoAndy_Final_EST_DAT
{
    public class LeerArchivo
    {
        private string rutaArchivo;
        private string nombreArchivo;

        public LeerArchivo()
        {
            this.rutaArchivo = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            this.nombreArchivo = "Amistades.txt";
        }
        
        // Carga masiva de amistades leidas desde el archivo de texto.
        public void cargaMasiva(Grafo grafo)
        {
            // Creamos la ruta completa.
            string rutaCompleta = this.rutaArchivo + "\\" + this.nombreArchivo;

            // Leemos el archivo.
            StreamReader sr = new StreamReader(rutaCompleta);
            
            // Separador de grupos de amistades.
            string delimitador = "***";
            string nextReg = null;

            // Leemos la primera linea del archivo de texto.
            //string nextReg = sr.ReadLine();

            // Futuros amigos.
            string persona1;
            string persona2;

            do
            {
                // Si encuentra el delimitador se prepara para crear una
                // relación de amistad.
                if(delimitador.Equals("***"))
                {
                    persona1 = sr.ReadLine();
                    persona2 = sr.ReadLine();
                    grafo.agregarAmistad(persona1, persona2);
                    nextReg = sr.ReadLine();
                    delimitador = nextReg;
                }
            } while (nextReg is not null);

            // Cerramos el archivo.
            sr.Close();
        }
    }
}

