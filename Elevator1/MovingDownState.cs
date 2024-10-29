using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lift___sir
{
    internal class MovingDownState : ILiftState
    {
        public void MovingDown(lift lift)
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
                lift.Button_up.BackColor = Color.White;
                lift.LiftTimer.Stop();  // Stop the timer when it reaches the bottom
                lift.Button_up.Enabled = true;  // Re-enable the 1st floor button
                lift.Button_down.Enabled = true;  // Enable other controls
            }
        }

        public void MovingUp(lift lift)
        {
            /* Do Nothing */
        }
    }
}