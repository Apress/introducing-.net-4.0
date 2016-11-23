using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter03.Variance
{
    public class Animal
    {
        public int Weight { get; set; }
        public string Name { get; set; }

        public Animal()
        { }
        public Animal(string InputName, int InputWeight)
        {
            Name = InputName;
            Weight = InputWeight;
        }
    }
}
