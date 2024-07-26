namespace finaldb
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.entityConnection1 = new System.Data.Entity.Core.EntityClient.EntityConnection();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(216)))), ((int)(((byte)(208)))));
            this.label1.Font = new System.Drawing.Font("Broadway", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(121)))), ((int)(((byte)(98)))));
            this.label1.Location = new System.Drawing.Point(543, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 55);
            this.label1.TabIndex = 11;
            this.label1.Text = "Admin";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(121)))), ((int)(((byte)(98)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(253, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 53);
            this.button1.TabIndex = 12;
            this.button1.Text = "View Profile";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(121)))), ((int)(((byte)(98)))));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(852, 214);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 53);
            this.button4.TabIndex = 14;
            this.button4.Text = "Revenue";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(121)))), ((int)(((byte)(98)))));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(253, 511);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 53);
            this.button5.TabIndex = 15;
            this.button5.Text = "View Trains";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(121)))), ((int)(((byte)(98)))));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(450, 511);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(131, 53);
            this.button6.TabIndex = 16;
            this.button6.Text = "Assign Tasks";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(121)))), ((int)(((byte)(98)))));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(648, 511);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(129, 53);
            this.button7.TabIndex = 17;
            this.button7.Text = "View Feedback";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(450, 211);
            this.panel1.MaximumSize = new System.Drawing.Size(133, 246);
            this.panel1.MinimumSize = new System.Drawing.Size(133, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 56);
            this.panel1.TabIndex = 19;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(121)))), ((int)(((byte)(98)))));
            this.button12.Dock = System.Windows.Forms.DockStyle.Top;
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(0, 198);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(133, 46);
            this.button12.TabIndex = 16;
            this.button12.Text = "Delete Employees";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(121)))), ((int)(((byte)(98)))));
            this.button11.Dock = System.Windows.Forms.DockStyle.Top;
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(0, 155);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(133, 43);
            this.button11.TabIndex = 15;
            this.button11.Text = "Update Employees";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(121)))), ((int)(((byte)(98)))));
            this.button10.Dock = System.Windows.Forms.DockStyle.Top;
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(0, 102);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(133, 53);
            this.button10.TabIndex = 14;
            this.button10.Text = "Add Employees";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(121)))), ((int)(((byte)(98)))));
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(0, 55);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(133, 47);
            this.button9.TabIndex = 13;
            this.button9.Text = "View Employees";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button16);
            this.panel2.Controls.Add(this.button15);
            this.panel2.Controls.Add(this.button14);
            this.panel2.Controls.Add(this.button13);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panel2.Location = new System.Drawing.Point(645, 211);
            this.panel2.MaximumSize = new System.Drawing.Size(127, 255);
            this.panel2.MinimumSize = new System.Drawing.Size(127, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(127, 56);
            this.panel2.TabIndex = 20;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(121)))), ((int)(((byte)(98)))));
            this.button16.ForeColor = System.Drawing.Color.White;
            this.button16.Location = new System.Drawing.Point(0, 198);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(125, 53);
            this.button16.TabIndex = 17;
            this.button16.Text = "Delete Train Schedules";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(121)))), ((int)(((byte)(98)))));
            this.button15.ForeColor = System.Drawing.Color.White;
            this.button15.Location = new System.Drawing.Point(0, 155);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(125, 53);
            this.button15.TabIndex = 16;
            this.button15.Text = "Update Train Schedules";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(121)))), ((int)(((byte)(98)))));
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.Location = new System.Drawing.Point(0, 102);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(125, 53);
            this.button14.TabIndex = 15;
            this.button14.Text = "Add Trains Scedule";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(121)))), ((int)(((byte)(98)))));
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Location = new System.Drawing.Point(0, 55);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(125, 53);
            this.button13.TabIndex = 14;
            this.button13.Text = "View Trains Schedules";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 15;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(121)))), ((int)(((byte)(98)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::finaldb.Properties.Resources.icons8_expand_arrow_20;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 56);
            this.button3.TabIndex = 13;
            this.button3.Text = "Manage Train Schedules";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(121)))), ((int)(((byte)(98)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::finaldb.Properties.Resources.icons8_expand_arrow_20;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 55);
            this.button2.TabIndex = 12;
            this.button2.Text = "Manage Employees";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-8, -5);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(1379, 736);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1379, 736);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 617);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Timer timer2;
        private System.Data.Entity.Core.EntityClient.EntityConnection entityConnection1;
    }
}