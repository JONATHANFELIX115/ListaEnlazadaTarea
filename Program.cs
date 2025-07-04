using System;

namespace ListaEnlazadaTarea
{
    class Nodo
    {
        public int Valor;
        public Nodo Siguiente;

        public Nodo(int valor)
        {
            Valor = valor;
            Siguiente = null;
        }
    }

    class ListaEnlazada
    {
        public Nodo cabeza;

        public ListaEnlazada()
        {
            cabeza = null;
        }

        public void InsertarAlFinal(int valor)
        {
            Nodo nuevo = new Nodo(valor);

            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                Nodo actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevo;
            }
        }

        public void Mostrar()
        {
            Nodo actual = cabeza;
            while (actual != null)
            {
                Console.Write(actual.Valor + " -> ");
                actual = actual.Siguiente;
            }
            Console.WriteLine("null");
        }

        public int ContarElementos()
        {
            int contador = 0;
            Nodo actual = cabeza;
            while (actual != null)
            {
                contador++;
                actual = actual.Siguiente;
            }
            return contador;
        }

        public void Invertir()
        {
            Nodo anterior = null;
            Nodo actual = cabeza;
            Nodo siguiente = null;

            while (actual != null)
            {
                siguiente = actual.Siguiente;
                actual.Siguiente = anterior;
                anterior = actual;
                actual = siguiente;
            }
            cabeza = anterior;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazada lista = new ListaEnlazada();

            // Insertamos algunos elementos
            lista.InsertarAlFinal(10);
            lista.InsertarAlFinal(20);
            lista.InsertarAlFinal(30);
            lista.InsertarAlFinal(40);

            Console.WriteLine("Lista Original:");
            lista.Mostrar();

            Console.WriteLine("Número de elementos en la lista: " + lista.ContarElementos());

            lista.Invertir();
            Console.WriteLine("Lista Invertida:");
            lista.Mostrar();
        }
    }
}
