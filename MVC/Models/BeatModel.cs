using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MVC.Models
{
    class BeatModel : IBeatModel
    {
        Timer timer = new Timer();
        int bpm = 90;

        public BeatModel()
        {
            timer.Elapsed += Timer_Elapsed;
        }



        public int BPM
        {
            get
            {
                return bpm;
            }

            set
            {
                bpm = value;
                timer.Interval = bpm;
                BPMChanged?.Invoke(bpm);
            }
        }


        public event Action Beat;
        public event Action<int> BPMChanged;


        public void Off()
        {
            BPM = 0;
            timer.Stop();
        }

        public void On()
        {
            BPM = 90;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Beat?.Invoke();
        }
    }
}
