﻿namespace Elevator1
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
            ClearAll = new Button();
            btn_color1 = new Button();
            btn_colorG = new Button();
            EmergencyAlarm = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            btnG2 = new Button();
            btnG1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)mainElevator).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doorright_G).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doorleft_G).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doorleft1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doorright1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLogs).BeginInit();
            SuspendLayout();
            // 
            // mainElevator
            // 
            mainElevator.BackgroundImage = Properties.Resources.opendoor1;
            mainElevator.BackgroundImageLayout = ImageLayout.Stretch;
            mainElevator.Location = new Point(262, 336);
            mainElevator.Name = "mainElevator";
            mainElevator.Size = new Size(285, 225);
            mainElevator.TabIndex = 0;
            mainElevator.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Tan;
            pictureBox1.BackgroundImage = Properties.Resources.wall;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(615, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 460);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button_up
            // 
            button_up.BackgroundImage = Properties.Resources.images__1_2;
            button_up.BackgroundImageLayout = ImageLayout.Stretch;
            button_up.ForeColor = SystemColors.AppWorkspace;
            button_up.Location = new Point(659, 247);
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
            btn_Close.Location = new Point(701, 395);
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
            btn_open.Location = new Point(630, 395);
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
            button_g.Location = new Point(659, 308);
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
            doorright_G.Location = new Point(404, 323);
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
            doorleft_G.Location = new Point(262, 323);
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
            doorleft1.Location = new Point(262, 27);
            doorleft1.Name = "doorleft1";
            doorleft1.Size = new Size(149, 254);
            doorleft1.TabIndex = 9;
            doorleft1.TabStop = false;
            // 
            // doorright1
            // 
            doorright1.BackColor = SystemColors.ControlDarkDark;
            doorright1.BackgroundImage = Properties.Resources.leftdoor13;
            doorright1.BackgroundImageLayout = ImageLayout.Stretch;
            doorright1.Location = new Point(404, 27);
            doorright1.Name = "doorright1";
            doorright1.Size = new Size(143, 254);
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
            dataGridViewLogs.Location = new Point(807, 123);
            dataGridViewLogs.Name = "dataGridViewLogs";
            dataGridViewLogs.RowHeadersWidth = 51;
            dataGridViewLogs.Size = new Size(323, 353);
            dataGridViewLogs.TabIndex = 11;
            // 
            // ClearAll
            // 
            ClearAll.BackColor = SystemColors.MenuHighlight;
            ClearAll.Location = new Point(978, 93);
            ClearAll.Name = "ClearAll";
            ClearAll.Size = new Size(77, 29);
            ClearAll.TabIndex = 12;
            ClearAll.Text = "Clear All";
            ClearAll.UseVisualStyleBackColor = false;
            ClearAll.Click += button1_Click_1;
            // 
            // btn_color1
            // 
            btn_color1.BackColor = SystemColors.ActiveCaptionText;
            btn_color1.ForeColor = SystemColors.ActiveCaptionText;
            btn_color1.Location = new Point(389, 3);
            btn_color1.Name = "btn_color1";
            btn_color1.Size = new Size(37, 18);
            btn_color1.TabIndex = 14;
            btn_color1.UseVisualStyleBackColor = false;
            // 
            // btn_colorG
            // 
            btn_colorG.BackColor = SystemColors.ActiveCaptionText;
            btn_colorG.Location = new Point(389, 297);
            btn_colorG.Name = "btn_colorG";
            btn_colorG.Size = new Size(37, 20);
            btn_colorG.TabIndex = 15;
            btn_colorG.UseVisualStyleBackColor = false;
            // 
            // EmergencyAlarm
            // 
            EmergencyAlarm.BackgroundImage = Properties.Resources.alarm;
            EmergencyAlarm.BackgroundImageLayout = ImageLayout.Stretch;
            EmergencyAlarm.Location = new Point(676, 461);
            EmergencyAlarm.Name = "EmergencyAlarm";
            EmergencyAlarm.Size = new Size(31, 29);
            EmergencyAlarm.TabIndex = 16;
            EmergencyAlarm.UseVisualStyleBackColor = true;
            EmergencyAlarm.Click += EmergencyAlarm_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(1061, 93);
            button1.Name = "button1";
            button1.Size = new Size(69, 29);
            button1.TabIndex = 18;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btn_Exit_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(807, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 27);
            textBox1.TabIndex = 19;
            textBox1.Text = "Log History of Elevator";
            // 
            // btnG2
            // 
            btnG2.BackColor = Color.ForestGreen;
            btnG2.ForeColor = SystemColors.ActiveCaptionText;
            btnG2.Location = new Point(553, 175);
            btnG2.Name = "btnG2";
            btnG2.Size = new Size(31, 27);
            btnG2.TabIndex = 20;
            btnG2.Text = "1";
            btnG2.UseVisualStyleBackColor = false;
            // 
            // btnG1
            // 
            btnG1.BackColor = Color.ForestGreen;
            btnG1.ForeColor = SystemColors.ActiveCaptionText;
            btnG1.Location = new Point(553, 403);
            btnG1.Name = "btnG1";
            btnG1.Size = new Size(31, 27);
            btnG1.TabIndex = 21;
            btnG1.Text = "1";
            btnG1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.download21;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(553, 144);
            button2.Name = "button2";
            button2.Size = new Size(31, 29);
            button2.TabIndex = 22;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.download11;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(553, 368);
            button3.Name = "button3";
            button3.Size = new Size(31, 29);
            button3.TabIndex = 23;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.images1;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Location = new Point(630, 90);
            button4.Name = "button4";
            button4.Size = new Size(115, 136);
            button4.TabIndex = 24;
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.images__2_2;
            ClientSize = new Size(1142, 560);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnG1);
            Controls.Add(btnG2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(EmergencyAlarm);
            Controls.Add(btn_colorG);
            Controls.Add(btn_color1);
            Controls.Add(ClearAll);
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
            ResumeLayout(false);
            PerformLayout();
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
        private Button ClearAll;
        private Button btn_color1;
        private Button btn_colorG;
        private Button EmergencyAlarm;
        private Button button1;
        private TextBox textBox1;
        private Button btnG2;
        private Button btnG1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
