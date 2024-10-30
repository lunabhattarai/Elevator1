using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Xml.Linq;
using System.Timers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Reflection.Emit;

namespace Elevator1
{
    public partial class Form1 : Form
    {
        bool movingup = false;
        bool movingdown = false;
        bool opening1 = false;
        bool closing1 = false;
        bool opening2 = false;
        bool closing2 = false;
        bool doorsclosed = true;
        int liftspeed = 5;
        int doorspeed = 5;
        int doormaxopenwidth;

        private Lift lift;
        DataTable dt = new DataTable();
        DBContext dbContext = new DBContext();

        public Form1()
        {
            InitializeComponent();

            lift = new Lift(
            mainelevator,
            btnf,
            btng,
            btnopen,
            btnclose,
             lifttimer,
             doortimer1,
             doortimer2,
             btnfirst,
             btnground,
             doorleft1,
             doorleft2,
             doorright1,
             doorright2,
             datagridviewlogs,
             btnclear,
             btnexit,
             gfloor,
             ffloor
             );


            doormaxopenwidth = mainelevator.Width;

            datagridviewlogs.ColumnCount = 2;
            datagridviewlogs.Columns[0].Name = "Time";
            datagridviewlogs.Columns[1].Name = "Events";

            datagridviewlogs.Columns[0].Width = 100;
            datagridviewlogs.Columns[1].Width = 203;

            dt.Columns.Add("Time");
            dt.Columns.Add("Events");
        }

        public void logEvents(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(logEvents), message);
            }
            else
            {
                string currentTime = DateTime.Now.ToString("hh:mm:ss");
                dt.Rows.Add(currentTime, message);
                datagridviewlogs.Rows.Add(currentTime, message);

                dbContext.InsertLogsIntoDB(dt);

                datagridviewlogs.FirstDisplayedScrollingRowIndex = datagridviewlogs.RowCount - 1;
            }
        }



        public void btn_f_click(object sender, EventArgs e)
        {
            lift.SetState(new MovingUpStateConcreteClass(this));
            lift.MovingUp();
        }

        public void btn_g_click(object sender, EventArgs e)
        {
            lift.SetState(new MovingDownStateConcreteClass(this));
            lift.MovingDown();
        }

        private void btn_open_click(object sender, EventArgs e)
        {
            lift.SetState(new OpenButtonStateConcreteClass(this));
            lift.OpenButton();
        }

        private void btn_close_click(object sender, EventArgs e)
        {
            lift.SetState(new CloseButtonStateConcreteClass(this)); // Pass current instance
            lift.CloseButton();
        }

        //Timers
        public void lift_timer_tick(object sender, EventArgs e)
        {
            lift.SetState(new LiftTimerStateConcreteClass(this));
            lift.LiftTimer();
        }

        private void door_timer_tick_1(object sender, EventArgs e)
        {
            lift.SetState(new DoorTimer1StateConcreteClass(this));
            lift.DoorTimer1();
        }
        private void door_timer_tick_2(object sender, EventArgs e)
        {
            lift.SetState(new DoorTimer2StateConcreteClass(this));
            lift.DoorTimer2();
        }

        private void btn_ground_click(object sender, EventArgs e)
        {
            lift.SetState(new MovingDownStateConcreteClass(this));
            lift.MovingDown();
        }

        private void btn_first_click(object sender, EventArgs e)
        {
            lift.SetState(new MovingUpStateConcreteClass(this));
            lift.MovingDown();

        }

        public void delete_data_click(object sender, EventArgs e)
        {
            dbContext.truncateLogsTable(datagridviewlogs);
        }

        private void close_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbContext.loadLogsFormDB(dt, datagridviewlogs);

        }
    }
}