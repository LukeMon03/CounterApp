using System;

namespace CounterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var box1 = new Box<Apple>();
            box1.Add(new Apple());
            box1.Add(new Apple());
            box1.Add(new Apple());
            box1.Add(new Apple());
            box1.Add(new Apple());

            var cart = new Cart<ICountable>();
            cart.Adder(box1);
            Console.WriteLine(cart.count());
        }
    }
}
