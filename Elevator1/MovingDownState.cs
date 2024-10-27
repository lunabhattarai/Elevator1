using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lift___sir
{
    internal class MovingDownState : ILiftState
    {
        public void MovingDown(Lift lift)
        {
            if (lift.MainElevetor.Top == 0 || lift.MainElevetor.Bottom < lift.FormSize)
            {
                lift.MainElevetor.Top += lift.LiftSpeed + 10;
            }
            else
            {
                // Once it reaches the bottom, transition to StoppedState
                lift.SetState(new IdleState());
                lift.MainElevetor.Top = lift.FormSize - lift.MainElevetor.Height;
                lift.button_up.BackColor = Color.White;
                lift.LiftTimerDown.Stop();  // Stop the timer when it reaches the bottom
                lift.button_up.Enabled = true;  // Re-enable the 1st floor button
                lift.button_down.Enabled = true;  // Enable other controls
            }
        }

        public void MovingUp(Lift lift)
        {
            /* Do Nothing */
        }
    }
}