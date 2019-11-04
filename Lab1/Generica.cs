using System;

namespace Lab1
{
    public class Generica<T>
    {
        private T value;

        public Generica(T value)
        {
            this.value = value;
        }

        public void Show()
        {
            Console.WriteLine(this.value);
        }
    }
}