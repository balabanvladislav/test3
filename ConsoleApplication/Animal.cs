using System;
namespace ConsoleApplication
{
    public class Animal
    {
        protected string Name { get; set; }

        public virtual void GetRoar()
        {
            Console.WriteLine("Arrrr");
        }
        
    }

    public class Pinguin : Animal
    {
        public override void GetRoar()
        {
            Console.WriteLine("Piu Piu:D");
        }
        
    }

    public class Dog : Animal
    {
        public override void GetRoar()
        {
            Console.WriteLine("Gaf?");
        }
    }

    public class Cat : Animal
    {
        
    }
}