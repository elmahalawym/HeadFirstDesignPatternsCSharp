using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class GumballMachine
    {
        IState soldOutcurrentState;
        IState noQuartercurrentState;
        IState hasQuartercurrentState;
        IState soldcurrentState;
        IState winnercurrentState;

        IState currentState;
        int count = 0;

        public GumballMachine(int gumballsCount)
        {
            // initialize count & currentStates
            this.count = gumballsCount;
            soldOutcurrentState = new SoldOutState(this);
            noQuartercurrentState = new NoQuarterState(this);
            hasQuartercurrentState = new HasQuarterState(this);
            soldcurrentState = new SoldState(this);
            winnercurrentState = new WinnerState(this);

            // initial currentState
            currentState = gumballsCount > 0 ? noQuartercurrentState : soldOutcurrentState;
        }


        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public IState CurrentState
        {
            get
            {
                return this.currentState;
            }
            set
            {
                this.currentState = value;
            }
        }


        public void InsertQuarter()
        {
            currentState.InsertQuarter();
        }

        public void EjectQuarter()
        {
            currentState.EjectQuarter();
        }

        public void TurnCrank()
        {
            currentState.TurnCrank();
            currentState.Dispense();
        }

        private void SetcurrentState(IState currentState)
        {
            this.currentState = currentState;
        }

        void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");

            if (count != 0)
                count = count - 1;
        }

        
        void Refill(int count)
        {
            this.count = count;
            currentState = noQuartercurrentState;
        }

        public IState GetcurrentState()
        {
            return currentState;
        }

        public IState GetSoldOutcurrentState()
        {
            return soldOutcurrentState;
        }

        public IState GetNoQuartercurrentState()
        {
            return noQuartercurrentState;
        }

        public IState GetHasQuartercurrentState()
        {
            return hasQuartercurrentState;
        }

        public IState GetSoldcurrentState()
        {
            return soldcurrentState;
        }

        public IState GetWinnercurrentState()
        {
            return winnercurrentState;
        }

        public String toString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("\nMighty Gumball, Inc.");
            result.Append("\nJava-enabled Standing Gumball Model #2004");
            result.Append("\nInventory: " + count + " gumball");
            if (count != 1)
            {
                result.Append("s");
            }
            result.Append("\n");
            result.Append("Machine is " + currentState + "\n");
            return result.ToString();
        }

    }
}
