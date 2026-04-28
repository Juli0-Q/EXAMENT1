using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    internal class ListaEnlasadaS
    {
        private NodoS primero = null;
        private NodoS ultimo = null;

        public void AgregarCarro()
        {
            Console.WriteLine("Ingrese Marca de carro: ");
            string marca = Console.ReadLine();
            Console.WriteLine("Ingrese cantidad de puertas: ");
            int puertas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese tamaño del motor: ");
            double ccmotor = double.Parse(Console.ReadLine());

            NodoS nuevo = new NodoS(new Carro(marca, puertas, ccmotor));

            if (primero == null) primero = ultimo = nuevo;
            else
            {
                nuevo.siguiente = primero;
                primero.anterior = nuevo;
                primero = nuevo;
            }
        }

        ´public NodoS buscar(string marca)
        {
            NodoS actual = primero;
            while (actual != null)
            {
                if (actual.dato.marca == marca)
                {
                    return actual;
                }
                actual = actual.siguiente;
            }
            return null;
        }

        public void mostrar()
        {
            NodoS actual = primero;
            if (primero == null) Console.WriteLine("Lista vacia");
            while (actual != null)
            {
                Console.WriteLine(actual.dato);
                actual = actual.siguiente;
            }
        }

        public void CantidadPuertas(int puertas)
        {
            NodoS actual = primero;
            while (actual != null)
            {
                if (actual.dato.puertas >= puertas)
                {
                    Console.WriteLine(actual.dato);
                }
                actual = actual.siguiente;
            }
        }

        public void MezclarL(ListaEnlasadaS otro)
        {
            NodoS actual = primero;

            while (actual != null)
            {
                NodoS nuevo = new NodoS(new Carro(actual.dato.marca, actual.dato.puertas, actual.dato.ccmotor));

                if (primero == null) primero = ultimo = nuevo;
                else
                {
                    ultimo.anterior = nuevo;
                    nuevo.siguiente = ultimo;
                    ultimo = nuevo;
                }
                actual = actual.siguiente;
            }
        }

        public void Elminar(string marca)
        {
            NodoS actual = buscar(marca);

            if (primero == ultimo) primero = ultimo = null;
            else
            {
                if (actual == primero)
                {
                    primero = primero.siguiente;
                    primero.anterior = null;
                }
                else
                {
                    if (actual == ultimo)
                    {
                        ultimo = ultimo.anterior;
                        ultimo.siguiente = null;
                    }
                    else
                    {
                        actual.anterior.siguiente = actual.siguiente;
                        actual.siguiente.anterior = actual.anterior;
                    }
                }
            }
        }
    }
}
