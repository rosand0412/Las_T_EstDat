using System.IO;

namespace Ejercicio2
{
    public class ABB
    {
        private Node numb;
        private ABB izq, der;

        // Retorna nulo si el árbol esta vacio (no tiene raíz).
        public bool isEmpty()
        {
            return this.numb is null;
        }
        
        // Agrega un nodo al árbol.
        public void add(Node n)
        {
            // Si el árbol está vacio, el elemento a agregar es la raíz.
            if (this.isEmpty())
            {
                this.numb = n;
            }
            else
            {
                // Si el elemento a agregar al árbol es mayor que la raíz,
                // ingresara por el subárbol derecho.
                if (this.numb.compare(n) > 0)
                {
                    if (this.der is null) { this.der = new ABB(); }
                    this.der.add(n);
                }
                else
                {
                    // Si el elemento a agregar al árbol es menor que la raíz,
                    // ingresara por el subárbol izquierdo.
                    if (this.izq is null) { this.izq = new ABB(); }
                    this.izq.add(n);
                }
            }
        }
        
        /*
         * Imprime en consola los nodos del árbol desde el nodo más a la 
         * izquierda del subárbol izquierdo (representando el número 
         * menor) hasta el nodo más a la derecha del subárbol derecho
         * (representando el número mayor)
         */
        public void inOrdenPrint()
        {
            if (this.numb is not null)
            {
                if (this.izq is not null) { this.izq.inOrdenPrint(); }
                Console.WriteLine(this.numb.getElem());
                if (this.der is not null) { this.der.inOrdenPrint(); }
            }
            else
            {
                Console.WriteLine("El árbol está vacio.");
            }
        }

        // Hace lo mismo que el método inOrdenPrint con la diferencia que la
        // salida va a un archivo de texto que pasa como parametro "fullPath".
        public void inOrdenWriteToFile(string fullPath)
        {
            if (this.numb is not null)
            {
                if (this.izq is not null)
                {
                    this.izq.inOrdenWriteToFile(fullPath);
                }

                using (StreamWriter sw = File.AppendText(fullPath))
                {
                    sw.WriteLine(this.numb.getElem());
                }

                if (this.der is not null)
                {
                    this.der.inOrdenWriteToFile(fullPath);
                }
            }
            else
            {
                Console.WriteLine("El árbol está vacio.");
            }
        }
    }
}
