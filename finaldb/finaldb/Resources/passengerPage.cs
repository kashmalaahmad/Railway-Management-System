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
    public partial class passengerPage : Form
    {
        string id;
        public passengerPage(string Id)
        {
            InitializeComponent();
            id = Id;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            viewReservations obj = new viewReservations(id);
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            customerService obj = new customerService(id);
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            trainSchedule trainSchedule = new trainSchedule();
            trainSchedule.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            bookTicket bookTicket = new bookTicket(id);
            bookTicket.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            trackTrain trackTrain = new trackTrain();   
            trackTrain.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkseat obj = new checkseat();
            obj.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            viewPassenger obj = new viewPassenger(id);
            obj.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            updatePassenger obj = new updatePassenger(id);
            obj.Show();
        }

        //private void panel1_Paint(object sender, PaintEventArgs e)
        //{
        //    string passengerId = id; 
        //    string connectionString = @"DATA SOURCE=localhost:1521/XE;USER ID=system;PASSWORD=mala";
        //    string query = "SELECT * FROM ADMIN.passenger WHERE ID = :passengerId";

        //    using (OracleConnection connection = new OracleConnection(connectionString))
        //    {
        //        try
        //        {
        //            connection.Open();

        //            using (OracleCommand command = new OracleCommand(query, connection))
        //            {
        //                command.Parameters.Add(":passengerId", OracleDbType.Varchar2).Value = passengerId;

        //                using (OracleDataReader reader = command.ExecuteReader())
        //                {
        //                    if (reader.Read())
        //                    {
        //                        int labelWidth = 100;
        //                        int labelHeight = 20;
        //                        int spacing = 30;
        //                        int startX = 20;
        //                        int startY = 20;


        //                        panel1.Controls.Clear();


        //                        Label nameLabel = new Label();
        //                        nameLabel.Text = "Name: " + reader["NAME"].ToString();
        //                        nameLabel.Width = labelWidth;
        //                        nameLabel.Height = labelHeight;
        //                        nameLabel.Location = new Point(startX, startY);
        //                        panel1.Controls.Add(nameLabel);

        //                        Label emailLabel = new Label();
        //                        emailLabel.Text = "Email: " + reader["EMAIL"].ToString();
        //                        emailLabel.Width = labelWidth;
        //                        emailLabel.Height = labelHeight;
        //                        emailLabel.Location = new Point(startX, startY + spacing);
        //                        panel1.Controls.Add(emailLabel);

        //                        Label cnicLabel = new Label();
        //                        cnicLabel.Text = "CNIC: " + reader["CNIC"].ToString();
        //                        cnicLabel.Width = labelWidth;
        //                        cnicLabel.Height = labelHeight;
        //                        cnicLabel.Location = new Point(startX, startY + 2 * spacing);
        //                        panel1.Controls.Add(cnicLabel);

        //                        Label phoneLabel = new Label();
        //                        phoneLabel.Text = "Phone Number: " + reader["PHONE_NUMBER"].ToString();
        //                        phoneLabel.Width = labelWidth;
        //                        phoneLabel.Height = labelHeight;
        //                        phoneLabel.Location = new Point(startX, startY + 3 * spacing);
        //                        panel1.Controls.Add(phoneLabel);
        //                    }
        //                    else
        //                    {
        //                        MessageBox.Show("Passenger not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                    }
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //}
    }
}
