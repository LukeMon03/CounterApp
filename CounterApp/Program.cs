using System;


namespace CounterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while(0==0) {
                Counter<string> counterString = new Counter<string>();
                counterString.Adder("bob");
                counterString.Adder("is");
                counterString.Adder("your");
                counterString.Adder("uncle.");

                Console.WriteLine(counterString.count());

                Counter<int> counterInt = new Counter<int>();
                counterInt.Adder(3);
                Console.WriteLine(counterInt.count());
            }
        }
    }
}
