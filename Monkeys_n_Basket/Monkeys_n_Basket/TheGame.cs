using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monkeys_n_Basket
{
    class Game
    {
        private List<int> _notUsedNumbers;
        private List<AbstractMonkey> _monkeys;
        private Tuple<AbstractMonkey, int> _lastGuessedMonkeyAndDistance;
        private Basket _basket;
        public const int gameLength = 100;

        public Game()
        {
            _basket = new Basket();
            _notUsedNumbers = new List<int>();
            _monkeys = new List<AbstractMonkey>();
            for (int i = Basket.MinimalWeight; i < Basket.MaximumWeight; i++)
                _notUsedNumbers.Add(i);
        }
        public void Start()
        {
            //Hardcode
            
            _lastGuessedMonkeyAndDistance = new Tuple<AbstractMonkey, int>(null, Int32.MaxValue);
            _monkeys.Add(new CommonMonkey(_notUsedNumbers, "Noah"));
            _monkeys.Add(new MonkeyPad(_notUsedNumbers, "Raymond"));
            _monkeys.Add(new UberMonkey(_notUsedNumbers, "Svetlin"));
            _monkeys.Add(new UberCheaterMonkey(_notUsedNumbers, "Seb"));
            _monkeys.Add(new CheaterMonkey(_notUsedNumbers, "Terese"));
            Console.WriteLine($"{_monkeys.Count} monkeys fight over basket with {_basket.ActualWeight} actual weight");
            int distance = 0;
            for(int i = 0;i < gameLength;)
            {
                for(int j = 0; j < _monkeys.Count && i < gameLength; j++, i++)
                {
                    Console.WriteLine($"{i+1} turn");
                    bool result = _monkeys[j].GuessNumber(_basket, out distance);
                    if(result)
                    {
                        _lastGuessedMonkeyAndDistance = new Tuple<AbstractMonkey, int>(_monkeys[j], distance);
                        EndGame();
                        return;
                    }
                    if (distance < _lastGuessedMonkeyAndDistance.Item2)
                        _lastGuessedMonkeyAndDistance = new Tuple<AbstractMonkey, int>(_monkeys[j], distance);
                }
            }
            EndGame();
        }

        private void EndGame()
        {
            if(_lastGuessedMonkeyAndDistance.Item2 == 0)
            {
                Console.WriteLine($"Monkey {_lastGuessedMonkeyAndDistance.Item1.Name} wins!");
            }
            else
            {
                Console.WriteLine($"No winner! Monkey {_lastGuessedMonkeyAndDistance.Item1.Name} was almost near in {_lastGuessedMonkeyAndDistance.Item2} points!");
            }
        }
    }
}
