using CommandPattern.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    public class StereoOnCommand : ICommand
    {
        public StereoOnCommand(Stereo stereo)
        {
            Stereo = stereo;
        }

        public Stereo Stereo { get; set; }

        public void Execute()
        {
            Stereo.On();
        }

        public void Undo()
        {
            Stereo.Off();
        }
    }
}
