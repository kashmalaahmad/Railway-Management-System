using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace finaldb
{
    public partial class AddSchedule : Form
    {
        public AddSchedule()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"DATA SOURCE=localhost:1521/XE;USER ID=system;PASSWORD=mala";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();
                try
                {
                    TimeSpan arrival = dateTimePicker1.Value.TimeOfDay;
                    TimeSpan departure = dateTimePicker2.Value.TimeOfDay;
                    string arrivalTime = arrival.ToString(@"hh\:mm\:ss");
                    string departureTime = departure.ToString(@"hh\:mm\:ss");
                    int route;
                    if (!int.TryParse(textBox5.Text, out route))
                    {
                        MessageBox.Show("Route must be a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       
                    }
                    string status = textBox2.Text;
                    string fare = (textBox1.Text);
                    string trainId = textBox6.Text;
                    byte[] imageData = GetImageData();

                    string sql = @"INSERT INTO ADMIN.TRAINSCHEDULE (SCHEDULEID, ARRIVALTIME, DEPARTURETIME, ROUTE, STATUS, FARE, TRAINID, IMAGE) 
                          VALUES ( ADMIN.trainschedule_seq.NEXTVAL, :arrivalTime, :departureTime, :route, :status, :fare, :trainId, :imageData)";

                    using (OracleCommand command = new OracleCommand(sql, connection))
                    {
                        command.Parameters.Add(":arrivalTime", OracleDbType.Varchar2).Value = (arrivalTime);
                        command.Parameters.Add(":departureTime", OracleDbType.Varchar2).Value =(departureTime);
                        command.Parameters.Add(":route", OracleDbType.Varchar2).Value = route;
                        command.Parameters.Add(":status", OracleDbType.Varchar2).Value = status;
                        command.Parameters.Add(":fare", OracleDbType.Varchar2).Value = fare;
                        command.Parameters.Add(":trainId", OracleDbType.Varchar2).Value = trainId;
                        command.Parameters.Add(":imageData", OracleDbType.Blob).Value = imageData;

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

        private string ConvertTimeSpanToOracleInterval(TimeSpan timeSpan)
        {
            return string.Format("INTERVAL '{0}:{1}:{2}' DAY TO SECOND", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
    }
}
