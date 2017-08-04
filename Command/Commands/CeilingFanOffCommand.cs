using CommandPattern.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    public class CeilingFanOffCommand : ICommand
    {
        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            this.CeilingFan = ceilingFan;
        }

        public CeilingFan CeilingFan { get; set; }

        public void Execute()
        {
            this.CeilingFan.Off();
        }

        public void Undo()
        {
            this.CeilingFan.On();
        }
    }
}
