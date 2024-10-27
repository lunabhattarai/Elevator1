namespace Elevator1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            mainElevator = new PictureBox();
            pictureBox1 = new PictureBox();
            button_up = new Button();
            btn_Close = new Button();
            btn_open = new Button();
            button_g = new Button();
            lifttimer = new System.Windows.Forms.Timer(components);
            doorright_G = new PictureBox();
            doorleft_G = new PictureBox();
            doorleft1 = new PictureBox();
            doorright1 = new PictureBox();
            doorTimer = new System.Windows.Forms.Timer(components);
            dataGridViewLogs = new DataGridView();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            EmergencyAlarm = new Button();
            liftTimerDown = new System.Windows.Forms.Timer(components);
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)mainElevator).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doorright_G).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doorleft_G).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doorleft1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doorright1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLogs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // mainElevator
            // 
            mainElevator.BackgroundImage = Properties.Resources.opendoor1;
            mainElevator.BackgroundImageLayout = ImageLayout.Stretch;
            mainElevator.Location = new Point(262, 318);
            mainElevator.Name = "mainElevator";
            mainElevator.Size = new Size(285, 238);
            mainElevator.TabIndex = 0;
            mainElevator.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Tan;
            pictureBox1.BackgroundImage = Properties.Resources.wall;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(616, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 491);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button_up
            // 
            button_up.BackgroundImage = Properties.Resources.images__1_2;
            button_up.BackgroundImageLayout = ImageLayout.Stretch;
            button_up.Location = new Point(659, 283);
            button_up.Name = "button_up";
            button_up.Size = new Size(48, 44);
            button_up.TabIndex = 2;
            button_up.UseVisualStyleBackColor = true;
            button_up.Click += button1_Click;
            // 
            // btn_Close
            // 
            btn_Close.BackgroundImage = Properties.Resources.download1;
            btn_Close.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Close.Location = new Point(701, 424);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(44, 43);
            btn_Close.TabIndex = 3;
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // btn_open
            // 
            btn_open.BackgroundImage = Properties.Resources.download;
            btn_open.BackgroundImageLayout = ImageLayout.Stretch;
            btn_open.Location = new Point(630, 424);
            btn_open.Name = "btn_open";
            btn_open.Size = new Size(49, 43);
            btn_open.TabIndex = 4;
            btn_open.UseVisualStyleBackColor = true;
            btn_open.Click += btn_Open_Click;
            // 
            // button_g
            // 
            button_g.BackgroundImage = Properties.Resources.images__2_;
            button_g.BackgroundImageLayout = ImageLayout.Stretch;
            button_g.Location = new Point(659, 347);
            button_g.Name = "button_g";
            button_g.Size = new Size(48, 42);
            button_g.TabIndex = 5;
            button_g.UseVisualStyleBackColor = true;
            button_g.Click += button_g_Click;
            // 
            // lifttimer
            // 
            lifttimer.Interval = 50;
            lifttimer.Tick += lifttimer_Tick;
            // 
            // doorright_G
            // 
            doorright_G.BackColor = SystemColors.ActiveBorder;
            doorright_G.BackgroundImage = Properties.Resources.leftdoor12;
            doorright_G.BackgroundImageLayout = ImageLayout.Stretch;
            doorright_G.Location = new Point(404, 318);
            doorright_G.Name = "doorright_G";
            doorright_G.Size = new Size(143, 238);
            doorright_G.TabIndex = 7;
            doorright_G.TabStop = false;
            // 
            // doorleft_G
            // 
            doorleft_G.BackColor = SystemColors.ControlDarkDark;
            doorleft_G.BackgroundImage = Properties.Resources.leftdoor3;
            doorleft_G.BackgroundImageLayout = ImageLayout.Stretch;
            doorleft_G.Location = new Point(262, 318);
            doorleft_G.Name = "doorleft_G";
            doorleft_G.Size = new Size(149, 238);
            doorleft_G.TabIndex = 8;
            doorleft_G.TabStop = false;
            doorleft_G.Click += doorleft_G_Click;
            // 
            // doorleft1
            // 
            doorleft1.BackColor = SystemColors.AppWorkspace;
            doorleft1.BackgroundImage = Properties.Resources.leftdoor4;
            doorleft1.BackgroundImageLayout = ImageLayout.Stretch;
            doorleft1.Location = new Point(262, 40);
            doorleft1.Name = "doorleft1";
            doorleft1.Size = new Size(149, 237);
            doorleft1.TabIndex = 9;
            doorleft1.TabStop = false;
            // 
            // doorright1
            // 
            doorright1.BackColor = SystemColors.ControlDarkDark;
            doorright1.BackgroundImage = Properties.Resources.leftdoor13;
            doorright1.BackgroundImageLayout = ImageLayout.Stretch;
            doorright1.Location = new Point(404, 40);
            doorright1.Name = "doorright1";
            doorright1.Size = new Size(143, 237);
            doorright1.TabIndex = 10;
            doorright1.TabStop = false;
            // 
            // doorTimer
            // 
            doorTimer.Tick += doorTimer_Tick;
            // 
            // dataGridViewLogs
            // 
            dataGridViewLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLogs.BackgroundColor = Color.Tan;
            dataGridViewLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLogs.Location = new Point(797, 28);
            dataGridViewLogs.Name = "dataGridViewLogs";
            dataGridViewLogs.RowHeadersWidth = 51;
            dataGridViewLogs.Size = new Size(300, 299);
            dataGridViewLogs.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Location = new Point(965, 369);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 12;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(389, 5);
            button3.Name = "button3";
            button3.Size = new Size(37, 29);
            button3.TabIndex = 14;
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(389, 283);
            button4.Name = "button4";
            button4.Size = new Size(37, 29);
            button4.TabIndex = 15;
            button4.UseVisualStyleBackColor = false;
            // 
            // EmergencyAlarm
            // 
            EmergencyAlarm.BackgroundImage = Properties.Resources.alarm;
            EmergencyAlarm.BackgroundImageLayout = ImageLayout.Stretch;
            EmergencyAlarm.Location = new Point(676, 496);
            EmergencyAlarm.Name = "EmergencyAlarm";
            EmergencyAlarm.Size = new Size(31, 29);
            EmergencyAlarm.TabIndex = 16;
            EmergencyAlarm.UseVisualStyleBackColor = true;
            EmergencyAlarm.Click += EmergencyAlarm_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.green_led_traffic_signal_500x5003;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(630, 94);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(115, 159);
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 550);
            Controls.Add(pictureBox2);
            Controls.Add(EmergencyAlarm);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(dataGridViewLogs);
            Controls.Add(doorright1);
            Controls.Add(doorleft1);
            Controls.Add(doorleft_G);
            Controls.Add(doorright_G);
            Controls.Add(button_g);
            Controls.Add(btn_open);
            Controls.Add(btn_Close);
            Controls.Add(button_up);
            Controls.Add(pictureBox1);
            Controls.Add(mainElevator);
            Name = "Form1";
            Load += From1_Load;
            ((System.ComponentModel.ISupportInitialize)mainElevator).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)doorright_G).EndInit();
            ((System.ComponentModel.ISupportInitialize)doorleft_G).EndInit();
            ((System.ComponentModel.ISupportInitialize)doorleft1).EndInit();
            ((System.ComponentModel.ISupportInitialize)doorright1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLogs).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox mainElevator;
        private PictureBox pictureBox1;
        private Button button_up;
        private Button btn_Close;
        private Button btn_open;
        private Button button_g;
        private System.Windows.Forms.Timer lifttimer;
        private PictureBox doorright_G;
        private PictureBox doorleft_G;
        private PictureBox doorleft1;
        private PictureBox doorright1;
        private System.Windows.Forms.Timer doorTimer;
        private DataGridView dataGridViewLogs;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button EmergencyAlarm;
        private System.Windows.Forms.Timer liftTimerDown;
        private PictureBox pictureBox2;
    }
}
