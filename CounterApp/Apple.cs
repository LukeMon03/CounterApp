namespace CounterApp
{
    class Apple : ICountable
    {
        public string color;

        public string breed;

        public delegate string Apples(string color, string breed);


        public void JuicyLukes(Apples apple)
        {
            string breed = "Juicy Luke";
            string color = "Orange";

            System.Console.WriteLine($"{apple(breed, color)}");
        }

        public Apple(string color = "green", string breed = "Pink Lady") { this.color = color; this.breed = breed; }

        public int Count()
        {
            return 1;
        }
    }
}
