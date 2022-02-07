using System;

namespace CounterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (0 == 0)
            {
                var box1 = new Box<Apple>();
                box1.Add(new Apple());
                box1.Add(new Apple());
                box1.Add(new Apple());
                box1.Add(new Apple());
                box1.Add(new Apple());

                var cart = new Cart<Apple>();
                cart.Adder(box1);
                Console.WriteLine(cart.Count());
            }
            
        }
    }
}
