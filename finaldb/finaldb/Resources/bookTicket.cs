using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using System.Net.Http;



    using TextmagicRest;
using TextmagicRest.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace finaldb.Resources
{
    public partial class bookTicket : Form
    {
        string id;
        public bookTicket(string Id)
        {
            InitializeComponent();
            comboBox5.Items.Clear();
            comboBox5.Items.AddRange(new object[] { "First Class", "Economy", "Business Class" });
            id = Id;
            SendMessage();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public async Task SendMessage()
        {
            string apiKey = "8d8a27cf00msh57b830f0918fcc5p1be198jsnaaabf43feef1";
            string baseUrl = "https://textbelt-sms.p.rapidapi.com";
            string endpoint = "/text";

            // Construct the request body
            var content = new FormUrlEncodedContent(new Dictionary<string, string>
    {
        { "key", "textbelt" },
        { "message", "Your message goes here" },
        { "phone", "03357903678" }  // Replace with the recipient phone number
    });

            // Create HttpClient instance
            using (HttpClient client = new HttpClient())
            {
                // Set API key in headers
                client.DefaultRequestHeaders.Add("x-rapidapi-key", apiKey);
                client.DefaultRequestHeaders.Add("x-rapidapi-host", "textbelt-sms.p.rapidapi.com");

                // Construct the request URL
                string requestUrl = baseUrl + endpoint;
                try
                {
                    // Make POST request
                    HttpResponseMessage response = await client.PostAsync(requestUrl, content);

                    // Check if request was successful
                    if (response.IsSuccessStatusCode)
                    {
                        // Read response content
                        string responseBody = await response.Content.ReadAsStringAsync();
                        Console.WriteLine("Response: " + responseBody);
                    }
                    else
                    {
                        Console.WriteLine("Error: " + response.ReasonPhrase);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string trainId = textBox1.Text;
            string seatType = comboBox5.SelectedItem.ToString();
            string schedule_id = textBox2.Text;
            string passengerId = id;

            string connectionString = @"DATA SOURCE=localhost:1521/XE;USER ID=system;PASSWORD=mala";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string checkSeatsQuery = @"SELECT SEAT_ID 
                                       FROM ADMIN.seats 
                                       WHERE  SEAT_ID NOT IN 
                                              (SELECT SEAT_ID 
                                               FROM ADMIN.Ticket_Sales 
                                               WHERE TRAIN_ID = :trainId  
                                               AND STATUS = 'Purchased' 
                                               AND schedule_id = :schedule_id) 
                                       AND SEAT_TYPE = :seatType 
                                       AND ROWNUM <= 1 
                                       ORDER BY SEAT_ID";

                    using (OracleCommand command = new OracleCommand(checkSeatsQuery, connection))
                    {
                        command.Parameters.Add(":trainId", OracleDbType.Varchar2).Value = trainId;
                        command.Parameters.Add(":seatType", OracleDbType.Varchar2).Value = seatType;
                        command.Parameters.Add(":schedule_id", OracleDbType.Varchar2).Value = schedule_id;
                       
                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                MessageBox.Show("Seats not available.");
                               
                            }
                            bool booked = false;
                            decimal totalPrice = 0;

                            while (reader.Read())
                            {
                                string seatId = reader.GetString(0);

                                string getPriceQuery = @"SELECT PRICE 
                                                 FROM ADMIN.seats 
                                                 WHERE TRAIN_ID = :trainId 
                                                 AND SEAT_TYPE = :seatType";

                                using (OracleCommand getPriceCommand = new OracleCommand(getPriceQuery, connection))
                                {
                                    getPriceCommand.Parameters.Add(":trainId", OracleDbType.Varchar2).Value = trainId;
                                    getPriceCommand.Parameters.Add(":seatType", OracleDbType.Varchar2).Value = seatType;

                                    object result = getPriceCommand.ExecuteScalar();
                                    if (result != null)
                                    {
                                        decimal price = Convert.ToDecimal(result);
                                        totalPrice = price;

                                        string insertTicketQuery = @"INSERT INTO ADMIN.ticket_sales 
                                                            (TICKET_ID, PRICE, TRAIN_ID, ISSUE_DATE, PASSENGER_ID, SEAT_ID, STATUS, SCHEDULE_ID)
                                                            VALUES 
                                                            (ADMIN.TICKET_SALES_ID_SEQ.NEXTVAL, :price, :trainId, SYSDATE, :passengerId, :seatId, 'Purchased', :schedule_id)";
                                        using (OracleCommand insertCommand = new OracleCommand(insertTicketQuery, connection))
                                        {
                                            insertCommand.Parameters.Add(":price", OracleDbType.Decimal).Value = price;
                                            insertCommand.Parameters.Add(":trainId", OracleDbType.Varchar2).Value = trainId;
                                            insertCommand.Parameters.Add(":passengerId", OracleDbType.Varchar2).Value = passengerId;
                                            insertCommand.Parameters.Add(":seatId", OracleDbType.Varchar2).Value = seatId;
                                            insertCommand.Parameters.Add(":schedule_id", OracleDbType.Varchar2).Value = schedule_id;

                                            int rowsAffected = insertCommand.ExecuteNonQuery();
                                            if (rowsAffected > 0)
                                            {
                                                string updateSeatStatusQuery = "UPDATE ADMIN.seats SET STATUS = 'Purchased' WHERE SEAT_ID = :seatId";
                                                using (OracleCommand updateCommand = new OracleCommand(updateSeatStatusQuery, connection))
                                                {
                                                    updateCommand.Parameters.Add(":seatId", OracleDbType.Varchar2).Value = seatId;
                                                    int updateRowsAffected = updateCommand.ExecuteNonQuery();
                                                }

                                                booked = true;
                                            }
                                            else
                                            {
                                                MessageBox.Show("Booking failed.");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Price not found for the selected seat type.");
                                    }
                                }
                            }
                            if (booked)
                            {
                                MessageBox.Show($"Booking successful. Total Price: {totalPrice}");
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



        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            viewSchedule viewSchedule = new viewSchedule(); 
            viewSchedule.Show();  
        }
    }
    }