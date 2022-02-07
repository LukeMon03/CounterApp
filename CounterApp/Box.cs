using System.Collections.Generic;

namespace CounterApp
{
    class Box<T> :ICountable where T : ICountable
    {
        public List<T> list = new List<T>();

        public void Add(T item)
        {
            list.Add(item);
        }

        public int Count()
        {
            return list.Count;
        }
    }
}
