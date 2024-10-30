using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator1
{
    internal interface ILiftState
    {
        void MovingUp(Lift lift);
        void MovingDown(Lift lift);
        void OpenButton(Lift lift);
        void CloseButton(Lift lift);
        void LiftTimer(Lift lift);
        void DoorTimer1(Lift lift);
        void DoorTimer2(Lift lift);
    }
}