namespace finaldb
{
    partial class updateSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateSchedule));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Col1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(216)))), ((int)(((byte)(208)))));
            this.label1.Font = new System.Drawing.Font("Broadway", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(121)))), ((int)(((byte)(98)))));
            this.label1.Location = new System.Drawing.Point(397, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(633, 72);
            this.label1.TabIndex = 13;
            this.label1.Text = "Update Schedule";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col1,
            this.Col2,
            this.Col3,
            this.Col4,
            this.Col5,
            this.Col6,
            this.Col7,
            this.Col8});
            this.dataGridView1.Location = new System.Drawing.Point(97, 219);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(501, 349);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Col1
            // 
            this.Col1.DataPropertyName = "UPDATE";
            this.Col1.HeaderText = "UPDATE";
            this.Col1.Name = "Col1";
            this.Col1.Text = "UPDATE";
            // 
            // Col2
            // 
            this.Col2.DataPropertyName = "SCHEDULEID";
            this.Col2.HeaderText = "SCHEDULEID";
            this.Col2.Name = "Col2";
            // 
            // Col3
            // 
            this.Col3.DataPropertyName = "ARRIVALTIME";
            this.Col3.HeaderText = "ARRIVALTIME";
            this.Col3.Name = "Col3";
            // 
            // Col4
            // 
            this.Col4.DataPropertyName = "DEPARTURETIME";
            this.Col4.HeaderText = "DEPARTURETIME";
            this.Col4.Name = "Col4";
            // 
            // Col5
            // 
            this.Col5.DataPropertyName = "ROUTE";
            this.Col5.HeaderText = "ROUTE";
            this.Col5.Name = "Col5";
            // 
            // Col6
            // 
            this.Col6.DataPropertyName = "STATUS";
            this.Col6.HeaderText = "STATUS";
            this.Col6.Name = "Col6";
            // 
            // Col7
            // 
            this.Col7.DataPropertyName = "FARE";
            this.Col7.HeaderText = "FARE";
            this.Col7.Name = "Col7";
            // 
            // Col8
            // 
            this.Col8.DataPropertyName = "TRAINID";
            this.Col8.HeaderText = "TRAINID";
            this.Col8.Name = "Col8";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1342, 656);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox4
            // 
            this.textBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox4.Location = new System.Drawing.Point(760, 255);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(220, 33);
            this.textBox4.TabIndex = 43;
            // 
            // textBox5
            // 
            this.textBox5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox5.Location = new System.Drawing.Point(760, 549);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(220, 33);
            this.textBox5.TabIndex = 58;
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.Location = new System.Drawing.Point(760, 492);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 33);
            this.textBox1.TabIndex = 59;
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox2.Location = new System.Drawing.Point(760, 435);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(220, 33);
            this.textBox2.TabIndex = 60;
            // 
            // textBox3
            // 
            this.textBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox3.Location = new System.Drawing.Point(760, 387);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(220, 33);
            this.textBox3.TabIndex = 61;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(905, 604);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 62;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(760, 293);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Arrival Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(760, 423);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(760, 371);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 65;
            this.label4.Text = " Route";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(760, 332);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 66;
            this.label5.Text = "Departure Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(760, 239);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 67;
            this.label6.Text = "Schedule Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(760, 476);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 68;
            this.label7.Text = "Fare";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(760, 533);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 69;
            this.label8.Text = "Train Id";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1113, 251);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(155, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 70;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1193, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 71;
            this.button2.Text = "UPLOAD";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker3.Location = new System.Drawing.Point(760, 348);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.ShowUpDown = true;
            this.dateTimePicker3.Size = new System.Drawing.Size(220, 20);
            this.dateTimePicker3.TabIndex = 72;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(760, 309);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(220, 20);
            this.dateTimePicker1.TabIndex = 73;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // updateSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 617);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "updateSchedule";
            this.Text = "updateSchedule";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewButtonColumn Col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col8;
    }
}