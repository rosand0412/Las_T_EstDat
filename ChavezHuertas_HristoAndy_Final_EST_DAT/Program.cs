namespace ChavezHuertas_HristoAndy_Final_EST_DAT
{
    public class Progam
    {
        public static void Main(string[] args)
        {
            Grafo grafo = new Grafo();
            LeerArchivo readFile = new LeerArchivo();
            readFile.cargaMasiva(grafo);

            // Muestra los lazos de amistad.
            grafo.mostrarAmigos();
        }
    }
}
