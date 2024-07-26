using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finaldb
{
    public partial class assigntask : Form
    {
       
        public assigntask()
        {
            InitializeComponent();
        }

        private void Assign_Click(object sender, EventArgs e)
        {
            string connectionString = @"DATA SOURCE=localhost:1521/XE;USER ID=system;PASSWORD=mala";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string empId = textBox2.Text;
                    int amount= int.Parse(textBox1.Text);

                    string taskDescription = textBox3.Text;
                    DateTime deadline = dateTimePicker1.Value;
                    DateTime today = DateTime.Today;
                    if (deadline <= today)
                    {
                        MessageBox.Show("Deadline must be greater than today's date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string sql = "INSERT INTO ADMIN.TASK(EMPLOYEE_ID, AMOUNT, TASK_DESCRIPTION, DEADLINE) " +
                                 "VALUES (:empId, :amount, :taskDescription, :deadline)";

                    using (OracleCommand command = new OracleCommand(sql, connection))
                    {
                        command.Parameters.Add(":empId", OracleDbType.Varchar2).Value = empId;
                        command.Parameters.Add(":amount", OracleDbType.Varchar2).Value = amount;
                        command.Parameters.Add(":taskDescription", OracleDbType.Varchar2).Value = taskDescription;
                        command.Parameters.Add(":deadline", OracleDbType.Date).Value = deadline;

                        int rowsInserted = command.ExecuteNonQuery();
                        MessageBox.Show($"{rowsInserted} task(s) assigned successfully.", "Assignment Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    }
