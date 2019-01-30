using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monkeys_n_Basket
{
    class MonkeyPad : AbstractMonkey
    {
        private List<int> _notUsedNumbersPad;

        public override int GetNumber()
        {
            int number = _notUsedNumbersPad[new Random().Next(0, _notUsedNumbersPad.Count)];
            _notUsedNumbersPad.Remove(number);
            return number;
        }
        public MonkeyPad(List<int> notUsedNumbers, string name) : base(notUsedNumbers, name)
        {
        _notUsedNumbersPad = new List<int>();
            for (int i = Basket.MinimalWeight; i < Basket.MaximumWeight; i++)
                _notUsedNumbersPad.Add(i);
        }
    }
}
