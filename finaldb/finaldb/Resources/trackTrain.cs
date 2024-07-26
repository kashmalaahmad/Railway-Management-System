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
    public partial class trackTrain : Form
    {
        public trackTrain()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = @"DATA SOURCE=localhost:1521/XE;USER ID=system;PASSWORD=mala";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();
                try
                {
                    string sql = @"SELECT Status FROM ADMIN.TRAINSCHEDULE WHERE TrainID = :trainId";

                    using (OracleCommand command = new OracleCommand(sql, connection))
                    {
                        command.Parameters.Add(new OracleParameter("trainId", textBox2.Text));

                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string status = reader["Status"].ToString();
                                MessageBox.Show($"Status of Train {textBox2.Text}: {status}");
                            }
                            else
                            {
                                MessageBox.Show($"Train with ID {textBox2.Text} not found.");
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }

}
  