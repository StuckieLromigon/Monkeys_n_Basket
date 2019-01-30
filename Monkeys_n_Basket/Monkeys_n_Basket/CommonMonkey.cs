using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monkeys_n_Basket
{
    class CommonMonkey : AbstractMonkey
    {
        public override int GetNumber()
        {
            return new Random().Next(Basket.MinimalWeight, Basket.MaximumWeight);
        }
        public CommonMonkey(List<int> notUsedNumbers, string name) : base(notUsedNumbers, name)
        {
        }
    }
}
