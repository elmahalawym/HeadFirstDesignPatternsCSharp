using CommandPattern.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    public class CeilingFanOnCommand : ICommand
    {
        public CeilingFanOnCommand(CeilingFan ceilingFan)
        {
            this.CeilingFan = ceilingFan;
        }

        public CeilingFan CeilingFan { get; set; }

        public void Execute()
        {
            this.CeilingFan.On();
        }

        public void Undo()
        {
            this.CeilingFan.Off();
        }
    }
}
