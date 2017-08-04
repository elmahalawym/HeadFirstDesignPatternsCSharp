using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Receivers
{
    public class GarageDoor
    {
        public bool IsOpened { get; set; }

        public void Open()
        {
            Console.WriteLine(IsOpened ? "Garage is already Opened" : "Garage Door is now Opened");
            IsOpened = true;
        }

        public void Close()
        {
            Console.WriteLine(IsOpened ? "Garage is now Closed" : "Garage Door is already Cpened");
            IsOpened = false;
        }
    }
}
