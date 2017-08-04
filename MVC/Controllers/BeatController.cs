using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    class BeatController : IController
    {
        private readonly IBeatModel _beatModel;
        private readonly IBeatView _beatView;

        public BeatController(IBeatModel beatModel)
        {
            this._beatModel = beatModel;
        }

        public void DecreaseBPM()
        {
            throw new NotImplementedException();
        }

        public void IncreaseBPM()
        {
            throw new NotImplementedException();
        }

        public void SetBPM(int value)
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
