using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_fleet_app

{
  
    public class cars
    {
        public int aar = 0;
        private string _make;
        private string _model;
        private int _year;
        private double _currentValue;
        public cars(string make, string model, int year, double currentValue)
        {
            _make = make;
            _model = model;
            _year = year;
            _currentValue = currentValue;

        }
        public double GetCurrentValue()
        {
            return _currentValue;
        }
        public int GetYear()
        {
            return _year;
        }
        public override string ToString()
        {
            return string.Format(
                "Make: {0} \n Model: {1} \n Year: {2} \n Current Value: {3}"
                , _make, _model, _year, _currentValue);
        }
    }
}
