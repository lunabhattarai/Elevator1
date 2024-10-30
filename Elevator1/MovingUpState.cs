using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator1
{
    internal class MovingUpStateConcreteClass : ILiftState
    {
        public void MovingDown(Lift lift)
        {
            //do Nothing 
        }

        private Form1 form;

        public MovingUpStateConcreteClass(Form1 mainForm)
        {
            form = mainForm;
        }

        public void MovingUp(Lift lift)
        {
            if (context.MainElevator.Bottom != context.FirstFloorNoElevator.Bottom) //not on first floor
            {
                if (!(context.doorsClosed))
                {
                    //btn_close_elevator_click(sender, e);
                    context.SetState(new BtnCloseElevatorClickConcreteClass(form));
                    context.BtnCloseElevatorClick();

                    // Attach event to doorTimer1 to wait for the doors to close
                    EventHandler doorCloseHandler = null;
                    doorCloseHandler = (s, args) =>
                    {
                        if (context.doorsClosed)
                        {
                            context.isMovingUp = true;
                            context.isMovingDown = false;
                            context.FirstFloorButton.BackColor = Color.GreenYellow;
                            context.ComeToFirstFloorButton.BackColor = Color.GreenYellow;
                            context.LiftTimer.Start();
                            form.logEvents("Lift moving to First Floor");

                            context.GroundFloorScreen.Visible = false;
                            context.UpArrowScreen.Visible = true;
                            context.DownArrowScreen.Visible = false;
                            context.FirstFloorScreen.Visible = false;
                            context.EmergencyBellScreen.Visible = false;

                            // Unsubscribe from doorTimer1 after closing the doors
                            context.DoorTimerr1.Tick -= doorCloseHandler;
                        }
                    };
                    context.DoorTimerr1.Tick += doorCloseHandler;
                }
                else
                {
                    context.isMovingUp = true;
                    context.isMovingDown = false;
                    context.LiftTimer.Start();
                    form.logEvents("Lift moving to First Floor");

                    context.GroundFloorScreen.Visible = false;
                    context.UpArrowScreen.Visible = true;
                    context.DownArrowScreen.Visible = false;
                    context.FirstFloorScreen.Visible = false;
                    context.EmergencyBellScreen.Visible = false;
                }

                // Attach event to liftTimer to wait for the lift to reach the first floor

                EventHandler liftMoveHandler = null;
                liftMoveHandler = (s, args) =>
                {
                    if (context.MainElevator.Top == context.FirstFloorNoElevator.Top)
                    {
                        context.LiftTimer.Stop();
                        form.logEvents("Lift arrived at First Floor");
                        context.GroundFloorScreen.Visible = false;
                        context.UpArrowScreen.Visible = false;
                        context.DownArrowScreen.Visible = false;
                        context.FirstFloorScreen.Visible = true;
                        context.EmergencyBellScreen.Visible = false;
                        context.SetState(new BtnOpenElevatorClickConcreteClass(form));
                        context.BtnOpenElevatorClick();

                        // Unsubscribe from liftTimer after reaching the first floor
                        context.LiftTimer.Tick -= liftMoveHandler;

                        // Reset movement flags to prevent unintended further movement
                        context.isMovingUp = false;
                        context.isMovingDown = false;
                    }
                };
                context.LiftTimer.Tick += liftMoveHandler;
            }
            else
            {
                context.FirstFloorButton.BackColor = Color.Transparent;
                context.ComeToFirstFloorButton.BackColor = Color.Transparent;
                context.LiftTimer.Stop();
                form.logEvents("Lift is on the First Floor");

                context.FirstFloorScreen.Visible = true;
                context.UpArrowScreen.Visible = false;
                context.DownArrowScreen.Visible = false;
                context.GroundFloorScreen.Visible = false;
                context.EmergencyBellScreen.Visible = false;
            }
        }
        public void CloseButton(Lift lift) { }
        public void OpenButton(Lift lift) { }
        public void LiftTimer(Lift lift) { }
        public void DoorTimer1(Lift lift) { }
        public void DoorTimer2(Lift lift) { }
    }
}