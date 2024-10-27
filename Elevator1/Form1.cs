using System.Data;
using System.Data.SqlClient;



namespace Elevator1

{
    public partial class Form1 : Form
    {
        bool isMovingUp = false;
        bool isMovingDown = false;
        int liftSpeed = 5;
        bool isClosing = false;
        bool isOpening = false;
        int doorSpeed = 5;
        int doorMaxOpenWidth;

        
        DataTable dt = new DataTable();
        DBContext db = new DBContext();
        //private Lift elevator = new ILift();

        public Form1()
        {
            InitializeComponent();
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
            isMovingUp = true;
            isMovingDown = false;
            lifttimer.Start();

            button_g.Enabled = false;
            logEvents("Lift JadaiCha");


        }
        private void button_g_Click(object sender, EventArgs e)
        {
            isMovingUp = false;
            isMovingDown = true;
            lifttimer.Start();

            button_up.Enabled = false;
            logEvents("Lift Jhardai Cha");

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

        private void doorTimer_Tick(object sender, EventArgs e)
        {

            if (mainElevator.Top != 0)
            {
                if (isOpening)
                {
                    if (doorleft_G.Left > doorMaxOpenWidth / 2)
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
            else
            {
                if (isOpening)
                {
                    if (doorleft1.Left > mainElevator.Width / 2)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            db.DeleteLogFromDB(dt);
            dataGridViewLogs.Rows.Clear();
        }
    }
}