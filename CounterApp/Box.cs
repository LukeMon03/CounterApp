using System;
using System.Collections.Generic;
using System.Text;

namespace CounterApp
{
    class Box<T>
    {
        public List<T> list = new List<T>();

        public void Add(T item)
        {
            list.Add(item);
        }

        public int counter()
        {
            return list.Count;
        }
    }
}
