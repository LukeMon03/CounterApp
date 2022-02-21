using System.Collections.Generic;
using System.Linq;

namespace CounterApp
{
    class Box
    {
        public List<Apple> list = new List<Apple>();

        public void Add(Apple item)
        {
            list.Add(item);
        }

        public int Count(string color, string breed)
        {
            return list.Where(apple => apple.color == color && apple.breed == breed).Count();

        }
    }
}
