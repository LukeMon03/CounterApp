using System.Collections.Generic;

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
        public delegate bool AppleBeCount(Apple apple);

        public bool AppleBeCounts(AppleBeCount apple)
        {
            return false;
        }
    }
}





// apples can have one of many number color - Can be a multitude of colors. Red Green Blue. 

// boxes - Count method of box should accept a parameter. The parameter is a color The  box returns the number of apples that are the particular color 

//  