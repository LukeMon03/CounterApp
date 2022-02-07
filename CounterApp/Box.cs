using System.Collections.Generic;

namespace CounterApp
{
    class Box<T> where T : ICountable
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
