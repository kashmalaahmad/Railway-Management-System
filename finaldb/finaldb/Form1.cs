using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using finaldb.Resources;
using Oracle.ManagedDataAccess.Client;
namespace finaldb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter_1(object sender, EventArgs e)
        {
            if(textBox1.Text=="User ID")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "User ID";
            }
        }

        private void textBox2_Enter_1(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.PasswordChar = '*';
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Password";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
             
            signup obj =new signup();
            obj.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string connectionString = @"DATA SOURCE=localhost:1521/XE;USER ID=system;PASSWORD=mala";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string userID = textBox1.Text;
                    string password = textBox2.Text;
                    string userType = "";

                    string sqlQuery = @"
                        SELECT 'Employee' AS UserType, Password
                        FROM ADMIN.EMPLOYEES
                        WHERE EMPLOYEEID = :userID AND Password = :password
                        UNION ALL
                        SELECT 'Admin' AS UserType, Password 
                        FROM ADMIN.ADMIN_TABLE
                        WHERE ADMIN_ID = :userID AND Password = :password
                        UNION ALL
                        SELECT 'Passenger' AS UserType, Password 
                        FROM ADMIN.PASSENGER 
                        WHERE ID = :userID AND Password = :password";

                    string sqlQuer = @"
                        SELECT 'Driver' AS type, role
                        FROM ADMIN.EMPLOYEES
                        WHERE EMPLOYEEID = :userID AND role = 'Driver'
                        UNION ALL
                        SELECT 'Cashier' AS type,role 
                        FROM ADMIN.EMPLOYEES
                        WHERE EMPLOYEEID = :userID AND role = 'Cashier'
                        UNION ALL
                        SELECT 'Customer Service' AS type, role
                        FROM ADMIN.EMPLOYEES
                        WHERE EMPLOYEEID = :userID AND Password ='Customer Service'";

                    using (OracleCommand command = new OracleCommand(sqlQuery, connection))
                    {
                        command.Parameters.Add(":userID", OracleDbType.Varchar2).Value = userID;
                        command.Parameters.Add(":password", OracleDbType.Varchar2).Value = password;

                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                userType = reader["UserType"].ToString();
                                string storedPassword = reader["Password"].ToString();

                                if (password == storedPassword)
                                {
                                    switch (userType)
                                    {
                                        case "Employee":
                                            string type = "";

                                            using (OracleCommand typeCommand = new OracleCommand(sqlQuer, connection))
                                            {
                                                typeCommand.Parameters.Add(":userID", OracleDbType.Varchar2).Value = userID;

                                                using (OracleDataReader typeReader = typeCommand.ExecuteReader())
                                                {
                                                    if (typeReader.Read())
                                                    {
                                                        type = typeReader["type"].ToString();
                                                    }
                                                }
                                            }

                                            switch (type.Trim())
                                            {
                                                case "Driver":
                                                    driverInterface driverInterface = new driverInterface(userID);
                                                    driverInterface.Show();
                                                    break;
                                                case "Cashier":
                                                    cashierInterface cashierInterface = new cashierInterface(userID);
                                                    cashierInterface.Show();
                                                    break;
                                                default:
                                                    customerSupportInterface customerSupportInterface = new customerSupportInterface(userID);
                                                    customerSupportInterface.Show();
                                                    break;
                                              
                                            }
                                            break;
                                        case "Admin":
                                            Form2 form2 = new Form2(userID);
                                            form2.Show();
                                            break;
                                        case "Passenger":
                                            passengerPage passengerPage = new passengerPage(userID);
                                            passengerPage.Show();
                                            break;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Incorrect password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("User ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                    connection.Close();
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
