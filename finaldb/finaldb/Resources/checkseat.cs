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
    public partial class checkseat : Form
    {
        public checkseat()
        {
            InitializeComponent();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new object[] { "First Class", "Economy", "Business Class" });
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string trainId = textBox1.Text;
            string seatType = comboBox1.SelectedItem?.ToString();
            string scheduleId = textBox2.Text;

            if (string.IsNullOrEmpty(trainId) || string.IsNullOrEmpty(seatType) || string.IsNullOrEmpty(scheduleId))
            {
                MessageBox.Show("Please enter Train ID, Seat Type, and Schedule ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = @"DATA SOURCE=localhost:1521/XE;USER ID=system;PASSWORD=mala";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string checkAvailableSeatsQuery = @"SELECT s.SEAT_ID, s.TRAIN_ID, s.SEAT_TYPE
                                                FROM ADMIN.SEATS s
                                                LEFT JOIN ADMIN.TICKET_SALES ts ON s.SEAT_ID = ts.SEAT_ID
                                                WHERE s.TRAIN_ID = :trainId 
                                                AND s.SEAT_TYPE = :seatType 
                                                AND (ts.STATUS IS NULL OR ts.STATUS <> 'Purchased')
                                                AND ROWNUM <= 1";

                    using (OracleCommand command = new OracleCommand(checkAvailableSeatsQuery, connection))
                    {
                        command.Parameters.Add(":trainId", OracleDbType.Varchar2).Value = trainId;
                        command.Parameters.Add(":seatType", OracleDbType.Varchar2).Value = seatType;

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

            dataGridView1.Visible = true;
        }
    }
}

