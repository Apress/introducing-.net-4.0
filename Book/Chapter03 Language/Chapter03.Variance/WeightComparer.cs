using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter03.Variance
{
    public class WeightComparer : IComparer<Animal>
    {
        public int Compare(Animal x, Animal y)
        {
            if (x.Weight > y.Weight) return 1;
            if (x.Weight == y.Weight) return 0;
            return -1;
        }
    }
}
