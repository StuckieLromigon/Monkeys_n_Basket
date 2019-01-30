using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monkeys_n_Basket
{
    class UberMonkey : AbstractMonkey
    {
        protected int _currentNumber = Basket.MinimalWeight;

        public override int GetNumber()
        {
            return ++_currentNumber;
        }
        public UberMonkey(List<int> notUsedNumbers, string name) : base(notUsedNumbers, name)
        {
        }
    }
}
