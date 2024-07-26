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
    public partial class updatePassenger : Form
    {
        string ID;
        public updatePassenger(string id)
        {
            InitializeComponent();
            ID = id;
            FILLdgv(ID);
        }

        private void FILLdgv(string ID)
        {
            string connectionString = @"DATA SOURCE=localhost:1521/XE;USER ID=system;PASSWORD=mala";
            string sqlQuery = "SELECT * FROM ADMIN.PASSENGER WHERE ID='" + ID + "'";
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

                            // Check if data is retrieved
                            if (dataTable.Rows.Count > 0)
                            {
                                // Call the PopulateTextBoxes method with the first row of the DataTable
                                PopulateTextBoxes(dataTable.Rows[0]);
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

        private void PopulateTextBoxes(DataRow row)
        {
            textBox1.Text = row["name"].ToString();
            textBox2.Text = row["CNIC"].ToString();
            textBox3.Text = row["phone_number"].ToString();
            textBox6.Text = row["password"].ToString();
            textBox5.Text = row["email"].ToString();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string name = textBox1.Text;
           
            string cnic = textBox2.Text;
            string email = textBox5.Text;
            string phoneNumber = textBox3.Text;
            string password = textBox6.Text;

            string connectionString = @"DATA SOURCE=localhost:1521/XE;USER ID=system;PASSWORD=mala";
            string sqlQuery = @"UPDATE ADMIN.PASSENGER   SET name = :name,   cnic = :cnic,  email = :email,  phone_number = :phoneNumber, password = :password
                               WHERE ID = '" + ID + "'";
            ;

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand(sqlQuery, connection))
                    {
                        command.Parameters.Add(":name", OracleDbType.Varchar2).Value = name;
                       
                        command.Parameters.Add(":password", OracleDbType.Varchar2).Value = password;
              
                        command.Parameters.Add(":cnic", OracleDbType.Varchar2).Value = cnic;
                        command.Parameters.Add(":email", OracleDbType.Varchar2).Value = email;
                        command.Parameters.Add(":phoneNumber", OracleDbType.Varchar2).Value = phoneNumber;
                       

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record updated successfully.");
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "UPDATE")
            {
               
                string name = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["nameCol"].Value);
                textBox1.Text = name;
            
                string cnic = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["cnicCol"].Value);
                textBox2.Text = cnic;
                string email = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["email"].Value);
                textBox5.Text = email;
                string phoneNumber = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["pnCol"].Value);
                textBox3.Text = phoneNumber;
                string password = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["pnCol"].Value);
                textBox6.Text = password;

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
