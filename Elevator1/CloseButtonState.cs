using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator1
{

    internal class CloseButtonStateConcreteClass : ILiftState
    {
        private Form1 form;

        public CloseButtonStateConcreteClass(Form1 mainForm)
        {
            form = mainForm;
        }

        public void CloseButton(Lift lift)
        {
            if (lift.Mainelevator.Bottom == lift.Ffloor.Bottom) // First floor
            {
                lift.opening2 = false;
                lift.closing2 = true;
                lift.Doortimer2.Start();
                lift.Btnopen.Enabled = false;
                lift.Btnf.Enabled = false;
                lift.Btng.Enabled = false;
                lift.Btnfirst.Enabled = false;
                lift.Btnground.Enabled = false;
                form.logEvents("Lift Door Closes on First Floor"); // Log event to the correct form instance
            }
            else if (lift.Mainelevator.Bottom == lift.Ffloor.Bottom) // Ground floor
            {
                lift.opening1 = false;
                lift.closing1 = true;
                lift.Doortimer1.Start();
                lift.Btnopen.Enabled = false;
                lift.Btnf.Enabled = false;
                lift.Btng.Enabled = false;
                lift.Btnfirst.Enabled = false;
                lift.Btnground.Enabled = false;
                form.logEvents("Lift Door Closes on Ground Floor");
            }
            else if (lift.Mainelevator.Bottom != lift.Ffloor.Bottom)
            {
                lift.ispening1 = false;
                lift.isOpening2 = false;
                lift.isClosing1 = true;
                lift.isClosing2 = true;
                lift.DoorTimerr1.Start();
                lift.DoorTimerr2.Start();
                lift.OpenElevatorButton.Enabled = false;
                lift.FirstFloorButton.Enabled = false;
                lift.GroundFloorButton.Enabled = false;
                lift.ComeToFirstFloorButton.Enabled = false;
                lift.ComeToGroundFloorButton.Enabled = false;
                form.logEvents("Doors closing.");
            }
            else
            {
                form.logEvents("Lift is not on any floor, Doors remain closed");
            }
        }

        public void OpenButton(Lift lift) { }
        public void MovingUp(Lift lift) { }
        public void MovingDow(Lift lift) { }
        public void LiftTimer(Lift lift) { }
        public void DoorTimer1(Lift lift) { }
        public void DoorTimer2(Lift lift) { }

        public void MovingDown(Lift lift)
        {
            throw new NotImplementedException();
        }
    }

}