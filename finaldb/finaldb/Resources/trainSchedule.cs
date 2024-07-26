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
    public partial class trainSchedule : Form
    {
        public trainSchedule()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            string connectionString = @"DATA SOURCE=localhost:1521/XE;USER ID=system;PASSWORD=mala";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string routeId = textBox4.Text;

                    string sql = $@"SELECT * FROM ADMIN.TRAINSCHEDULE WHERE route = :routeId";

                    using (OracleCommand command = new OracleCommand(sql, connection))
                    {
                        command.Parameters.Add(":routeId", OracleDbType.Varchar2).Value = routeId;

                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            // Clear existing controls in the panel
                            panel1.Controls.Clear();

                            int yPos = 0;

                            // Loop through the rows returned by the query
                            while (reader.Read())
                            {
                                // Create labels for each attribute and add them to the panel
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    Label label = new Label();
                                    label.Text = $"{reader.GetName(i)}: {reader.GetValue(i)}"; // Column name and value
                                    label.AutoSize = true;
                                    label.Location = new Point(10, yPos);
                                    panel1.Controls.Add(label);
                                    yPos += label.Height + 5;
                                }
                                // Add some space between rows
                                yPos += 10;
                            }
                        }
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();

        }

        private void trainSchedule_Load(object sender, EventArgs e)
        {

        }
    }
}
