using CommandPattern.Commands;
using CommandPattern.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            CommandsExamples();

        }

        private static void CommandsExamples()
        {
            // creating receivers
            var livingRoomLight = new Light("Living Room");
            var kitchenLight = new Light("Kitchen");
            var livingRoomCeilingFan = new CeilingFan("Living Room");
            var stereo = new Stereo("");

            // creating commands
            var livingRoomLightOnCommand = new LightOnCommand(livingRoomLight);
            var livingRoomLightOffCommand = new LightOffCommand(livingRoomLight);
            var kitchenLightOnCommand = new LightOnCommand(kitchenLight);
            var kitchenLightOffCommand = new LightOffCommand(kitchenLight);
            var stereoOnCommand = new StereoOnCommand(stereo);
            var stereoOffCommand = new StereoOffCommand(stereo);

            // Macro Command
            var myCommand = new MacroCommand(new ICommand[]
            {
                kitchenLightOnCommand,
                stereoOnCommand,
                livingRoomLightOffCommand
            });

            // create remove control & assign commands
            var remoteControl = new RemoteControl();
            remoteControl.SetCommand(0, livingRoomLightOnCommand);
            remoteControl.SetCommand(1, livingRoomLightOffCommand);
            remoteControl.SetCommand(2, kitchenLightOnCommand);
            remoteControl.SetCommand(3, kitchenLightOffCommand);
            remoteControl.SetCommand(4, stereoOnCommand);
            remoteControl.SetCommand(5, stereoOffCommand);

            // run commands
            //for (int i = 0; i < 6; i++)
            //    remoteControl.Run(i);

            //remoteControl.Run(0);
            //remoteControl.Run(0);
            //remoteControl.Run(0);
            //remoteControl.Undo();
            //remoteControl.Undo();
            //remoteControl.Undo();
            //remoteControl.Undo();
            myCommand.Execute();
            Console.WriteLine("------------------");
            myCommand.Undo();

            //Console.WriteLine(remoteControl);
        }

    }
}
