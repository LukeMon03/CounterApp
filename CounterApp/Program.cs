using System;

namespace CounterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
                var box1 = new Box();
                box1.Add(new Apple("purple", "Ray"));
                box1.Add(new Apple("red", "Supple Joseph"));
                box1.Add(new Apple("red", "Juicy Luke"));
                box1.Add(new Apple("green", "Golden Boy"));
                box1.Add(new Apple("green", "Pink Lady"));
                box1.Add(new Apple("green", "Pink Lady"));

            //var cart = new Cart<Apple>();
            //cart.Adder(box1);
            Console.WriteLine(box1.Count("green", "Pink Lady"));
        }
    }
}
