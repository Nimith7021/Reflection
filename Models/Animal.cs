using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection.Models
{
    internal class Animal
    {
        public int LifeSpan { get; set; }

        public string Name { get; set; }

        public Animal()
        {
            Console.WriteLine("Hello this is Animal Class");
        }

        public Animal(int lifeSpan, string name)
        {
            LifeSpan = lifeSpan;
            Name = name;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Lifespan : {LifeSpan}\n" +
                $"Name : {Name}");
        }
    }
}
