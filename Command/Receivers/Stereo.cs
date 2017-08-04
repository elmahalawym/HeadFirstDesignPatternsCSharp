using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Receivers
{
    public class Stereo
    {
        public Stereo(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
        
        public bool IsON { get; set; }

        public void On()
        {
            Console.WriteLine(IsON ? String.Format("{0} Stereo is already ON", this.Name) :
                String.Format("{0} Stereo is ON", this.Name));
            IsON = true;
        }

        public void Off()
        {
            Console.WriteLine(IsON ? String.Format("{0} Stereo is OFF", this.Name) :
                String.Format("{0} Stereo is already OFF", this.Name));
            IsON = false;
        }
    }
}
