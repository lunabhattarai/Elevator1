using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;//new code
namespace lift___sir
{
    internal class lift
    {
        public ILiftState _CurrentState;

        public PictureBox MainElevetor;
        public Button Button_up;
        public Button Button_down;
       
        public int LiftSpeed;
        public Timer LiftTimer;
        public Timer DoorTimer;
        public int FormSize;

        public lift(PictureBox mainElevator, Button button_up, Button button_down, int formSize, int liftspeed, Timer lifttimer, Timer doorTimer)
        {
            MainElevetor = mainElevator;
            Button_up = button_up;
            Button_down = button_down;
            FormSize = formSize;
            LiftSpeed = liftspeed;
            LiftTimer = lifttimer;
            DoorTimer = doorTimer;

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
