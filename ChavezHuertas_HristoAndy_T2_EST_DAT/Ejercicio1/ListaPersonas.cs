using System.Collections.Generic;

namespace Ejercicio1
{
    public class ListaPersonas
    {
        private LinkedList<Persona> l;

        public ListaPersonas()
        {
            this.l = new LinkedList<Persona>();
        }

        public void agregarPersona(Persona p) { this.l.AddLast(p); }

        public int cantPerson() { return this.l.Count; }

        public int promEdad()
        {
            int sum = 0;
            int prom;

            // Recorremos la lista de personas y vamos extrayendo y acumulando
            // sus edades.
            foreach (Persona p in this.l)
            {
                sum += p.getEdad();
            }
            prom = sum / this.cantPerson();
            return prom;
        }

        public void personMayor()
        {
            Persona pmayor = null;

            // Asumimos que el mayor es el que tiene cero años.
            int mayor = 0;

            // Recorre la lista de personas
            foreach (Persona p in this.l)
            {
                // Si encuentra una edad mayor, esa edad sera la mayor y
                // almacenamos a la persona.
                if (p.getEdad() >= mayor)
                {
                    mayor = p.getEdad();
                    pmayor = p;
                }
            }
            pmayor.saludoAnciano();
        }

        public void personMenor()
        {
            Persona pmenor = null;

            // Asumimos que la primera persona es la menor.
            int menor = this.l.First().getEdad();

            // Recorremos la lista de personas.
            foreach (Persona p in this.l)
            {
                // Si encuentra una edad menor, esa edad sera la menor y
                // almacenamos a la persona.
                if (p.getEdad() <= menor)
                {
                    menor = p.getEdad();
                    pmenor = p;
                }
            }
            pmenor.saludoJoven();
        }
    }
}