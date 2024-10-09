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
        private DateOnly dateOfBirth;
        private String horseID;
        private String owner;
        private String jockey;

        public string Name {
            get { return name; }
            set { name = value; }
        }
        public DateOnly DateOfBirth {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
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
            dateOfBirth = new DateOnly();
            horseID = "Unkown";
            owner = "Unkown";
            jockey = "Unkown";
        }

        public Horse(string name, DateOnly dateOfBirth, string horseID, string owner, string jockey)
        {
            this.name = name;
            this.dateOfBirth = dateOfBirth;
            this.horseID = horseID;
            this.owner = owner;
            this.jockey = jockey;
        }
        public override string ToString()
        {
            return $"Horse name: {name}, Date of birth: {dateOfBirth.ToString()}, Horse ID: {horseID}, Owner: {owner}, Jockey: {jockey}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Horse horse &&
                   name == horse.name &&
                   dateOfBirth.Equals(horse.dateOfBirth) &&
                   horseID == horse.horseID &&
                   owner == horse.owner &&
                   jockey == horse.jockey;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(name, dateOfBirth, horseID, owner, jockey);
        }
    }
}
