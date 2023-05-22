using System;
using System.Collections.Generic;
using System.Text;

namespace ModelMeThis_Football
{
    public class Player: Person
    {
        public int Number { get; set; }
        public double Height { get; set; }

        public Player(string name, int age, int number, double height) : base(name, age)
        {
            Number = number;
            Height = height;
        }
    }
}
