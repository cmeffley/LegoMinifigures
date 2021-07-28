using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigures.Heads
{
    class ConstructionWorkerHead : HeadBase
    {

        public bool HasMullet { get; set; }
        public int NumberOfTeeth { get; set; }
        public bool WearingHardHat { get; set; }

        public bool ToggleWorking() //returning a bool (Instead of void/nothing)
        {
            WearingHardHat = !WearingHardHat;
            Console.WriteLine($"The Construction Worker Head {(WearingHardHat ? "is" : "is not ")} wearing their hard hat.");

            return WearingHardHat;
        }

        public override void Spin()
        {
            if (NumberOfTeeth > 0) // don't need { } around the code block because it's one line.
                NumberOfTeeth -= 1;
           
            Console.WriteLine($"The {Color} Construction Worker Head spins after being hit my a girder.");
        }

    }

}
