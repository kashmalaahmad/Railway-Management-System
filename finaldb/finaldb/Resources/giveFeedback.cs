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
    public partial class giveFeedback : Form
    {
        string ID;
        public giveFeedback(string id)
        {
            InitializeComponent();
            ID = id;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int satisfactionRating = Convert.ToInt32(comboBox1.SelectedItem);
            int ticketPurchaseRating = Convert.ToInt32(comboBox2.SelectedItem);
            int cleanlinessRating = Convert.ToInt32(comboBox3.SelectedItem);
            int availabilityRating = Convert.ToInt32(comboBox4.SelectedItem);
            int cooperationRating = Convert.ToInt32(comboBox5.SelectedItem);

            InsertFeedback(ID, satisfactionRating, ticketPurchaseRating, cleanlinessRating, availabilityRating, cooperationRating);
        }
        private void InsertFeedback(string userID, int satisfaction, int ticketPurchase, int cleanliness, int availability, int cooperation)
        {
            string connectionString = @"DATA SOURCE=localhost:1521/XE;USER ID=system;PASSWORD=mala";
            string sqlQuery = @"INSERT INTO ADMIN.feedback (FEEDBACK_ID, USER_ID, SATISFACTION, TICKET_PURCHASE, CLEANLINESS, AVAILABILITY, COOPERATION) 
                                VALUES (ADMIN.feedback_sequence.NEXTVAL, :userID, :satisfaction, :ticketPurchase, :cleanliness, :availability, :cooperation)";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand(sqlQuery, connection))
                    {
                        command.Parameters.Add(":userID", OracleDbType.Varchar2).Value = userID;
                        command.Parameters.Add(":satisfaction", OracleDbType.Int32).Value = satisfaction;
                        command.Parameters.Add(":ticketPurchase", OracleDbType.Int32).Value = ticketPurchase;
                        command.Parameters.Add(":cleanliness", OracleDbType.Int32).Value = cleanliness;
                        command.Parameters.Add(":availability", OracleDbType.Int32).Value = availability;
                        command.Parameters.Add(":cooperation", OracleDbType.Int32).Value = cooperation;

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Feedback submitted successfully.");
                      
                        }
                        else
                        {
                            MessageBox.Show("Failed to submit feedback.");
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
