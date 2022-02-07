using System;
using System.Collections.Generic;
using System.Text;

namespace CounterApp
{
    class Cart<T> where T:ICountable
    {
        public List<T> list = new List<T>();

        public void Adder(T item)
        {
            list.Add(item);
        }

        public int count()
        {
            foreach (var box in list)
            {
                var count = box.Count();
                Console.WriteLine(count);
            }
            return list.Count;
        }
    }
}