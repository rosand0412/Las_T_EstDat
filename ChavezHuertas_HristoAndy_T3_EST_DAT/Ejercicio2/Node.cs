namespace Ejercicio2
{
    public class Node
    {
        private int elem;

        public Node(int elem)
        {
            this.elem = elem;
        }

        public int getElem()
        {
            return this.elem;
        }
    
        public int compare(Node n)
        {
            if (this.getElem() == n.getElem())
            {
                return 0;
            }
            else if (this.getElem() < n.getElem())
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public int compareId(int id)
        {
            if (this.getElem() == id)
            {
                return 0;
            }
            else if (this.getElem() < id)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
