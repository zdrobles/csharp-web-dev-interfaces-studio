using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    public class CD : BaseDisc, IOpticalDisc
    {
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 
        public override string Name { get; set; }
        public override int Capacity { get; set; }
        public override List<string> Contents { get; set; }
        public override string DiscType { get; } = "CD";
        public int NumOfTracks { get; set; }

        public override int SpinSpeed { get; } = 350;

        public CD(string name, int capacity, List<string> contents, int numOfTracks) : base(name, capacity, contents)
        {
            NumOfTracks = numOfTracks;
        }

        public void SpinDisc()
        {
            Console.WriteLine($"{DiscType} is spinning at a rate of about {SpinSpeed} rpm."); ;
        }

        //public bool StoreData()
        //{
        //    throw new NotImplementedException();
        //}

        public void DisplayInfo()
        {
            Console.WriteLine($"{DiscType}:\tName: {Name}\tCapacity: {Capacity}MB\t# of tracks: {NumOfTracks}");
        }

        public void Play()
        {
            Console.WriteLine($"{Name} is now playing {Contents[0]}");
        }
    }
}
