using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    internal class NodoS
    {
        public Carro dato;
        public NodoS siguiente;
        public NodoS anterior;

        public NodoS(Carro dato)
        {
            siguiente = null;
            this.dato = dato;
            anterior = null;

        }
    }
}
