using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monkeys_n_Basket
{
    class Basket
    {
        public const int MinimalWeight = 40;
        public const int MaximumWeight = 140;
        public int ActualWeight { get; private set; }

        public Basket()
        {
            ActualWeight = new Random(new Random().Next(int.MinValue, int.MaxValue)).Next(MinimalWeight, MaximumWeight);
        }
    }
}
