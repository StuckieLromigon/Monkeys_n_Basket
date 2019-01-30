using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monkeys_n_Basket
{
    class CheaterMonkey : AbstractMonkey
    {
        public override int GetNumber()
        {
            return _notUsedNumbers[new Random().Next(0, _notUsedNumbers.Count)];
        }
        public CheaterMonkey(List<int> notUsedNumbers, string name) : base(notUsedNumbers, name)
        {
        }
    }
}
