using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Receivers
{
    public class CeilingFan
    {
        public CeilingFan(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public bool IsON { get; set; }

        public void On()
        {
            Console.WriteLine(IsON ? String.Format("{0} CeilingFan is already ON", this.Name) :
                String.Format("{0} CeilingFan is ON", this.Name));
            IsON = true;
        }

        public void Off()
        {
            Console.WriteLine(IsON ? String.Format("{0} CeilingFan is OFF", this.Name) :
                String.Format("{0} CeilingFan is already OFF", this.Name));
            IsON = false;
        }
    }
}
