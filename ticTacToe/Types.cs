using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ticTacToe
{
    public class Mark
    {
        private int _value;
        public int intVal
        {
            get
            {
                return _value;
            }
            set
            {
                if(value < -1 || value > 1)
                    throw new ArgumentOutOfRangeException("value");

                _value = value;
            }
        }
        public char charVal {
            get
            {
                if (_value == 0)
                    return '0';
                else if (_value == 1)
                    return 'X';
                else
                    return ' ';
            }
            set
            {
                if (value == '0')
                    _value = 0;
                else if (value == 'X')
                    _value = 1;
                else
                    _value = -1;
            }
        }
        public Mark()
        {
            _value = -1;
        }
        public Mark(int i)
        {
            intVal = i;
        }
        public Mark(char x)
        {
            charVal = x;
        }
        public override string ToString()
        {
            return Convert.ToString(charVal);
        }
    }
}
