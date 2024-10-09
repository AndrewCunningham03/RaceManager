using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceManager
{
    internal class Event
    {
        private String name;
        private String location;
        private int numberOfRaces;

        public string Name { 
            get { return name; }
            set { name = value; }
             }
        public string Location { 
            get { return location; }
            set { location = value; }

        }
        public int NumberOfRaces { 
            get { return numberOfRaces; }
            set { numberOfRaces = value; }
        }
        public Event()
        {
            name = "Unkown";
            location = "Unkown";
            numberOfRaces = 0;
        }
        public Event(string name, string location, int numberOfRaces)
        {
            Name = name;
            Location = location;
            NumberOfRaces = numberOfRaces;
        }

        public override String ToString()
        {
            return $"Event name: {name}, Location: {location}, Number of races {numberOfRaces}";
        }
    }
}
