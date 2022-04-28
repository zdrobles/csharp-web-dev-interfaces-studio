using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    public class DVD : BaseDisc, IOpticalDisc
    {
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.
        public override string Name { get; set; }
        public override int Capacity { get; set; }
        public override List<string> Contents { get; set; }
        public override string DiscType { get; } = "DVD";
        public double LengthOfMovie { get; set; }
        public override int SpinSpeed { get; } = 1000;
        public DVD(string name, int capacity, List<string> contents, double lengthOfMovie) : base(name, capacity, contents)
        {
            LengthOfMovie = lengthOfMovie;
        }

        public void SpinDisc()
        {
            Console.WriteLine($"{DiscType} is spinning at a rate of about {SpinSpeed} rpm.");
        }

        //public bool StoreData()
        //{
        //    throw new NotImplementedException();
        //}

        public void DisplayInfo()
        {
            Console.WriteLine($"{DiscType}:\tName: {Name}\tCapacity: {Capacity}GB\tLength of movie (hrs): {LengthOfMovie}"); ;
        }

        public void Play()
        {
            Console.WriteLine($"{Name} is now playing...");
        }
    }
}
