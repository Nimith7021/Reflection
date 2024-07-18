using System.Reflection;
using Reflection.Models;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal(5,"Boa");
            Reptile reptile = new Reptile(true);
            Snake snake = new Snake("Red");


            ClassDetails(animal);
            ClassDetails(reptile);
            ClassDetails(snake);

        }

        static void ClassDetails(object obj)
        {
            Console.WriteLine($"===================For {obj.GetType().Name} Class ==================");
            int propertyLength = obj.GetType().GetProperties().Length;
            Console.WriteLine($"The number of properties in the {obj.GetType().Name} class is " +
                $"{propertyLength}");
            int methodLength = obj.GetType().GetMethods(BindingFlags.Public | BindingFlags.Instance
                | BindingFlags.DeclaredOnly).Where(m => !m.IsSpecialName).Count();

            Console.WriteLine($"The number of methods in the {obj.GetType().Name} class is " +
                $"{methodLength}");
            int constructorLength = obj.GetType().GetConstructors().Length;
            Console.WriteLine($"The number of constructors in the {obj.GetType().Name} class is " +
                $"{constructorLength}");
        } 

       
    }
}
