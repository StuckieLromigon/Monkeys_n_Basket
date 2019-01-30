using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monkeys_n_Basket
{
    abstract class AbstractMonkey
    {
        public string Name { get; set; }
        protected List<int> _notUsedNumbers { get; set; }


        public bool GuessNumber(Basket basket, out int difference)
        {
            int number = GetNumber();
            _notUsedNumbers.Remove(number);
            difference = Math.Abs(basket.ActualWeight - number);
            return number == basket.ActualWeight;
        }

        public AbstractMonkey(List<int> notUsedNumbers, string name)
        {
            Name = name;
            _notUsedNumbers = notUsedNumbers;
        }

        public abstract int GetNumber();
    }
}
