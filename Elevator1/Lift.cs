using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;//new code
namespace lift___sir
{
    internal class Lift
    {
        public ILiftState _CurrentState;

        public PictureBox MainElevetor;
        public Button button_up;
        public Button button_down;
        public int FormSize;
        public int LiftSpeed;
        public Timer LiftTimer;
        public Timer LiftTimerDown;
        private int height;

        public Lift(PictureBox mainElevetor, Button button_up, Button button_down, int formSize, int liftSpeed, System.Windows.Forms.Timer liftTimer1, Timer liftTimer, Timer liftTimerDown)
        {
            MainElevetor = mainElevetor;
            button_up = button_up;
            button_down = button_down;
            FormSize = formSize;
            LiftSpeed = liftSpeed;
            LiftTimer = liftTimer;
            LiftTimerDown = liftTimerDown;
            _CurrentState = new IdleState();



        }


        public void SetState(ILiftState state)
        {
            _CurrentState = state;
        }

        public void MovingUp()
        {
            _CurrentState.MovingUp(this);
        }

        public void MovingDown()
        {
            _CurrentState.MovingDown(this);
        }
    }


}
