using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yagonia_Calculator_Code
{
    internal class Calculator
    {
        private double _currentValue;

        public Calculator(double initialValue)
        {
            this._currentValue = initialValue;
        }

        public double Add(double numberToAdd)
        {
            this._currentValue += numberToAdd;
            return this._currentValue;
        }
    }
}
