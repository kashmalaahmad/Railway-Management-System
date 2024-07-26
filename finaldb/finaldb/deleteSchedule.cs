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
    public partial class deleteSchedule : Form
    {
        public deleteSchedule()
        {
            InitializeComponent();
            FILLdgv();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string ID = textBox2.Text;

            if (string.IsNullOrEmpty(ID))
            {
                MessageBox.Show("Please enter the Schedule ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete this employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DeleteEmployee(ID);
            }
        }

        private void DeleteEmployee(string employeeId)
        {
            string connectionString = @"DATA SOURCE=localhost:1521/XE;USER ID=system;PASSWORD=mala";
            string sqlQuery = "DELETE FROM ADMIN.TRAINSCHEDULE WHERE ScheduleID = :ID";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand(sqlQuery, connection))
                    {
                        command.Parameters.Add(":ID", OracleDbType.Varchar2).Value = employeeId;

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Schedule deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Schedule not found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void FILLdgv()
        {
            string connectionString = @"DATA SOURCE=localhost:1521/XE;USER ID=system;PASSWORD=mala";
            string sqlQuery = "SELECT * FROM ADMIN.TRAINSCHEDULE";
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand(sqlQuery, connection))
                    {
                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
    }

