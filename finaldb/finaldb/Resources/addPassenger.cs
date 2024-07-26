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
    public partial class addPassenger : Form
    {
        public addPassenger()
        {
            InitializeComponent();
        }

        private void passenger_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = @"DATA SOURCE=localhost:1521/XE;USER ID=system;PASSWORD=mala";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();
                try
                {
                    string PassengerID = textBox4.Text;
                    string PassengerName = textBox1.Text;
                    string status = textBox7.Text;
                    DateTime registeratonDate = dateTimePicker1.Value;
                    string cnic = textBox2.Text;
                    string email = textBox3.Text;
                    string phoneNumber = textBox6.Text;
                    string password = textBox5.Text;
                    string sql = @"INSERT INTO ADMIN.TRAINSCHEDULE (SCHEDULEID,ARRIVALTIME,DEPARTURETIME,ROUTE,STATUS,FARE,TRAINID) 
                          VALUES (:PassengerID, :PassengerName, :status, :registerationDate, :cnin, :email, :phoneNumber, :password)";

                    using (OracleCommand command = new OracleCommand(sql, connection))
                    {
                        command.Parameters.Add(":ScheduleID", OracleDbType.Varchar2).Value = PassengerID;
                        command.Parameters.Add(":PassengerName", OracleDbType.Varchar2).Value = PassengerName;
                        command.Parameters.Add(":registeratonDate", OracleDbType.Date).Value = registeratonDate;
                        command.Parameters.Add(":status", OracleDbType.Varchar2).Value = status;
                        command.Parameters.Add(":cnic", OracleDbType.Varchar2).Value = cnic;
                        command.Parameters.Add(":email", OracleDbType.Varchar2).Value = email;
                        command.Parameters.Add(":phoneNumber", OracleDbType.Varchar2).Value = phoneNumber;
                        command.Parameters.Add(":password", OracleDbType.Varchar2).Value = password;

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record inserted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert record.");
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
    }
}
