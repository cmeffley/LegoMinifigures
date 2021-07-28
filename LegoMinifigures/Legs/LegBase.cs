using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigures.Legs
{
    abstract class LegBase
    {
        public BottomsType Bottoms { get; set; }
        public ShoesType Kicks { get; set; }

        public virtual void Dance()
        {
            Console.WriteLine("Start doing the Electric Slide.");
        }

        public abstract void Walk();

    }
}
