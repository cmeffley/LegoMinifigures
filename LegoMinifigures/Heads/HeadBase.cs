using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigures.Heads
{
    abstract class HeadBase //the class is not intended to be instantiated, can only be inherited from
    {
        public LegoColor Color { get; set; }

        public virtual void SayHi()
        {
            Console.WriteLine("Hi.");
        }

        public abstract void Spin(); // every class that inherits from this class, has to have a method called Spin (implement it)

    }
}
