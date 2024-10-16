using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceManager
{
    internal class EventCollection:Event
    {
        private int numberOfEvents;
        private List<Event> events;

        public EventCollection(int numberOfEvents, List<Event> events)
        {
            this.numberOfEvents = numberOfEvents;
            this.events = events;
        }

        public int NumberOfEvents { get => numberOfEvents; set => numberOfEvents = value; }
        public List<Event> EventList { get => events; set => events = value; }

        public List<Race> listOfRacesForByEventName(String eventName)
        {
            List<Race> list = new List<Race>();
            for (int i = 0; i < events.Count; i++)
            {
                if (events[i].Name.Equals(eventName))
                {
                    foreach(Race race in events[i].Racelist)
                    {
                        list.Add(race);
                    }
                }
            }
            return list;
        }
        public override String ToString()
        {
            return $"Number of events: {numberOfEvents}, Events: {events.ToString()}";
        }
    }
}
