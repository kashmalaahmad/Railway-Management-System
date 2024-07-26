namespace finaldb
{
    partial class updateEmployee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateEmployee));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column11 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dojCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnicCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imgCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(216)))), ((int)(((byte)(208)))));
            this.label1.Font = new System.Drawing.Font("Broadway", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(121)))), ((int)(((byte)(98)))));
            this.label1.Location = new System.Drawing.Point(302, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(655, 72);
            this.label1.TabIndex = 13;
            this.label1.Text = "Update Employee";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.IdCol,
            this.nameCol,
            this.shiftCol,
            this.roleCol,
            this.salCol,
            this.dojCol,
            this.cnicCol,
            this.email,
            this.passCol,
            this.pnCol,
            this.imgCol});
            this.dataGridView1.Location = new System.Drawing.Point(102, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 384);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column11
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PaleGreen;
            this.Column11.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column11.HeaderText = "UPDATE";
            this.Column11.Name = "Column11";
            this.Column11.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column11.Text = "UPDATE";
            this.Column11.UseColumnTextForButtonValue = true;
            // 
            // IdCol
            // 
            this.IdCol.DataPropertyName = "EMPLOYEEID";
            this.IdCol.HeaderText = "EMPLOYEEID";
            this.IdCol.Name = "IdCol";
            // 
            // nameCol
            // 
            this.nameCol.DataPropertyName = "NAME";
            this.nameCol.HeaderText = "NAME";
            this.nameCol.Name = "nameCol";
            // 
            // shiftCol
            // 
            this.shiftCol.DataPropertyName = "SHIFT";
            this.shiftCol.HeaderText = "SHIFT";
            this.shiftCol.Name = "shiftCol";
            // 
            // roleCol
            // 
            this.roleCol.DataPropertyName = "ROLE";
            this.roleCol.HeaderText = "ROLE";
            this.roleCol.Name = "roleCol";
            // 
            // salCol
            // 
            this.salCol.DataPropertyName = "SALARY";
            this.salCol.HeaderText = "SALARY";
            this.salCol.Name = "salCol";
            // 
            // dojCol
            // 
            this.dojCol.DataPropertyName = "DATEOFJOINING";
            this.dojCol.HeaderText = "DATEOFJOINING";
            this.dojCol.Name = "dojCol";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(744, 209);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(741, 434);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(268, 20);
            this.textBox2.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(744, 512);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(265, 20);
            this.textBox3.TabIndex = 17;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(744, 473);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(265, 20);
            this.textBox4.TabIndex = 18;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(744, 359);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(265, 20);
            this.textBox5.TabIndex = 19;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(744, 395);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(265, 20);
            this.textBox6.TabIndex = 20;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(744, 318);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(265, 20);
            this.textBox7.TabIndex = 21;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(744, 282);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(265, 20);
            this.textBox8.TabIndex = 22;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(744, 244);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(265, 20);
            this.textBox9.TabIndex = 23;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(741, 193);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(744, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Employee Date of Joining";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(747, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Employee Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(747, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Employee Role";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(745, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = " Employee Shift";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(745, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Employee Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(744, 418);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Employee CNIC";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(745, 457);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Employee EMAIL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(747, 496);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "Employee Passsword";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(882, 556);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 52;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1386, 678);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // updateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 617);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "updateEmployee";
            this.Text = "updateEmployee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn salCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dojCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnicCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn passCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnCol;
        private System.Windows.Forms.DataGridViewImageColumn imgCol;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}