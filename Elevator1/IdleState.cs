using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator1
{
    internal class IdleStateConcreteClass : ILiftState
    {
        public void CloseButton(Lift lift)
        {
        }

        public void OpenButton(Lift lift)
        {
        }

        public void MovingUp(Lift lift)
        {
        }

        public void MovingDown(Lift lift)
        {
        }


        public void LiftTimer(Lift lift)
        {
        }

        public void DoorTimer1(Lift lift)
        {
        }

        public void DoorTimer2(Lift lift)
        {
        }
    }
}