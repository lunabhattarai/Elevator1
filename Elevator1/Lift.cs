using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;


namespace Elevator1
{
    internal class Lift
    {
        public ILiftState _CurrentState;
        public PictureBox Mainelevator;
        public Button Btnf;
        public Button Btng;
        public Button Btnopen;
        public Button Btnclose;
        public Timer Lifttimer;
        public Timer Doortimer1;
        public Timer Doortimer2;
        public Button Btnfirst;
        public Button Btnground;
        public PictureBox Doorleft1;
        public PictureBox Doorright1;
        public PictureBox Doorleft2;
        public PictureBox Doorright2;
        public DataGridView Datagridviewlogs;
        public Button Btnclear;
        public Button Btnexit;
        public PictureBox Gfloor;
        public PictureBox Ffloor;

        public bool movingup = false;
        public bool movingdown = false;
        public bool opening1 = false;
        public bool closing1 = false;
        public bool opening2 = false;
        public bool closing2 = false;
        public bool doorsclosed = true;
        public int liftspeed = 5;
        public int doorspeed = 5;
        public int doormaxopenwidth;



        public Lift(
            PictureBox mainelevator,
            Button btnf,
            Button btng,
            Button btnopen,
            Button btnclose,
            Timer lifttimer,
            Timer doortimer1,
            Timer doortimer2,
            Button btnfirst,
            Button btnground,
            PictureBox doorleft1,
            PictureBox doorleft2,
            PictureBox doorright1,
            PictureBox doorright2,
            DataGridView datagridviewlogs,
            Button btnclear, 
            Button btnexit, 
            PictureBox gfloor, 
            PictureBox ffloor)
        {

            Mainelevator = mainelevator;
            Btnf = btnf;
            Btng = btng;
            Btnopen = btnopen;
            Btnclose = btnclose;
            Lifttimer = lifttimer;
            Doortimer1 = doortimer1;
            Doortimer2 = doortimer2;
            Btnfirst = btnfirst;
            Btnground = btnground;
            Doorleft1 = doorleft1;
            Doorright1 = doorright1;
            Doorleft2 = doorleft2;
            Doorright2 = doorright2;
            Datagridviewlogs = datagridviewlogs;
            Btnclear = btnclear;
            Btnexit = btnexit;
            Gfloor = gfloor;
            Ffloor = ffloor;
            _CurrentState = new IdleStateConcreteClass();
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

        public void OpenButton()
        {
            _CurrentState.OpenButton(this);
        }

        public void CloseButton()
        {
            _CurrentState.CloseButton(this);
        }


        public void LiftTimer()
        {
            _CurrentState.LiftTimer(this);
        }

        public void DoorTimer1()
        {
            _CurrentState.DoorTimer1(this);
        }

        public void DoorTimer2()
        {
            _CurrentState.DoorTimer2(this);
        }
    }
}