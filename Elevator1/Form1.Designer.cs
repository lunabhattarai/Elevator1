namespace Elevator1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            gfloor = new PictureBox();
            ffloor = new PictureBox();
            pictureBox3 = new PictureBox();
            doorleft2 = new PictureBox();
            doorleft1 = new PictureBox();
            doorright1 = new PictureBox();
            doorright2 = new PictureBox();
            mainelevator = new PictureBox();
            btnf = new Button();
            btng = new Button();
            btnopen = new Button();
            btnclose = new Button();
            btnfirst = new Button();
            btnground = new Button();
            lifttimer = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            doortimer1 = new System.Windows.Forms.Timer(components);
            doortimer2 = new System.Windows.Forms.Timer(components);
            btnclear = new Button();
            btnexit = new Button();
            datagridviewlogs = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gfloor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ffloor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doorleft2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doorleft1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doorright1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doorright2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mainelevator).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datagridviewlogs).BeginInit();
            SuspendLayout();
            // 
            // gfloor
            // 
            gfloor.Location = new Point(286, 402);
            gfloor.Name = "gfloor";
            gfloor.Size = new Size(331, 273);
            gfloor.TabIndex = 0;
            gfloor.TabStop = false;
            // 
            // ffloor
            // 
            ffloor.Location = new Point(286, 12);
            ffloor.Name = "ffloor";
            ffloor.Size = new Size(330, 273);
            ffloor.TabIndex = 1;
            ffloor.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(781, -1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(206, 701);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // doorleft2
            // 
            doorleft2.BackgroundImage = (Image)resources.GetObject("doorleft2.BackgroundImage");
            doorleft2.BackgroundImageLayout = ImageLayout.Stretch;
            doorleft2.Location = new Point(286, 402);
            doorleft2.Name = "doorleft2";
            doorleft2.Size = new Size(165, 273);
            doorleft2.TabIndex = 3;
            doorleft2.TabStop = false;
            // 
            // doorleft1
            // 
            doorleft1.BackgroundImage = (Image)resources.GetObject("doorleft1.BackgroundImage");
            doorleft1.BackgroundImageLayout = ImageLayout.Stretch;
            doorleft1.Location = new Point(286, 12);
            doorleft1.Name = "doorleft1";
            doorleft1.Size = new Size(165, 273);
            doorleft1.TabIndex = 4;
            doorleft1.TabStop = false;
            // 
            // doorright1
            // 
            doorright1.BackgroundImage = (Image)resources.GetObject("doorright1.BackgroundImage");
            doorright1.BackgroundImageLayout = ImageLayout.Stretch;
            doorright1.Location = new Point(451, 12);
            doorright1.Name = "doorright1";
            doorright1.Size = new Size(165, 273);
            doorright1.TabIndex = 5;
            doorright1.TabStop = false;
            // 
            // doorright2
            // 
            doorright2.BackgroundImage = (Image)resources.GetObject("doorright2.BackgroundImage");
            doorright2.BackgroundImageLayout = ImageLayout.Stretch;
            doorright2.Location = new Point(451, 402);
            doorright2.Name = "doorright2";
            doorright2.Size = new Size(165, 273);
            doorright2.TabIndex = 6;
            doorright2.TabStop = false;
            // 
            // mainelevator
            // 
            mainelevator.BackgroundImage = (Image)resources.GetObject("mainelevator.BackgroundImage");
            mainelevator.BackgroundImageLayout = ImageLayout.Stretch;
            mainelevator.Location = new Point(286, 402);
            mainelevator.Name = "mainelevator";
            mainelevator.Size = new Size(331, 273);
            mainelevator.TabIndex = 7;
            mainelevator.TabStop = false;
            // 
            // btnf
            // 
            btnf.Location = new Point(796, 291);
            btnf.Name = "btnf";
            btnf.Size = new Size(89, 88);
            btnf.TabIndex = 8;
            btnf.Text = "button1";
            btnf.UseVisualStyleBackColor = true;
            // 
            // btng
            // 
            btng.Location = new Point(891, 291);
            btng.Name = "btng";
            btng.Size = new Size(89, 88);
            btng.TabIndex = 9;
            btng.Text = "button2";
            btng.UseVisualStyleBackColor = true;
            // 
            // btnopen
            // 
            btnopen.Location = new Point(791, 420);
            btnopen.Name = "btnopen";
            btnopen.Size = new Size(89, 88);
            btnopen.TabIndex = 10;
            btnopen.Text = "button3";
            btnopen.UseVisualStyleBackColor = true;
            // 
            // btnclose
            // 
            btnclose.Location = new Point(891, 420);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(84, 88);
            btnclose.TabIndex = 11;
            btnclose.Text = "button4";
            btnclose.UseVisualStyleBackColor = true;
            // 
            // btnfirst
            // 
            btnfirst.Location = new Point(643, 261);
            btnfirst.Name = "btnfirst";
            btnfirst.Size = new Size(94, 29);
            btnfirst.TabIndex = 12;
            btnfirst.Text = "button1";
            btnfirst.UseVisualStyleBackColor = true;
            // 
            // btnground
            // 
            btnground.Location = new Point(649, 329);
            btnground.Name = "btnground";
            btnground.Size = new Size(94, 29);
            btnground.TabIndex = 13;
            btnground.Text = "button2";
            btnground.UseVisualStyleBackColor = true;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(1084, 12);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(94, 29);
            btnclear.TabIndex = 14;
            btnclear.Text = "button1";
            btnclear.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            btnexit.BackgroundImageLayout = ImageLayout.None;
            btnexit.Location = new Point(1194, 12);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(94, 29);
            btnexit.TabIndex = 15;
            btnexit.Text = "button2";
            btnexit.UseVisualStyleBackColor = true;
            // 
            // datagridviewlogs
            // 
            datagridviewlogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridviewlogs.Location = new Point(1034, 59);
            datagridviewlogs.Name = "datagridviewlogs";
            datagridviewlogs.RowHeadersWidth = 51;
            datagridviewlogs.Size = new Size(346, 616);
            datagridviewlogs.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1377, 687);
            Controls.Add(datagridviewlogs);
            Controls.Add(btnexit);
            Controls.Add(btnclear);
            Controls.Add(btnground);
            Controls.Add(btnfirst);
            Controls.Add(btnclose);
            Controls.Add(btnopen);
            Controls.Add(btng);
            Controls.Add(btnf);
            Controls.Add(doorright2);
            Controls.Add(doorright1);
            Controls.Add(doorleft1);
            Controls.Add(doorleft2);
            Controls.Add(pictureBox3);
            Controls.Add(ffloor);
            Controls.Add(mainelevator);
            Controls.Add(gfloor);
            Name = "Form1";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)gfloor).EndInit();
            ((System.ComponentModel.ISupportInitialize)ffloor).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)doorleft2).EndInit();
            ((System.ComponentModel.ISupportInitialize)doorleft1).EndInit();
            ((System.ComponentModel.ISupportInitialize)doorright1).EndInit();
            ((System.ComponentModel.ISupportInitialize)doorright2).EndInit();
            ((System.ComponentModel.ISupportInitialize)mainelevator).EndInit();
            ((System.ComponentModel.ISupportInitialize)datagridviewlogs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox gfloor;
        private PictureBox ffloor;
        private PictureBox pictureBox3;
        private PictureBox doorleft2;
        private PictureBox doorleft1;
        private PictureBox doorright1;
        private PictureBox doorright2;
        private PictureBox mainelevator;
        private Button btnf;
        private Button btng;
        private Button btnopen;
        private Button btnclose;
        private Button btnfirst;
        private Button btnground;
        private System.Windows.Forms.Timer lifttimer;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer doortimer1;
        private System.Windows.Forms.Timer doortimer2;
        private Button btnclear;
        private Button btnexit;
        private DataGridView datagridviewlogs;
    }
}