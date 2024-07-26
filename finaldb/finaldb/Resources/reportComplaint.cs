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
    public partial class reportComplaint : Form
    {
        string ID;
        public reportComplaint(string Id)
        {
            InitializeComponent();
            ID = Id;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = comboBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
             string connectionString = @"DATA SOURCE=localhost:1521/XE;USER ID=system;PASSWORD=mala";
    using (OracleConnection connection = new OracleConnection(connectionString))
    {
        connection.Open();
        try
        {
            string complaintType = comboBox1.Text;
            string complaintDescription = richTextBox1.Text;

            string sql = @"INSERT INTO ADMIN.COMPLAINTS (user_id, type,description) 
                           VALUES (:user_id, :complaintType, :complaintDescription)";

            using (OracleCommand command = new OracleCommand(sql, connection))
            {
                command.Parameters.Add(":user_id", OracleDbType.Varchar2).Value = ID;
                command.Parameters.Add(":type", OracleDbType.Varchar2).Value = complaintType;
                command.Parameters.Add(":Description", OracleDbType.Varchar2).Value = complaintDescription;

                int rowsInserted = command.ExecuteNonQuery();
                MessageBox.Show($"{rowsInserted} row(s) inserted successfully.");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        connection.Close();
    }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }

}
  
