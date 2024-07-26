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
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

namespace finaldb
{
    public partial class signup : Form
    {

        public signup()
        {
            InitializeComponent();
            textBox1.PasswordChar = '*';
        }
        string GenerateOTP()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }

        void SendEmailWithOTP(string to, string otp)
        {
            string from = "ahmadmala488@gmail.com";
            string mail = $"Your OTP for registration: {otp}";
            string pass = "pqwdhfznlqscojqj";

            MailMessage message = new MailMessage();
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = mail;
            message.Subject = "OTP for Registration";

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(message);
                MessageBox.Show("OTP has been sent to your email address.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send OTP: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool VerifyOTP(string enteredOTP, string generatedOTP)
        {

            return enteredOTP == generatedOTP;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        bool IsValid_Email(string email)
        {
            return email.Contains("@");
        }
        bool IsValid_Password(string password)
        {
            return (password.Count() > 8 && password.Any(char.IsDigit) && password.Any(char.IsLower) && password.Any(char.IsUpper) && password.Any(c => !char.IsLetterOrDigit(c)) && textBox3.Text == password);
        }
        bool IsValidCnic(string c)
        {
            Regex check = new Regex(@"^[0-9]{5}-[0-9]{7}-[0-9]{1}$");
            return check.IsMatch(c);
        }
        bool IsValidPhone(string c)
        {
            Regex check = new Regex(@"^[0-9]{4}-[0-9]{7}$");
            return check.IsMatch(c);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text;
            string password = textBox1.Text;
            if (!IsValid_Password(password))
            {
                MessageBox.Show("Passwod must contain a captial letter,small letter,number and special charachter", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            string cnic = textBox5.Text;
            if (!IsValidCnic(cnic))
            {
                MessageBox.Show("Invalid CNIC Format", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            string phone = textBox6.Text;
            if (!IsValidPhone(phone))
            {
                MessageBox.Show("Invalid Phone number Format", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            string email = textBox4.Text;
            if (!IsValid_Email(email))
            {
                MessageBox.Show("Invalid Email", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (IsValid_Email(email) && IsValid_Password(password) && IsValidCnic(cnic) && IsValidPhone(phone))
            {
                string to = textBox4.Text.ToString();
                string generatedOTP = GenerateOTP();


                SendEmailWithOTP(to, generatedOTP);


                string enteredOTP = Microsoft.VisualBasic.Interaction.InputBox("Enter OTP sent to your email:", "OTP Verification", "");
                if (VerifyOTP(enteredOTP, generatedOTP))
                {
                    string connectionString = @"DATA SOURCE=localhost:1521/XE;USER ID=system;PASSWORD=mala";
                    try
                    {
                        using (OracleConnection connection = new OracleConnection(connectionString))
                        {
                            string sql = "INSERT INTO ADMIN.PASSENGER (ID, name, password, cnic, email, phone_number) VALUES (ADMIN.PASSENGER_S.nextval, :name, :password, :cnic, :email, :phone)";

                            using (OracleCommand command = new OracleCommand(sql, connection))
                            {

                                command.Parameters.Add(":name", OracleDbType.Varchar2).Value = name;
                                command.Parameters.Add(":password", OracleDbType.Varchar2).Value = password;
                                command.Parameters.Add(":cnic", OracleDbType.Varchar2).Value = cnic;
                                command.Parameters.Add(":email", OracleDbType.Varchar2).Value = email;
                                command.Parameters.Add(":phone", OracleDbType.Varchar2).Value = phone;
                                try
                                {
                                    connection.Open();
                                    int rowsInserted = command.ExecuteNonQuery();
                                    MessageBox.Show($"{rowsInserted} row(s) inserted successfully.");
                                    //    smtp.Send(message);
                                    MessageBox.Show("Email Send Succesfully", email, MessageBoxButtons.OK);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }

                            }
                        }

                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Entered OTP is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }




            }
        }

            private void textBox3_TextChanged(object sender, EventArgs e)
            {

            }

            private void textBox6_TextChanged(object sender, EventArgs e)
            {

            }

            private void pictureBox1_Click(object sender, EventArgs e)
            {

            }
        }
    }
