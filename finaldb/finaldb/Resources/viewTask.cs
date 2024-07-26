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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace finaldb.Resources
{
    public partial class viewTask : Form
    {
        string ID;
        public viewTask(string id)
        {
            InitializeComponent();
            ID = id;
            comboBox1.Items.AddRange(new object[] { "ALL", "Missed", "Completed" });
            LoadTasks();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void LoadTasks()
        {
            string connectionString = @"DATA SOURCE=localhost:1521/XE;USER ID=system;PASSWORD=mala";
            string sqlQuery = "SELECT * FROM ADMIN.TASK WHERE EMPLOYEE_ID = :empId";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand(sqlQuery, connection))
                    {
                        command.Parameters.Add(":empId", OracleDbType.Varchar2).Value = ID;

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
        private void FilterTasks(string status)
        {
            string connectionString = @"DATA SOURCE=localhost:1521/XE;USER ID=system;PASSWORD=mala";
            string sqlQuery = "SELECT * FROM ADMIN.TASK WHERE EMPLOYEE_ID = :empId";

            if (status != "All")
            {
                sqlQuery += " AND STATUS = :status";
            }

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand(sqlQuery, connection))
                    {
                        command.Parameters.Add(":empId", OracleDbType.Varchar2).Value = ID;

                        if (status != "All")
                        {
                            command.Parameters.Add(":status", OracleDbType.Varchar2).Value = status;
                        }

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStatus = comboBox1.SelectedItem.ToString();
            FilterTasks(selectedStatus);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
