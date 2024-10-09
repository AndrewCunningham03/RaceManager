using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceManager
{
    internal class Race
    {
        private String raceName;
        private DateTime startTime;
        private List<Horse> horseList;

        public string RaceName {
            get { return raceName; }
            set { raceName = value; }
        }
        public DateTime StartTime { 
            get { return startTime; }
            set { startTime = value; }
        }
        public Race()
        {
            raceName = "Unkown";
            startTime = DateTime.Now;
            horseList = new List<Horse>();
        }

        public Race(string raceName, DateTime startTime)
        {
            this.raceName = raceName;
            this.startTime = startTime;
            horseList = new List<Horse>();
        }

        public bool AddHorse(Horse horse)
        {
            if (!horseList.Contains(horse))
            {
                horseList.Add(horse);
                return true;
            }
            return false;
        }

        public override String ToString()
        {
            return $"Race name: {raceName}, start time: {startTime.ToString()}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Race race &&
                   raceName == race.raceName &&
                   startTime == race.startTime &&
                   EqualityComparer<List<Horse>>.Default.Equals(horseList, race.horseList);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(raceName, startTime, horseList);
        }
    }
}
