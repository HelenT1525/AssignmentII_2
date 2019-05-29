using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command
{
    class ArithmeticUnit
    {
        public int Register { get; private set; }
        public void Run(char operation, int operand)
        {
            switch (operation)
            {
                case '+':
                    Register += operand;
                    break;
                case '-':
                    Register -= operand;
                    break;
                case '*':
                    Register *= operand;
                    break;
                case '/':
                    Register /= operand;
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}

