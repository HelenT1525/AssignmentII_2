using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command
{
   abstract class AbstractCommand

    {
        protected ArithmeticUnit aUnit;
        protected int operand;

        public abstract void Execute();
        public abstract void UnExecute();
    }
}
