using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigures.Legs
{
    class MagicLeg : LegBase
    {

        public bool HasInvisibleLegs { get; set; }
        public int Length { get; set; }

        public void MeasuringLegs(string size)
        {
            if(size == "small")
            {
                Length = 2;
            } 
            else if (size == "medium")
            {
                Length = 8;
            } 
            else if (size == "large")
            {
                Length = 16;
            }
            else
            {
                Length = 1;
            }

        }


        public override void Walk()
        {
            Console.WriteLine("We float around on magic carpets, no walking around");
        }
    }
}
