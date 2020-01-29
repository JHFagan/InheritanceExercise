using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptile:Animal
    {
        public Reptile(int legs, int arms, int eyes, bool hasTail, bool breathesFire, bool hasScales, bool isColdBlooded, bool hasLegs)
        {
            Legs = legs;
            Arms = arms;
            Eyes = eyes;
            HasTail = hasTail;
            BeathesFire = breathesFire;
            HasScales = hasScales;
            IsColdBlooded = isColdBlooded;
            HasLegs = hasLegs;

        }
        public bool BeathesFire { get; set; }
        public bool HasScales { get; set; }
        public bool IsColdBlooded { get; set; }
        public bool HasLegs { get; set; }
    }
}
