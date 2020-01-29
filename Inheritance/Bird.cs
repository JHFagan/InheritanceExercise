using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Bird:Animal
    {
        public bool HasWings { get; set; }
        public string Color  { get; set; }
        public bool HasFeathers  { get; set; }
        public bool CanFly { get; set; }
    }
}
