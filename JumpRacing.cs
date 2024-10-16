using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceManager
{
    internal class JumpRacing:Race
    {
        private int jumpHeight;

        public int JumpHeight { 
            get { return jumpHeight; }
            set { jumpHeight = value; }
        }

        public JumpRacing():base(){
        
            this.jumpHeight = 0;

        }

        public JumpRacing(int jumpHeight, String raceName, DateTime startTime, List<Horse> horseList) : base(raceName, startTime, horseList)
        {
            this.jumpHeight = jumpHeight;
        }
        public override string ToString()
        {
            return $"Jump height: {jumpHeight},{base.ToString()}";
        }
    }
}
