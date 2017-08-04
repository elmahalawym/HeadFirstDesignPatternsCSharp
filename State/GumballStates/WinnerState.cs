using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class WinnerState : IState
    {
        GumballMachine gumballMachine;

        public WinnerState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            throw new NotImplementedException();
        }

        public void EjectQuarter()
        {
            throw new NotImplementedException();
        }

        public void InsertQuarter()
        {
            throw new NotImplementedException();
        }

        public void TurnCrank()
        {
            throw new NotImplementedException();
        }
    }
}
