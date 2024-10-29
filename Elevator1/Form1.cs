using System.Data;
using System.Data.SqlClient;
using lift___sir;



namespace Elevator1

{
    public partial class Form1 : Form
    {
        private readonly EmergencyAlarm _emergencyAlarm;
        bool isMovingUp = false;
        bool isMovingDown = false;
        int liftSpeed = 5;
        bool isClosing = false;
        bool isOpening = false;
        int doorSpeed = 5;
        int doorMaxOpenWidth;
        string alarmSoundPath = @"C:\Users\LENOVO\Downloads\mixkit-alert-alarm-1005.wav";

        private lift lift;
        DataTable dt = new DataTable();
        DBContext db = new DBContext();
        int maxLiftHeight = 100;
        bool isWaitingForMove;
        bool moveUpAfterClose;
        bool moveDownAfterClose;

        public Form1()
        {
            InitializeComponent();
            lift = new lift(mainElevator, button_g, button_up, this.ClientSize.Height, liftSpeed, lifttimer, doorTimer);
            _emergencyAlarm = new EmergencyAlarm(alarmSoundPath);
            doorMaxOpenWidth = mainElevator.Width / 2 + 110;

            dataGridViewLogs.ColumnCount = 2;
            dataGridViewLogs.Columns[0].Name = "Time";
            dataGridViewLogs.Columns[1].Name = "Events";

            dt.Columns.Add("Logtime");
            dt.Columns.Add("EventDescription");

        }
        private void logEvents(string message)
        {
            string currentTime = DateTime.Now.ToString("hh:mm:ss");
            dt.Rows.Add(currentTime, message);
            dataGridViewLogs.Rows.Add(currentTime, message);


            db.InsertLogsIntoDB(dt);
        }


        private void From1_Load(object sender, EventArgs e)
        {
            db.loadLogsFormDB(dt, dataGridViewLogs);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (isOpening) {

                isOpening = false;
                isClosing = true;
                doorTimer.Start();
                btn_open.Enabled = false;
                doorTimer.Tick += onDoorClose;
                logEvents("Lift JadaiCha");
            }
            else
            {
                MoveLiftup();
            }
            //isMovingUp = true;
            //isMovingDown = false;
            //lift.SetState(new MovingUpState);

            //lifttimer.Start();

            //button_g.Enabled = false;
            //logEvents("Lift JadaiCha");
            //btn_color1.BackColor = Color.Green;
            //btn_colorG.BackColor = Color.Red;

            //btnG2.BackColor = Color.Green;
            //btnG1.BackColor = Color.Red;

        }

        private void onDoorClose(object sender, EventArgs e)
        {
            if (!isOpening && !isClosing)
            {
                MoveLiftup();
                doorTimer.Tick += onDoorClose;
            }
            else
            {
                MoveLiftup();

            }

        }

        private void MoveLiftup()
        {
            isMovingUp = true;
            isMovingDown = false;
            lift.SetState(new MovingUpState());

            lifttimer.Start();

            button_g.Enabled = false;

            btn_color1.BackColor = Color.Green;
            btn_colorG.BackColor = Color.Red;

            btnG2.BackColor = Color.Green;
            btnG1.BackColor = Color.Red;

            if (isMovingUp)
            {
                button_up.BackColor = Color.LightGreen;
                if (mainElevator.Top > 0)
                {
                    mainElevator.Top -= liftSpeed;

                }
                else
                {
                    lifttimer.Stop();
                    mainElevator.Top = 0;
                    button_g.Enabled = true;
                }
            }



        }


        private void button_g_Click(object sender, EventArgs e)
        {
            //isMovingUp = false;
            //isMovingDown = true;
            //lift.SetState(new MovingDownState);
            //lifttimer.Start();

            //button_up.Enabled = false;
            //logEvents("Lift Jhardai Cha");

            //btn_colorG.BackColor = Color.Green;
            //btn_color1.BackColor = Color.Red;

            //btnG1.BackColor = Color.Green;
            //btnG2.BackColor = Color.Red;

            if (isOpening)
            {
                isOpening = false;
                isClosing = true;
                doorTimer.Start();
                btn_open.Enabled = false;
                doorTimer.Tick += onDoorClose;
            }
            else
            {
                MoveLiftDown();
            }


        }
        private void MoveLiftDown()
        {
            isMovingUp = false;
            isMovingDown = true;
            lift.SetState(new MovingDownState());
            lifttimer.Start();

            button_up.Enabled = false;
            logEvents("Lift Jhardai Cha");

            btn_colorG.BackColor = Color.Green;
            btn_color1.BackColor = Color.Red;

            btnG1.BackColor = Color.Green;
            btnG2.BackColor = Color.Red;

            if (isMovingDown)
            {
                button_g.BackColor = Color.LightGreen;
                button_up.BackColor = Color.LightGreen;
                if (mainElevator.Bottom < this.ClientSize.Height)
                {
                    mainElevator.Top += liftSpeed;

                }
                else
                {
                    lifttimer.Stop();

                    button_up.Enabled = true;
                }
            }

        }


        private void btn_Open_Click(object sender, EventArgs e)
        {
            isOpening = true;
            isClosing = false;
            doorTimer.Start();
            btn_Close.Enabled = false;
            logEvents("Lift khuldai cha");
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            isOpening = false;
            isClosing = true;
            doorTimer.Start();
            btn_open.Enabled = false;
            logEvents("lift banda hudai cha");

        }



        private void lifttimer_Tick(object sender, EventArgs e)
        {
            lift.MovingUp();
            lift.MovingDown();
            //if (isMovingUp)
            //{
            //    button_up.BackColor = Color.LightGreen;
            //    if (mainElevator.Top > 0)
            //    {
            //        mainElevator.Top -= liftSpeed;

            //    }
            //    else
            //    {
            //        lifttimer.Stop();
            //        mainElevator.Top = 0;
            //        button_g.Enabled = true;
            //    }
            //}
            //if (isMovingDown)
            //{
            //    button_g.BackColor = Color.LightGreen;
            //    button_up.BackColor = Color.LightGreen;
            //    if (mainElevator.Bottom < this.ClientSize.Height)
            //    {
            //        mainElevator.Top += liftSpeed;

            //    }
            //    else
            //    {
            //        lifttimer.Stop();

            //        button_up.Enabled = true;
            //    }
            //}



        }

        private void doorTimer_Tick(object sender, EventArgs e)
        {

            if (mainElevator.Top != 0)
            {
                if (isOpening)
                {
                    if (doorleft_G.Left > doorMaxOpenWidth /2+80)
                    {
                        doorleft_G.Left -= doorSpeed;
                        doorright_G.Left += doorSpeed;
                    }
                    else
                    {
                        doorTimer.Stop();
                        btn_Close.Enabled = true;
                    }


                }

                if (isClosing)
                {
                    if (doorleft_G.Right < mainElevator.Width + doorMaxOpenWidth / 2)
                    {
                        doorleft_G.Left += doorSpeed;
                        doorright_G.Left -= doorSpeed;
                    }
                    else
                    {
                        doorTimer.Stop();
                        btn_open.Enabled = true;
                    }
                }
            }

            //if(isWaitingForMove)
            //{
            //    isWaitingForMove = false;
            //    if(moveUpAfterClose)
            //    {
            //        StartMovingUp();
            //        moveUpAfterClose = false;
            //    }
            //    else
            //    if(moveDownAfterClose)
            //    {
            //        StartMovingDown();
            //        moveUpAfterClose= false;

            //    }
            //}
            else
            {
                if (isOpening)
                {
                    if (doorleft1.Left > mainElevator.Width / 2+60)
                    {
                        doorleft1.Left -= doorSpeed;
                        doorright1.Left += doorSpeed;
                    }
                    else
                    {
                        doorTimer.Stop();
                        btn_Close.Enabled = true;
                    }


                }

                if (isClosing)
                {
                    if (doorleft1.Right < mainElevator.Width + doorMaxOpenWidth / 2)
                    {
                        doorleft1.Left += doorSpeed;
                        doorright1.Left -= doorSpeed;
                    }
                    else
                    {
                        doorTimer.Stop();
                        btn_open.Enabled = true;
                    }
                }

            }



        }


        private void doorleft_G_Click(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            db.DeleteLogFromDB(dt);
            dataGridViewLogs.Rows.Clear();
        }


        private void EmergencyAlarm_Click(object sender, EventArgs e)
        {
            if (!_emergencyAlarm.IsActive)
            {
                _emergencyAlarm.Activate();

                logEvents("Alarm is on");
            }
            else
            {
                _emergencyAlarm.Deactivate();
                logEvents("Alarm is off");
            }

        }
    }

}
