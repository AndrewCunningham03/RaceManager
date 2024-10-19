using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceManager
{
    internal class Horse
    {
        private String name;
        private int age;
        private String horseID;
        private String owner;
        private String jockey;

        public string Name {
            get { return name; }
            set { name = value; }
        }
        public int Age {
            get { return age; }
            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Age must be between 1 and 50 years.");
                }
                age = value;
            }
    }
        public string HorseID {
            get { return horseID; }
            set {  horseID = value; }
        }
        public string Owner {
            get { return owner; }
            set { owner = value; }
        }
        public string Jockey {
            get { return jockey; }
            set { jockey = value; }
        }
        public Horse()
        {
            name = "Unkown";
            age = 0;
            horseID = "Unkown";
            owner = "Unkown";
            jockey = "Unkown";
        }

        public Horse(string name, int age, string horseID, string owner, string jockey)
        {
            this.name = name;
            this.age = age;
            this.horseID = horseID;
            this.owner = owner;
            this.jockey = jockey;
        }
        public override string ToString()
        {
            return $"Horse name: {name}, Date of birth: {age.ToString()}, Horse ID: {horseID}, Owner: {owner}, Jockey: {jockey}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Horse horse &&
                   name == horse.name &&
                   age.Equals(horse.age) &&
                   horseID == horse.horseID &&
                   owner == horse.owner &&
                   jockey == horse.jockey;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(name, age, horseID, owner, jockey);
        }
    }
}
