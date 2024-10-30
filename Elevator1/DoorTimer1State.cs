using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator1
{
    internal class DoorTimer1StateConcreteClass : ILiftState
    {
        private Form1 form;

        public DoorTimer1StateConcreteClass(Form1 mainForm)
        {
            form = mainForm;
        }

        public void DoorTimer1(Lift lift)
        {
            if (lift.isOpening1)
            {
                if (lift.LeftDoor1.Left > context.doorMaxOpenWidth / 2 + 106)
                {
                    lift.LeftDoor1.Left -= context.doorSpeed;
                    lift.RightDoor1.Left += context.doorSpeed;
                    lift.OpenElevatorButton.BackColor = Color.Aqua;
                    lift.CloseElevatorButton.Enabled = false;
                    lift.FirstFloorButton.Enabled = false;
                    lift.GroundFloorButton.Enabled = false;
                    lift.ComeToFirstFloorButton.Enabled = false;
                    lift.ComeToGroundFloorButton.Enabled = false;
                }
                else
                {
                    lift.DoorTimerr1.Stop();
                    lift.OpenElevatorButton.BackColor = Color.Transparent;
                    lift.CloseElevatorButton.Enabled = true;
                    lift.FirstFloorButton.Enabled = true;
                    lift.GroundFloorButton.Enabled = true;
                    lift.ComeToFirstFloorButton.Enabled = true;
                    lift.ComeToGroundFloorButton.Enabled = true;
                    lift.doorsClosed = false; // Doors are open
                }
            }
            if (lift.isClosing1)
            {
                if (lift.LeftDoor1.Right < lift.MainElevator.Width + context.doorMaxOpenWidth / 2 + 106)
                {
                    lift.LeftDoor1.Left += lift.doorSpeed;
                    lift.RightDoor1.Left -= context.doorSpeed;
                    lift.CloseElevatorButton.BackColor = Color.Aqua;
                    lift.OpenElevatorButton.Enabled = false;
                    lift.FirstFloorButton.Enabled = false;
                    lift.GroundFloorButton.Enabled = false;
                    lift.ComeToFirstFloorButton.Enabled = false;
                    lift.ComeToGroundFloorButton.Enabled = false;
                }
                else
                {
                    lift.DoorTimerr1.Stop();
                    lift.CloseElevatorButton.BackColor = Color.Transparent;
                    lift.OpenElevatorButton.Enabled = true;
                    lift.FirstFloorButton.Enabled = true;
                    lift.GroundFloorButton.Enabled = true;
                    lift.ComeToFirstFloorButton.Enabled = true;
                    lift.ComeToGroundFloorButton.Enabled = true;
                    lift.doorsClosed = true; // Doors are closed
                }
            }
        }

        public void OpenButton(Lift lift) { }
        public void CloseButton(Lift lift) { }
        public void MovingUp(Lift lift) { }
        public void MovingDown(Lift lift) { }
        public void LiftTimer(Lift lift) { }
        public void DoorTimer2(Lift lift) { }
    }
}