using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator1
{
    internal class DoorTimer2StateConcreteClass : ILiftState
    {
        private Form1 form;

        public DoorTimer2StateConcreteClass(Form1 mainForm)
        {
            form = mainForm;
        }
        public void DoorTimer2(Lift lift)
        {
            if (lift.isopening)
            {
                if (lift.LeftDoor2.Left > lift.doorMaxOpenWidth / 2 + 106)
                {
                    lift.LeftDoor2.Left -= lift.doorSpeed;
                    lift.RightDoor2.Left += lift.doorSpeed;
                    lift.OpenElevatorButton.BackColor = Color.Aqua;
                    lift.CloseElevatorButton.Enabled = false;
                    lift.FirstFloorButton.Enabled = false;
                    lift.GroundFloorButton.Enabled = false;
                    lift.ComeToFirstFloorButton.Enabled = false;
                    lift.ComeToGroundFloorButton.Enabled = false;
                }
                else
                {
                    lift.DoorTimerr2.Stop();
                    lift.OpenElevatorButton.BackColor = Color.Transparent;
                    lift.CloseElevatorButton.Enabled = true;
                    lift.FirstFloorButton.Enabled = true;
                    lift.GroundFloorButton.Enabled = true;
                    lift.ComeToFirstFloorButton.Enabled = true;
                    lift.ComeToGroundFloorButton.Enabled = true;
                    lift.doorsClosed = false; // Doors are open
                }
            }
            if (lift.isClosing2)
            {
                if (lift.LeftDoor2.Right < lift.Mainelevator.Width + lift.doorMaxOpenWidth / 2 + 106)
                {
                    lift.LeftDoor2.Left += lift.doorSpeed;
                    lift.RightDoor2.Left -= lift.doorSpeed;
                    lift.CloseElevatorButton.BackColor = Color.Aqua;
                    lift.OpenElevatorButton.Enabled = false;
                    lift.FirstFloorButton.Enabled = false;
                    lift.GroundFloorButton.Enabled = false;
                    lift.ComeToFirstFloorButton.Enabled = false;
                    lift.ComeToGroundFloorButton.Enabled = false;
                }
                else
                {
                    lift.DoorTimerr2.Stop();
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
        public void DoorTimer1(Lift lift) { }
    }
}