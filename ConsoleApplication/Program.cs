using System;
using System.Text;

namespace ConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Policeman a = new Policeman();
            a.Age = 10;
            a.Sex = 'M';
            a.Name = "Ivan Ivanov";
            a.SayHello();
        }
    }
}