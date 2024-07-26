namespace finaldb.Resources
{
    partial class updatePassenger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updatePassenger));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column11 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnicCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-27, -75);
            this.pictureBox2.MaximumSize = new System.Drawing.Size(1379, 736);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1379, 736);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-8, -5);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(1379, 736);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1379, 736);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(216)))), ((int)(((byte)(208)))));
            this.label1.Font = new System.Drawing.Font("Broadway", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(121)))), ((int)(((byte)(98)))));
            this.label1.Location = new System.Drawing.Point(310, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(666, 72);
            this.label1.TabIndex = 14;
            this.label1.Text = "Update Passenger";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.nameCol,
            this.cnicCol,
            this.pnCol,
            this.email,
            this.passCol});
            this.dataGridView1.Location = new System.Drawing.Point(109, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(182, 384);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column11
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PaleGreen;
            this.Column11.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column11.HeaderText = "UPDATE";
            this.Column11.Name = "Column11";
            this.Column11.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column11.Text = "UPDATE";
            this.Column11.UseColumnTextForButtonValue = true;
            // 
            // nameCol
            // 
            this.nameCol.DataPropertyName = "NAME";
            this.nameCol.HeaderText = "NAME";
            this.nameCol.Name = "nameCol";
            // 
            // cnicCol
            // 
            this.cnicCol.DataPropertyName = "CNIC";
            this.cnicCol.HeaderText = "CNIC";
            this.cnicCol.Name = "cnicCol";
            // 
            // pnCol
            // 
            this.pnCol.DataPropertyName = "PHONENUMBER";
            this.pnCol.HeaderText = "PHONENUMBER";
            this.pnCol.Name = "pnCol";
            // 
            // email
            // 
            this.email.DataPropertyName = "EMAIL";
            this.email.HeaderText = "EMAIL";
            this.email.Name = "email";
            // 
            // passCol
            // 
            this.passCol.DataPropertyName = "PASSWORD";
            this.passCol.HeaderText = "PASSWORD";
            this.passCol.Name = "passCol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(514, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Passenger Name";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.Location = new System.Drawing.Point(517, 215);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 33);
            this.textBox1.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(517, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Passenger CNIC";
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox2.Location = new System.Drawing.Point(517, 284);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(220, 33);
            this.textBox2.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(517, 347);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "Passenger Phone_no";
            // 
            // textBox3
            // 
            this.textBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox3.Location = new System.Drawing.Point(517, 363);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(220, 33);
            this.textBox3.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(517, 409);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Passenger Email";
            // 
            // textBox5
            // 
            this.textBox5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox5.Location = new System.Drawing.Point(517, 425);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(220, 33);
            this.textBox5.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(517, 473);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 57;
            this.label9.Text = "Password";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // textBox6
            // 
            this.textBox6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox6.Location = new System.Drawing.Point(517, 489);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(220, 33);
            this.textBox6.TabIndex = 58;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(662, 552);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 59;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // updatePassenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 617);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "updatePassenger";
            this.Text = "updatePassenger";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewButtonColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnicCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn passCol;
    }
}