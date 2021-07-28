using LegoMinifigures.Heads;
using LegoMinifigures.Legs;
using LegoMinifigures.Torso;
using LegoMinifigures.MiniFigures;
using System;
using System.Collections.Generic;

namespace LegoMinifigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var workerhead = new ConstructionWorkerHead();
            workerhead.Color = LegoColor.Yellow;

            var batmanHead = new BatmanHead();
        
            var astronautHead = new AstronautHead();
        
            var heads = new List<HeadBase>() { astronautHead, batmanHead, workerhead };
            foreach (var head in heads)
            {
                head.SayHi();
                head.Spin();
            }

            var batmanTorso = new BatSuitTorso();
            batmanTorso.Color = LegoColor.Green;
            batmanTorso.HasBatBoomerang = true;
            batmanTorso.HasShirt = false;
            batmanTorso.Donates();

            var cowboyTorso = new CowboyTorso();

            var sumoTorso = new SumoTorso();

            var torsos = new List<TorsoBase>() { batmanTorso, cowboyTorso, sumoTorso };
            foreach (var torso in torsos)
            {
                torso.Greeting();
                torso.Wiggle();
            }

            var seaLeg = new SeaLeg();
            seaLeg.AreWobby = true;
            seaLeg.Bottoms = BottomsType.Chaps;
            seaLeg.NumberOfLegs = 3;
            seaLeg.Kicks = ShoesType.ShelltoeAdidas;

            var magicLeg = new MagicLeg();
            magicLeg.Bottoms = BottomsType.Chaps;
            magicLeg.HasInvisibleLegs = true;
            magicLeg.MeasuringLegs("small");
            Console.WriteLine($"Magic legs have a length of {magicLeg.Length} inches");

            var legs = new List<LegBase>() { seaLeg, magicLeg };
            foreach (var leg in legs)
            {
                leg.Dance();
                leg.Walk();
            }

            Console.WriteLine("Before Bob.");
            //var bob = new MiniFigure(workerhead, cowboyTorso, new SeaLeg()); can create new SeaLegs
            var bob = new MiniFigure(workerhead, cowboyTorso, seaLeg);
            bob.BuildIt();
            

            Console.WriteLine("You just saw Bob do his thing!");
            
                
        }
    }
}
