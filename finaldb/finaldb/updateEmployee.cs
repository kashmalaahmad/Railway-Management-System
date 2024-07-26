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
using Oracle.ManagedDataAccess.Client;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.IO;

namespace finaldb
{
    public partial class updateEmployee : Form
    {
        public updateEmployee()
        {
            InitializeComponent();
            FILLdgv();
        }
        private void FILLdgv()
        {
            string connectionString = @"DATA SOURCE=localhost:1521/XE;USER ID=system;PASSWORD=mala";
            string sqlQuery = "SELECT * FROM ADMIN.EMPLOYEES";
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ( dataGridView1.Columns[e.ColumnIndex].HeaderText == "UPDATE")
            {
                string ID = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["IdCol"].Value);
                textBox1.Text = ID;
                string name = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["nameCol"].Value);
                textBox9.Text = name;
                string shift = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["shiftCol"].Value);
                textBox8.Text = shift;
                string role = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["roleCol"].Value);
                textBox7.Text = role;
                decimal salary = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["salCol"].Value);
                textBox5.Text = salary.ToString();
                DateTime dateOfJoining = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["dojCol"].Value);
                textBox6.Text = dateOfJoining.ToShortDateString();
                string cnic = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["cnicCol"].Value);
                textBox2.Text = cnic;
                string email = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["email"].Value);
                textBox4.Text = email;
                string phoneNumber = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["pnCol"].Value);
                textBox3.Text = phoneNumber;
              
                
            }
        }
           
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           string ID = textBox1.Text;
    string name = textBox9.Text;
    string shift = textBox8.Text;
    string role = textBox7.Text;
    decimal salary = decimal.Parse(textBox5.Text);
    DateTime dateOfJoining = DateTime.Parse(textBox6.Text);
    string cnic = textBox2.Text;
    string email = textBox4.Text;
    string phoneNumber = textBox3.Text;
    
    string connectionString = @"DATA SOURCE=localhost:1521/XE;USER ID=system;PASSWORD=mala";
    string sqlQuery = @"UPDATE ADMIN.EMPLOYEES
                        SET name = :name, 
                            shift = :shift, 
                            role = :role, 
                            salary = :salary, 
                            dateOfJoining = :dateOfJoining, 
                            cnic = :cnic, 
                            email = :email, 
                            phoneNumber = :phoneNumber
                        WHERE EMPLOYEEID = :ID";

    using (OracleConnection connection = new OracleConnection(connectionString))
    {
        try
        {
            connection.Open();

            using (OracleCommand command = new OracleCommand(sqlQuery, connection))
            {
                command.Parameters.Add(":name", OracleDbType.Varchar2).Value = name;
                command.Parameters.Add(":shift", OracleDbType.Varchar2).Value = shift;
                command.Parameters.Add(":role", OracleDbType.Varchar2).Value = role;
                command.Parameters.Add(":salary", OracleDbType.Decimal).Value = salary;
                command.Parameters.Add(":dateOfJoining", OracleDbType.Date).Value = dateOfJoining;
                command.Parameters.Add(":cnic", OracleDbType.Varchar2).Value = cnic;
                command.Parameters.Add(":email", OracleDbType.Varchar2).Value = email;
                command.Parameters.Add(":phoneNumber", OracleDbType.Varchar2).Value = phoneNumber;
                command.Parameters.Add(":ID", OracleDbType.Varchar2).Value =ID;

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

        }
    }
}
