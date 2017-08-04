using CommandPattern.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    public class LightOffCommand : ICommand
    {
        public LightOffCommand(Light light)
        {
            this.Light = light;
        }

        public Light Light { get; set; }

        public void Execute()
        {
            Light.Off();
        }

        public void Undo()
        {
            Light.On();
        }
    }
}
