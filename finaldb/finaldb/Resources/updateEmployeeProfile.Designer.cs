namespace finaldb.Resources
{
    partial class updateEmployeeProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateEmployeeProfile));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column11 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnicCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imgCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-17, -67);
            this.pictureBox2.MaximumSize = new System.Drawing.Size(1379, 736);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1379, 736);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(216)))), ((int)(((byte)(208)))));
            this.label1.Font = new System.Drawing.Font("Broadway", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(121)))), ((int)(((byte)(98)))));
            this.label1.Location = new System.Drawing.Point(516, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 55);
            this.label1.TabIndex = 12;
            this.label1.Text = "Update Profile";
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
            this.email,
            this.passCol,
            this.pnCol,
            this.imgCol});
            this.dataGridView1.Location = new System.Drawing.Point(90, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(231, 156);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column11
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleGreen;
            this.Column11.DefaultCellStyle = dataGridViewCellStyle2;
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
            // pnCol
            // 
            this.pnCol.DataPropertyName = "PHONENUMBER";
            this.pnCol.HeaderText = "PHONENUMBER";
            this.pnCol.Name = "pnCol";
            // 
            // imgCol
            // 
            this.imgCol.DataPropertyName = "IMAGE";
            this.imgCol.HeaderText = "IMAGE";
            this.imgCol.Name = "imgCol";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(513, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Employee Name";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(516, 214);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(265, 20);
            this.textBox9.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(513, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Employee CNIC";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(516, 285);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 20);
            this.textBox1.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(516, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Employee Email";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(516, 367);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(265, 20);
            this.textBox2.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(516, 428);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "Employee Passsword";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(516, 444);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(265, 20);
            this.textBox3.TabIndex = 56;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(706, 549);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 57;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(513, 493);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Phone No.";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(516, 509);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(265, 20);
            this.textBox4.TabIndex = 59;
            // 
            // updateEmployeeProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 617);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "updateEmployeeProfile";
            this.Text = "updateEmployeeProfile";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewButtonColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnicCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn passCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnCol;
        private System.Windows.Forms.DataGridViewImageColumn imgCol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
    }
}