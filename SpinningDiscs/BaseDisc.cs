using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public abstract class BaseDisc
    {
        public abstract string Name { get; set; }
        public abstract int Capacity { get; set; }
        public abstract List<string> Contents { get; set; }
        public abstract string DiscType { get; }
        public abstract int SpinSpeed { get; }

        protected BaseDisc(string name, int capacity, List<string> contents)
        {
            Name = name;
            Capacity = capacity;
            Contents = contents;
        }
    }

}
