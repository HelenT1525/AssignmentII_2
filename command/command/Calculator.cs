using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command
{
    class Calculator
    {
        ControlUnit cUnit;
        ArithmeticUnit aUnit;
        public Calculator()
        {
            cUnit = new ControlUnit();
            aUnit = new ArithmeticUnit();
        }
        public int Run(AbstractCommand command)
        {
            cUnit.StoreCommand(command);
            cUnit.ExecuteCommand();
            return aUnit.Register;
        }
        public int Add(int operand)
        {
            return Run(new Add(aUnit, operand));
        }
        public int Sub(int operand)
        {
            return Run(new Sub(aUnit, operand));
        }
        public int Mul(int operand)
        {
            return Run(new Mul(aUnit, operand));
        }
        public int Div(int operand)
        {
            return Run(new Div(aUnit, operand));
        }
    }
}
