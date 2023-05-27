
using System;

namespace ChavezHuertas_HristoAndy_T1_EST_DAT
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el nombre del producto:");
            string nomProd = Console.ReadLine();

            Console.WriteLine("Ingrese el precio de lista del producto:");
            double precList = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de articulos del producto");
            int cant = int.Parse(Console.ReadLine());

            Producto p = new Producto(nomProd, precList, cant);

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Producto: " + p.obtNomProd());
            Console.WriteLine("Precio unitario: " + p.obtPreList());
            Console.WriteLine("Cantidad de articulos: " + p.obtCant());
            Console.WriteLine("El subtotal es: " + p.obtSubtotal(cant));
            Console.WriteLine("El precio de venta es : " + p.calcPrecVent());
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
        }
    }
}