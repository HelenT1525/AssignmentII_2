using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command
{
    class Sub : AbstractCommand
    {
        public Sub(ArithmeticUnit aUnit, int operand)
        {
            this.operand = operand;
            this.aUnit = aUnit;
        }
        public override void Execute()
        {
            aUnit.Run('-', operand);
        }

        public override void UnExecute()
        {
            aUnit.Run('+', operand);
        }
    }
}
