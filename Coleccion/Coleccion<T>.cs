using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Coleccion
{
    public class Coleccion<T> : IEnumerable<T>
    {
        public List<T> Datos { get; }

        public void Agregar(T elemento)
        {
            Datos.Add(elemento);
        }

        public bool Buscar(T elemento)
        {
            return Datos.Where(((Nodo<T>) x => x.Buscar()));
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}