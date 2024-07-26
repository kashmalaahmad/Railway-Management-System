using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using System.Net.Mail;

namespace finaldb
{
    public partial class updateSchedule : Form
    {
        public updateSchedule()
        {
            InitializeComponent();
            FILLdgv();
        }
        private void FILLdgv()
        {
            string connectionString = @"DATA SOURCE=localhost:1521/XE;USER ID=system;PASSWORD=mala";
            string sqlQuery = "SELECT * FROM ADMIN.TRAINSCHEDULE";
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand(sqlQuery, connection))
                    {
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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "UPDATE")
            {
                string ScheduleID = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Col2"].Value);
                string arrivalTimeString = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Col3"].Value);
                string departureTimeString = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Col4"].Value);
                string route = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Col5"].Value);
                string status = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Col6"].Value);
                string fare = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Col7"].Value);
                string trainId = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Col8"].Value);

                textBox4.Text = ScheduleID;

                
                textBox3.Text = route;
                textBox2.Text = status;
                textBox1.Text = fare;
                textBox5.Text = trainId;
            }

        }
        void SendEmail(string to,string scheduleId)
        {
            string from = "ahmadmala488@gmail.com";
            string mail = $"There is a change in this schedule ID . Please visit your profile for more info";
            string pass = "pqwdhfznlqscojqj";

            MailMessage message = new MailMessage();
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = mail;
            message.Subject = "Change in Schedule";

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(message);
                MessageBox.Show("Email Sent", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send Email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string ScheduleID = textBox4.Text;
            string arrivalTime = dateTimePicker1.Value.ToString("HH:mm:ss");
            string departureTime = dateTimePicker3.Value.ToString("HH:mm:ss");
            string route = textBox3.Text;
            string status = textBox2.Text;
            string fare = textBox1.Text;
            string trainId = textBox5.Text;
            byte[] imageData = GetImageData();

            string connectionString = @"DATA SOURCE=localhost:1521/XE;USER ID=system;PASSWORD=mala";
            string sqlQuery = @"UPDATE ADMIN.TRAINSCHEDULE
                 SET ARRIVALTIME = :arrivalTime,
                     DEPARTURETIME = :departureTime,
                     ROUTE = :route,
                     STATUS = :status,
                     FARE = :fare,
                     TRAINID = :trainId,
                     IMAGE = :imageData
                 WHERE SCHEDULEID = :scheduleId";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(sqlQuery, connection))
                    {
                        command.Parameters.Add(":arrivalTime", OracleDbType.Varchar2).Value = arrivalTime;
                        command.Parameters.Add(":departureTime", OracleDbType.Varchar2).Value = departureTime;
                        command.Parameters.Add(":route", OracleDbType.Varchar2).Value = route;
                        command.Parameters.Add(":status", OracleDbType.Varchar2).Value = status;
                        command.Parameters.Add(":fare", OracleDbType.Varchar2).Value = fare;
                        command.Parameters.Add(":trainId", OracleDbType.Varchar2).Value = trainId;
                        command.Parameters.Add(":imageData", OracleDbType.Blob).Value = imageData;
                        command.Parameters.Add(":scheduleId", OracleDbType.Varchar2).Value = ScheduleID;

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            DataTable dt = GetPassengersEmails(ScheduleID);
                            foreach (DataRow row in dt.Rows)
                            {
                                string recipientEmail = row["EMAIL"].ToString();
                                SendEmail(recipientEmail, ScheduleID);
                            }

                            MessageBox.Show("Record updated successfully and email notifications sent.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update record.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private DataTable GetPassengersEmails(string scheduleId)
        {
            DataTable dt = new DataTable();
            string connectionString = @"DATA SOURCE=localhost:1521/XE;USER ID=system;PASSWORD=mala";
            string sqlQuery = @"SELECT DISTINCT P.EMAIL
                       FROM ADMIN.PASSENGER P
                       JOIN ADMIN.TICKET_SALES TS ON P.ID = TS.PASSENGER_ID
                       WHERE TS.SCHEDULE_ID = :scheduleId";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(sqlQuery, connection))
                    {
                        command.Parameters.Add(":scheduleId", OracleDbType.Varchar2).Value = scheduleId;

                        OracleDataAdapter adapter = new OracleDataAdapter(command);
                        adapter.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return dt;
        }




        private void button2_Click(object sender, EventArgs e)
        {
            string imagelocation = "";
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Filter = "jpg Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
                if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imagelocation = fileDialog.FileName;
                    pictureBox2.ImageLocation = imagelocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error ocurred", "Error", MessageBoxButtons.OK);

            }
        }
        private byte[] GetImageData()
        {
            if (pictureBox2.Image == null)
            {
                MessageBox.Show("Please select an image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            using (MemoryStream ms = new MemoryStream())
            {
                string extension = Path.GetExtension(pictureBox2.ImageLocation).ToLower();

                ImageFormat format = ImageFormat.Jpeg;
                switch (extension)
                {
                    case ".jpg":
                    case ".jpeg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".png":
                        format = ImageFormat.Png;
                        break;
                    default:
                        MessageBox.Show("Unsupported image format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                }

                pictureBox2.Image.Save(ms, format);
                return ms.ToArray();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
