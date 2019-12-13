using System;

namespace Bakery
{
    class Bread
    {
        private int _loaves;
        private int _price;

        public Bread(int loaves, int price)
        {
            _loaves = loaves;
            _price = price;
        }
        
        public int GetBreadPrice()
        {
            if (_loaves == 2)
            {
                Console.WriteLine("Pierre will give you a third at no extra charge!");
                return _loaves * _price;
            }
            
            else if (_loaves / 3 >= 1)
            {
                double divide = _loaves / 3;
                double divideFloor = Math.Floor(divide);
                int subtract = Convert.ToInt32(divideFloor);

                int toPayFor = _loaves - subtract;
                return toPayFor * _price;
            }
            else
            {
                return _loaves * _price;
            }

        }
    }
    class Pastry
    {
        private int _pastries;
        private int _price;

        public Pastry(int pastries, int price)
        {
            _pastries = pastries;
            _price = price;
        }

        public int GetPastryPrice()
        {
            if (_pastries / 3 >= 1)
            {
                double divide = _pastries / 3;
                double divideFloor = Math.Floor(divide);
                int subtract = Convert.ToInt32(divideFloor);

                return (_pastries * _price) - subtract;
            }
            else
            {
                return _pastries * _price;
            }
        }  
    }
}