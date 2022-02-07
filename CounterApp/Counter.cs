using System;
using System.Collections.Generic;
using System.Text;

namespace CounterApp
{

    class Counter<T>
    {

        public List<T> list = new List<T>();

        public void Adder(T item)
        {
            list.Add(item);
        }

        public int count()
        {
            return list.Count;
        }
    }
}
