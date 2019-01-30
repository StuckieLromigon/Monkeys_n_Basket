using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monkeys_n_Basket
{
    class UberCheaterMonkey : UberMonkey
    {
        public override int GetNumber()
        {
            int number = Basket.MinimalWeight - 1;
            while (!_notUsedNumbers.Contains(_currentNumber++) || number == Basket.MinimalWeight - 1)
            {
                number = _currentNumber;
            }
            return number;
        }
        public UberCheaterMonkey(List<int> notUsedNumbers, string name) : base(notUsedNumbers, name)
        {
        }
    }
}
