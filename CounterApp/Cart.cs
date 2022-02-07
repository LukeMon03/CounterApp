using System;
using System.Collections.Generic;

namespace CounterApp
{
    class Cart<T> where T:ICountable
    {
        public List<Box<T>> list = new List<Box<T>>();

        public void Adder(Box<T> item)
        {
            list.Add(item);
        }

        public int Count()
        {
            var count = 0;
            foreach (var box in list)
            {
                
                count += box.Count();
            }
            return count;
        }
    }
}