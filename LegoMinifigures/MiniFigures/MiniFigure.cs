using LegoMinifigures.Heads;
using LegoMinifigures.Legs;
using LegoMinifigures.Torso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigures.MiniFigures
{
    class MiniFigure
    {

        HeadBase Head { get; }
        TorsoBase Torso { get; }
        LegBase Leg { get; }

        public MiniFigure(HeadBase head, TorsoBase torso, LegBase leg)
        {
            Head = head;
            Torso = torso;
            Leg = leg;
        }

        public void BuildIt()
        {
            Console.WriteLine("I love to build things with my bare hands.");
            Head.SayHi();
            Head.Spin();
            Torso.Greeting();
            Leg.Dance();
        }

        public void SayHi()
        {
            Head.SayHi();
        }

    }
}
