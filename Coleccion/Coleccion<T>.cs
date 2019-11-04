using System.Collections;
using System.Collections.Generic;

namespace Coleccion
{
    public class Coleccion<T> : IEnumerable<T>
    {
        public void Agregar(T elemento)
        {
            
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