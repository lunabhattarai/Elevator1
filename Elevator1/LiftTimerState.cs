using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Elevator1
{
    internal class LiftTimerStateConcreteClass : ILiftState
    {
        private Form1 form;

        public LiftTimerStateConcreteClass(Form1 mainForm)
        {
            form = mainForm;
        }
        public void LiftTimer(Lift lift)
        {
            if (lift.ismovingup)
            {
                lift.doortimer1.Start();
                lift.btnfirst.BackColor = Color.GreenYellow;
                lift.ComeToFirstFloorButton.BackColor = Color.GreenYellow;
                lift.GroundFloorButton.Enabled = false;
                lift.OpenElevatorButton.Enabled = false;
                lift.CloseElevatorButton.Enabled = false;
                lift.ComeToGroundFloorButton.Enabled = false;
                if (lift.Mainelevator.Top > lift.FirstFloorNoElevator.Top)
                {
                    lift.Mainelevator.Top -= lift.liftSpeed;
                }
                else
                {
                    lift.DoorTimerr1.Stop();
                    lift.FirstFloorButton.BackColor = Color.Transparent;
                    lift.ComeToFirstFloorButton.BackColor = Color.Transparent;
                    lift.MainElevator.Top = context.FirstFloorNoElevator.Top;
                    lift.LiftTimer.Stop();
                    lift.GroundFloorButton.Enabled = true;
                    lift.OpenElevatorButton.Enabled = true;
                    lift.CloseElevatorButton.Enabled = true;
                    lift.ComeToGroundFloorButton.Enabled = true;

                    lift.BtnOpenElevatorClick();
                    lift.isMovingUp = false;

                    // Show first floor screen
                    lift.FirstFloorScreen.Visible = true;
                    lift.UpArrowScreen.Visible = false;
                    lift.DownArrowScreen.Visible = false;
                    lift.GroundFloorScreen.Visible = false;
                    lift.EmergencyBellScreen.Visible = false;
                }
            }

            if (lift.isMovingDown)
            {
                lift.DoorTimerr2.Start();
                lift.GroundFloorButton.BackColor = Color.GreenYellow;
                lift.ComeToGroundFloorButton.BackColor = Color.GreenYellow;
                lift.FirstFloorButton.Enabled = false;
                lift.OpenElevatorButton.Enabled = false;
                lift.CloseElevatorButton.Enabled = false;
                lift.ComeToFirstFloorButton.Enabled = false;
                if (lift.MainElevator.Top < context.GroundFloorNoElevator.Top)
                {
                    lift.Mainelevator.Top += lift.liftSpeed;
                }
                else
                {
                    lift.DoorTimerr2.Stop();
                    lift.GroundFloorButton.BackColor = Color.Transparent;
                    lift.ComeToGroundFloorButton.BackColor = Color.Transparent;
                    lift.LiftTimer.Stop();
                    lift.MainElevator.Top = context.GroundFloorNoElevator.Top;
                    lift.FirstFloorButton.Enabled = true;
                    lift.OpenElevatorButton.Enabled = true;
                    lift.CloseElevatorButton.Enabled = true;
                    lift.ComeToFirstFloorButton.Enabled = true;

                    lift.BtnOpenElevatorClick();
                    lift.isMovingUp = false;

                    // Show ground floor screen
                    lift.GroundFloorScreen.Visible = true;
                    lift.UpArrowScreen.Visible = false;
                    lift.DownArrowScreen.Visible = false;
                    lift.FirstFloorScreen.Visible = false;
                    lift.EmergencyBellScreen.Visible = false;
                }
            }
        }
        public void CloseButton(Lift lift) { }
        public void OpenButton(Lift lift) { }
        public void MovingDown(Lift lift) { }
        public void MovingUp(Lift lift) { }
        public void DoorTimer1(Lift lift) { }
        public void DoorTimer2(Lift lift) { }
    }
}