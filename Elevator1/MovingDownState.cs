using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator1
{
    internal class MovingDownStateConcreteClass : ILiftState
    {
        public void MovingUp(Lift lift)
        {
            //do Nothing 
        }

        private Form1 form;

        public MovingDownStateConcreteClass(Form1 mainForm)
        {
            form = mainForm;
        }

        public void MovingDown(Lift lift)
        {
            if (lift.Mainelevator.Bottom != lift.GroundFloorNoElevator.Bottom) // not on the ground floor 
            {
                if (!(lift.doorsClosed))
                {
                    lift.SetState(new BtnCloseElevatorClickConcreteClass(form));
                    lift.BtnCloseElevatorClick();

                    // Attach event to doorTimer2 to wait for the doors to close
                    EventHandler doorCloseHandler = null;
                    doorCloseHandler = (s, args) =>
                    {
                        if (lift.doorsClosed)
                        {
                            lift.isMovingDown = true;
                            lift.isMovingUp = false;
                            lift.GroundFloorButton.BackColor = Color.GreenYellow;
                            lift.ComeToGroundFloorButton.BackColor = Color.GreenYellow;
                            lift.LiftTimer.Start();
                            form.logEvents("Lift moving to Ground Floor");

                            lift.FirstFloorScreen.Visible = false;
                            lift.UpArrowScreen.Visible = false;
                            lift.DownArrowScreen.Visible = true;
                            lift.GroundFloorScreen.Visible = false;
                            lift.EmergencyBellScreen.Visible = false;

                            // Unsubscribe from doorTimer2 after closing the doors
                            lift.DoorTimerr2.Tick -= doorCloseHandler;
                        }
                    };
                    lift.DoorTimerr2.Tick += doorCloseHandler;
                }
                else
                {
                    lift.isMovingDown = true;
                    lift.isMovingUp = false;
                    lift.lifttimer.Start();
                    form.logEvents("Lift moving to Ground Floor");

                    lift.FirstFloorScreen.Visible = false;
                    lift.UpArrowScreen.Visible = false;
                    lift.DownArrowScreen.Visible = true;
                    lift.GroundFloorScreen.Visible = false;
                    lift.EmergencyBellScreen.Visible = false;
                }

                // Attach event to liftTimer to wait for the lift to reach the ground floor
                EventHandler liftMoveHandler = null;
                liftMoveHandler = (s, args) =>
                {
                    if (lift.Mainelevator.Top == lift.GroundFloorNoElevator.Top)
                    {
                        lift.LiftTimer.Stop();
                        form.logEvents("Lift arrived at Ground Floor");
                        lift.GroundFloorScreen.Visible = true;
                        lift.UpArrowScreen.Visible = false;
                        lift.DownArrowScreen.Visible = false;
                        lift.FirstFloorScreen.Visible = false;
                        lift.EmergencyBellScreen.Visible = false;
                        lift.SetState(new BtnOpenElevatorClickConcreteClass(form));
                        lift.BtnOpenElevatorClick();

                        // Unsubscribe from liftTimer after reaching the ground floor
                        lift.LiftTimer.Tick -= liftMoveHandler;

                        // Reset movement flags to prevent unintended further movement
                        lift.isMovingUp = false;
                        lift.isMovingDown = false;
                    }
                };
                lift.LiftTimer.Tick += liftMoveHandler;
            }
            else
            {
                lift.GroundFloorButton.BackColor = Color.Transparent;
                lift.ComeToGroundFloorButton.BackColor = Color.Transparent;
                lift.LiftTimer.Stop();
                form.logEvents("Lift is on the Ground Floor");

                lift.GroundFloorScreen.Visible = true;
                lift.FirstFloorScreen.Visible = false;
                lift.UpArrowScreen.Visible = false;
                lift.DownArrowScreen.Visible = false;
                lift.EmergencyBellScreen.Visible = false;
            }
        }

        public void CloseButton(Lift lift) { }
        public void OpenButton(Lift lift) { }
        public void LiftTimer(Lift lift) { }
        public void DoorTimer1(Lift lift) { }
        public void DoorTimer2(Lift lift) { }
    }
}