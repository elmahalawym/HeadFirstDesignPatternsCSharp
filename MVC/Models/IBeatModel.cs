using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Models
{
    interface IBeatModel
    {
        void On();

        void Off();

        int BPM { get; set; }

        event Action Beat;

        event Action<int> BPMChanged;
    }
}
