using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatEventExample
{
    public class Owner
    {
        public string Name { get; private set; }
        public List<Cat> cats { get; private set; }

        public Owner(string name)
        {
            Name = name;
            cats = new List<Cat>();
        }

        public void BringNewPet(Cat cat)
        {
            cats.Add(cat);
            cat.WokeUp += OnCatWokeUp;
            cat.Ate += OnCatAte;
        }

        public void GoodbyePet(Cat cat)
        {
            cats.Remove(cat);
            cat.WokeUp -= OnCatWokeUp;
            cat.Ate -= OnCatAte;
        }

        public void OnCatWokeUp(object sender, CatWokeUpEventArgs e)
        {
            Cat cat = sender as Cat;
            Console.WriteLine($"Наконец-то {cat.Name} проснулся! Ты проспал целых {e.HoursCount} часов! - сказал {this.Name}.");
        }

        public void OnCatAte(object sender, CatAteEventArgs e)
        {
            Cat cat = sender as Cat;
            Console.WriteLine($"Опять жрёшь, {cat.Name}! - сказал {this.Name}. На часах было {e.Time}.");
        }
    }
}
