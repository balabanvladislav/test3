using System;

namespace ConsoleApplication
{
    public class Human
    {
        public int Age { set; get; }
        public string Name { set; get; }

        public Human() { }
        public Human(string name)
        {
            Name = name;
        }
        public Human(string name, int age): this(name) // in this noi am chemat human de sus.
        {
            Age = age;
        }
    }

    public class Policeman : Human
    {   public Policeman(){}
        public string Rank { set; get; }
        public Policeman(string name, int age, string rank): base(name,age)
        {
            Rank = rank;
        }
        
    }
}