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
    public partial class viewPassenger : Form
    {
        string passengerid;
        public viewPassenger()
        {
            InitializeComponent();
        }

        public viewPassenger(string id)
        {
            InitializeComponent();
            passengerid = id;
            DisplayPassengerInformation();
        }

        private void DisplayPassengerInformation()
        {
            string connectionString = @"DATA SOURCE=localhost:1521/XE;USER ID=system;PASSWORD=mala";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string sqlQuery = "SELECT * FROM ADMIN.PASSENGER WHERE ID = :passengerID";

                    using (OracleCommand command = new OracleCommand(sqlQuery, connection))
                    {
                        command.Parameters.Add(":passengerID", OracleDbType.Varchar2).Value = passengerid;

                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Retrieve passenger information from the database
                                string passengerName = reader["NAME"].ToString();
                                string email = reader["EMAIL"].ToString();
                                string cnic = reader["CNIC"].ToString();
                                string password = reader["PASSWORD"].ToString();
                                string phoneNumber = reader["PHONE_NUMBER"].ToString();

                                // Create labels to display the retrieved information
                                Label nameLabel = new Label();
                                nameLabel.Text = $"Passenger Name: {passengerName}";
                                nameLabel.AutoSize = true;
                                nameLabel.Location = new Point(10, 10);
                                panel1.Controls.Add(nameLabel);

                                Label emailLabel = new Label();
                                emailLabel.Text = $"Email: {email}";
                                emailLabel.AutoSize = true;
                                emailLabel.Location = new Point(10, 30);
                                panel1.Controls.Add(emailLabel);

                                Label cnicLabel = new Label();
                                cnicLabel.Text = $"CNIC: {cnic}";
                                cnicLabel.AutoSize = true;
                                cnicLabel.Location = new Point(10, 50);
                                panel1.Controls.Add(cnicLabel);

                                Label passwordLabel = new Label();
                                passwordLabel.Text = $"Password: {password}";
                                passwordLabel.AutoSize = true;
                                passwordLabel.Location = new Point(10, 70);
                                panel1.Controls.Add(passwordLabel);

                                Label phoneNumberLabel = new Label();
                                phoneNumberLabel.Text = $"Phone Number: {phoneNumber}";
                                phoneNumberLabel.AutoSize = true;
                                phoneNumberLabel.Location = new Point(10, 90);
                                panel1.Controls.Add(phoneNumberLabel);
                            }
                            else
                            {
                                MessageBox.Show("Passenger not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
 
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
