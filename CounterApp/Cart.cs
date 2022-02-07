using System;
using System.Collections.Generic;

namespace CounterApp
{
    class Cart<Box> where Box:ICountable
    {
        public List<Box> list = new List<Box>();

        public void Adder(Box item)
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