using LegoMinifigures.Heads;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigures.Torso
{
    abstract class TorsoBase
    {
        public bool HasShirt { get; set; }
        public LegoColor Color { get; set; }
        public string ToolBelt { get; set; }

        public virtual void Greeting()
        {
            Console.WriteLine("Give a high five");
        }

        public abstract void Wiggle();

    }
}
