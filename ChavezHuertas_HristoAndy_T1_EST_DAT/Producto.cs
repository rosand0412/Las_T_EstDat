namespace ChavezHuertas_HristoAndy_T1_EST_DAT 
{
    internal class Producto
    {
        //Atributos
        private string nombreProducto;
        private int cantidad;
        private double precioLista, subtotal, precioVenta;

        //Constructor
        public Producto (string nomProd, double precList, int cant) 
        {
            this.nombreProducto = nomProd;
            this.precioLista = precList;
            this.cantidad = cant;
        }

        //Método para calcular el subtotal.
        private void calcSubtotal(int cant) 
        {   
            this.subtotal = this.precioLista * cant;
        }
        
        //Retorna el nombre del producto.
        public string obtNomProd()
        {
            return this.nombreProducto;
        }

        //Retorna la cantidad de articulos del producto.
        public int obtCant()
        {
            return this.cantidad;
        }

        //Retorna el precio de lista del producto.
        public double obtPreList()
        {
            return this.precioLista;
        }

        //Retorna el subtotal.
        public double obtSubtotal(int cant)
        {
            this.calcSubtotal(cant);
            return this.subtotal;
        }

        //Retorna el precio de venta.
        public double calcPrecVent() 
        {   
            this.precioVenta = this.subtotal + (0.18 * this.subtotal);
            return this.precioVenta;
        }
    }
}