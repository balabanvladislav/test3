using System;

namespace ConsoleApplication
{
    public class Human
    {
        public int age;
        public int Age {
            set
            {
                if (value > 0) age = value;
            }
            get
            {
                return age;
            } }
        public char Sex { set; get; }
        public string Name { set; get; }
        public void SayHello()
        {
            Console.WriteLine("Hello!");
        }
        
    }
    public class Policeman: Human
    {
        public void EatDonuts()
        {
            Console.WriteLine("Am Nam Nam.");
        }
            
    }
}