using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Oracle.ManagedDataAccess.Client;

namespace finaldb.Resources
{
    public partial class addemployee : Form
    {
        public addemployee()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new object[] { "Cashier", "Driver", "CustomerService" });
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
          
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = @"DATA SOURCE=localhost:1521/XE;USER ID=system;PASSWORD=mala";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();
                try
                {
                   
                    string name = textBox2.Text;
                    decimal salary = Convert.ToDecimal(textBox5.Text);
                    DateTime dateOfJoining = dateTimePicker1.Value;
                    string cnic = textBox6.Text;
                    string email = textBox7.Text;
                    string role = comboBox1.Text;
                    if (!IsValid_Email(email))
                     {
                        MessageBox.Show("Invalid Email", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                        string password = textBox8.Text;
                    if(!IsValid_Password(password))
                    {
                        MessageBox.Show("Passwod must contain a captial letter,small letter,number and special charachter", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    string phoneNumber = textBox4.Text;
                    byte[] imageData = GetImageData(); 
                    string sql = @"INSERT INTO ADMIN.EMPLOYEES (EmployeeID,Name,role, Salary, DateOfJoining, CNIC, Email, Password, PhoneNumber, Image) 
                           VALUES (ADMIN.employee_seq.nextval,:name, :role, :salary, :dateOfJoining, :cnic, :email, :password, :phoneNumber, :image)";

                    using (OracleCommand command = new OracleCommand(sql, connection))
                    {
                        command.Parameters.Add(":name", OracleDbType.Varchar2).Value = name;
                        command.Parameters.Add(":role", OracleDbType.Varchar2).Value = role;
                        command.Parameters.Add(":salary", OracleDbType.Decimal).Value = salary;
                        command.Parameters.Add(":dateOfJoining", OracleDbType.Date).Value = dateOfJoining;
                        command.Parameters.Add(":cnic", OracleDbType.Varchar2).Value = cnic;
                        command.Parameters.Add(":email", OracleDbType.Varchar2).Value = email;
                        command.Parameters.Add(":password", OracleDbType.Varchar2).Value = password;
                        command.Parameters.Add(":phoneNumber", OracleDbType.Varchar2).Value = phoneNumber;
                        command.Parameters.Add(":image", OracleDbType.Blob).Value = imageData;

                        int rowsInserted = command.ExecuteNonQuery();
                        MessageBox.Show($"{rowsInserted} row(s) inserted successfully.");
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        bool IsValid_Email(string email)
        {
            return email.Contains("@gmail.com");
        }
        bool IsValid_Password(string password)
        {
            return (password.Count() > 8 && password.Any(char.IsDigit) && password.Any(char.IsLower) && password.Any(char.IsUpper) && password.Any(c => !char.IsLetterOrDigit(c)));
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void Aud(string sqls, int state)
        {
            string msg = "";
            OracleCommand cmd = new OracleCommand();
            cmd.CommandType = CommandType.Text;

            switch (state)
            {
                case 0:
                    msg = "Added Successfully";
                    break;
                case 1:
                    msg = "Updated Successfully";
                    break;
            }

            cmd.CommandText = msg;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            

        }
    }
}
