using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceManager
{
    internal class Race:Event
    {
        private String raceName;
        private DateTime startTime;

        public string RaceName {
            get { return raceName; }
            set { raceName = value; }
        }
        public DateTime StartTime { 
            get { return startTime; }
            set { startTime = value; }
        }
        public
    }
}
