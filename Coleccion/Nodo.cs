using System.Collections;
using System.Collections.Generic;

namespace Coleccion
{
    public class Nodo<T> : IEnumerable
    {
        public Stack<T> Datos { get; }

        public Nodo()
        {
            Datos = new Stack<T>();
        }

        public void Agregar(T elemento)
        {
            Datos.Push(elemento);
        }

        public bool Buscar(T elemento)
        {
            
        }
        public IEnumerator GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}