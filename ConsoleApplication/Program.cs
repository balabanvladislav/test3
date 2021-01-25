using System;
using System.Net.NetworkInformation;
using System.Text;

namespace ConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.GetRoar();
            Dog dog = new Dog();
            dog.GetRoar();
            Pinguin pinguin = new Pinguin();
            pinguin.GetRoar();
            
        }
    }
}