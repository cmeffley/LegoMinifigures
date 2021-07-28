using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigures.Legs
{
    class SeaLeg : LegBase
    {
        public bool AreWobby { get; set; }
        public int NumberOfLegs { get; set; }
        
        public void Swim()
        {
            Console.WriteLine("I'm a certified swimmer.");
        }

        public override void Walk()
        {
            Console.WriteLine("Currently moonwalking off the plank, HALPP!");
        }
    }
}
