using System;

namespace CatEventExample
{
    public class Cat
    {
        public string Name { get; private set; }
        
        public Cat(string name)
        {
            Name = name;
        }

        public event EventHandler<CatWokeUpEventArgs> WokeUp;
        public event EventHandler<CatAteEventArgs> Ate;

        public void WakeUp(int hoursCount)
        {
            Console.WriteLine($"Котик {Name} поспал {hoursCount} часов");
            WokeUp?.Invoke(this, new CatWokeUpEventArgs(hoursCount));
        }

        public void Eat()
        {
            Console.WriteLine($"Котик {Name} поел в {DateTime.Now}");
            Ate?.Invoke(this, new CatAteEventArgs(DateTime.Now));
        }

    }
}