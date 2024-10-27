using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lift___sir
{
    internal class MovingUpState : ILiftState
    {
        public void MovingDown(Lift lift)
        {
            /* Do Nothing */
        }

        public void MovingUp(Lift lift)
        {

            if (lift.MainElevetor.Top > 0)
            {
                lift.MainElevetor.Top -= lift.LiftSpeed;
            }
            else
            {
                // Once it reaches the top, transition to StoppedState
                lift.SetState(new IdleState());
                lift.MainElevetor.Top = 0;
                lift.button_up.BackColor = Color.White;
                lift.LiftTimer.Stop();  // Stop the timer when it reaches the top
                lift.button_down.Enabled = true;  // Re-enable the G button
                lift.button_up.Enabled = true;  // Enable other controls
            }
        }
    }
}
