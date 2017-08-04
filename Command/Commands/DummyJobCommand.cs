using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    public class DummyJobCommand : ICommand
    {
        private static Random rnd = new Random();
        public DummyJobCommand(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void Execute()
        {
            //Console.WriteLine("Executing " + Name);
            Thread.Sleep(rnd.Next(500, 1200));
        }

        public void Undo()
        { }
    }
}
