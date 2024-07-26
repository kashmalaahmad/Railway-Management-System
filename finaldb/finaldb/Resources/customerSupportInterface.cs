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

namespace finaldb.Resources
{
    public partial class customerSupportInterface : Form
    {
        string ID;
        public customerSupportInterface(string id)
        {
            InitializeComponent();
            ID = id;
            CheckTask();
        }
        private void CheckTask()
        {
            string connectionString = @"DATA SOURCE=localhost:1521/XE;USER ID=system;PASSWORD=mala";
            string sqlQuery = "SELECT TASK_ID FROM ADMIN.TASK WHERE EMPLOYEE_ID = '" + ID + "' AND STATUS = 'Unchecked'";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand(sqlQuery, connection))
                    {
                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string taskID = reader.GetString(0);
                                    MarkTaskAsChecked(taskID);
                                }
                                MessageBox.Show("You have new tasks.", "Information", MessageBoxButtons.OK);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MarkTaskAsChecked(string taskID)
        {
            // Connect to database
            string connectionString = @"DATA SOURCE=localhost:1521/XE;USER ID=system;PASSWORD=mala";
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string sqlQuery = "UPDATE ADMIN.TASK SET STATUS = 'Checked' WHERE TASK_ID = :taskID";

                    using (OracleCommand command = new OracleCommand(sqlQuery, connection))
                    {
                        command.Parameters.Add(":taskID", OracleDbType.Varchar2).Value = taskID;

                        int rowsUpdated = command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewFeedback obj = new viewFeedback();
            obj.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            updateEmployeeProfile obj = new updateEmployeeProfile(ID);
            obj.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            viewEmployee obj = new viewEmployee(ID);
            obj.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            viewTask obj = new viewTask(ID);
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            viewSalary obj = new viewSalary(ID);
             obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //handleCustomerAffairs obj = new handleCustomerAffairs();
            //obj.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
