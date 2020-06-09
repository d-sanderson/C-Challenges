using System;

namespace Peeps
{
    public class Person
    {
        public string Name;
        public int Weight;
        public float Height;
        public DateTime Birthday;

        public Person(string name, int weight, float height, DateTime bday)
        {
            Name = name;
            Weight = weight;
            Height = height;
            Birthday = bday;
        }

        public string Introduce()
        {
            return $"My name is {Name}. I weight {Weight} lbs. I am {Height} tall. My birthday is {Birthday}";
        }
    }
}
