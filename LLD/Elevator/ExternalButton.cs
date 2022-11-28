using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    internal class ExternalButton
    {
        private readonly ExternalButtonDispatcher _externalButtonDispatcher;

        public ExternalButton()
        {
            _externalButtonDispatcher = new ExternalButtonDispatcher();
        }

        public void PressButton(int floor, Direction dir)
        {
            _externalButtonDispatcher.SubmitRequest(floor, dir);
        }
    }
}
