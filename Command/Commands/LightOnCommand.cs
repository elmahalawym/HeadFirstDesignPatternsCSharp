using CommandPattern.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    public class LightOnCommand : ICommand
    {
        public LightOnCommand(Light light)
        {
            this.Light = light;
        }

        public Light Light { get; set; }

        public void Execute()
        {
            Light.On();
        }

        public void Undo()
        {
            Light.Off();
        }
    }
}
