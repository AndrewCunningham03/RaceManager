using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.IO.RecyclableMemoryStreamManager;

namespace RaceManager
{
    internal class Race
    {
        private static int raceCounter = 1;
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

        internal List<Horse> HorseList { 
            get { return horseList; }
            set { horseList = value; }
             }

        public Race()
        {
            raceName = $"Race {raceCounter++}";
            startTime = DateTime.Now;
            horseList = new List<Horse>();
        }

        public Race(string raceName, DateTime startTime, List<Horse> horses)
        {
            this.raceName = string.IsNullOrEmpty(raceName) ? $"Race {raceCounter++}" : raceName; ;
            this.startTime = startTime;
            horseList = horses;
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
