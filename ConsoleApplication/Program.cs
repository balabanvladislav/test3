using System;

namespace ConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human Ady = new Human("Ady", 20);
            Console.WriteLine(Ady.Age);
            Policeman Lu = new Policeman("Lu", 30, "Captain");
            Console.WriteLine($"Name = {Lu.Name}\nAge = {Lu.Age}\nRank = {Lu.Rank}");
        }
    }
}