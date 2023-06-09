using System.Collections;

namespace Ejercicio2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Stack s = new Stack();

            // Respuesta del usuario. Controla si se ingresa o no más personas.
            string rpta = "";

            int num;

            do
            {
                // Guarda los números en una variable.
                Console.WriteLine("Ingrese un número: ");
                num = int.Parse(Console.ReadLine());

                // Si no son números enteros, descarta la entrada del usuario.
                while (num.GetType() != typeof(int))
                {
                    Console.WriteLine("Ingrese solo números interos: ");
                    num = int.Parse(Console.ReadLine());
                }

                // Agrega los enteros a la pila.
                s.Push(num);

                // Pregunta si se desea agregar números.
                Console.WriteLine("¿Desea ingresar más personas?. Responda con [s/S]");
                Console.WriteLine("CUALQUIER OTRO VALOR SERA CONSIDERADO COMO NO");
                rpta = Console.ReadLine();
            } while (rpta.Equals("S") || rpta.Equals("s"));

            int[] resultados = calculos(s);

            Console.WriteLine("La suma de todos los elementos es: " + resultados[0]);
            Console.WriteLine("El promedio de todos los elementos es: " + resultados[1]);

            /* Ya que se debe obtener la suma y el promedio de los elementos,
             * en una sola función hare todos los calculos hasta que la pila 
             * este vacia. Esta función retorna un arreglo de tamaño dos,
             * el primer elemento es la suma y el segundo el promedio.
             */
            int[] calculos(Stack s)
            {
                int[] resultados = new int[2];
                int sum = 0;
                int prom = 0;
                int i = 0;

                while (s.Count > 0)
                {   
                    i++;
                    sum += (int) s.Pop();
                }

                prom = sum / i;

                resultados[0] = sum;
                resultados[1] = prom;

                return resultados;
            }
        }
    }
}
