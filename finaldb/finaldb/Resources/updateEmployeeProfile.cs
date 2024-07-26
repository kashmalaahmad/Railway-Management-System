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
    public partial class updateEmployeeProfile : Form
    {
        string ID;
        public updateEmployeeProfile(string id)
        {
            InitializeComponent();
            ID = id;
            FILLdgv(ID);

        }

        private void FILLdgv(string id)
        {
            string connectionString = @"DATA SOURCE=localhost:1521/XE;USER ID=system;PASSWORD=mala";
            string sqlQuery = "SELECT * FROM ADMIN.EMPLOYEES WHERE employeeid = :ID";
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand(sqlQuery, connection))
                    {
                        command.Parameters.Add(":ID", OracleDbType.Varchar2).Value = id;
                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);

                            // Transpose the DataTable
                            DataTable transposedTable = TransposeDataTable(dataTable);

                            dataGridView1.DataSource = transposedTable;
                            PopulateTextBoxes(dataTable.Rows[0]);

                            // Style DataGridView
                            dataGridView1.GridColor = Color.White;
                            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
                            dataGridView1.Columns.Cast<DataGridViewColumn>().ToList().ForEach(col => col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private DataTable TransposeDataTable(DataTable dt)
        {
            DataTable transposedTable = new DataTable();
            transposedTable.Columns.Add("Attribute", typeof(string));
            transposedTable.Columns.Add("Value", typeof(string));

            foreach (DataColumn col in dt.Columns)
            {
                DataRow newRow = transposedTable.NewRow();
                newRow["Attribute"] = col.ColumnName;
                newRow["Value"] = dt.Rows[0][col.ColumnName];
                transposedTable.Rows.Add(newRow);
            }

            return transposedTable;
        }
        private void PopulateTextBoxes(DataRow row)
        {
            textBox9.Text = row["name"].ToString();
            textBox3.Text = row["password"].ToString();
            textBox1.Text = row["cnic"].ToString();
            textBox2.Text = row["email"].ToString();
            textBox4.Text = row["phoneNumber"].ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            string name1 = textBox9.Text;
            string password1 = textBox3.Text;
            string cnic1 = textBox1.Text;
            string email1 = textBox2.Text;
            string phoneNumber1 = textBox4.Text;

            string connectionString = @"DATA SOURCE=localhost:1521/XE;USER ID=system;PASSWORD=mala";
            string sqlQuery = @"UPDATE ADMIN.EMPLOYEES
                        SET name = '" + name1 + @"',
                            cnic = '" + cnic1 + @"',
                            email = '" + email + @"',
                            password = '" + password1+ @"',
                            phoneNumber = '" + phoneNumber1 + @"'
                        WHERE EMPLOYEEID = '" + ID + "'";


            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand(sqlQuery, connection))
                    {
                        //command.Parameters.Add(":name", OracleDbType.Varchar2).Value = name1;
                        //command.Parameters.Add(":cnic", OracleDbType.Varchar2).Value = cnic1;
                        //command.Parameters.Add(":email", OracleDbType.Varchar2).Value = email;
                        //command.Parameters.Add(":password", OracleDbType.Varchar2).Value = password1;
                        //command.Parameters.Add(":phoneNumber", OracleDbType.Varchar2).Value = phoneNumber1;
                        //command.Parameters.Add(":ID", OracleDbType.Varchar2).Value = ID;


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
                textBox9.Text = name;
                
                string password = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["roleCol"].Value);
                textBox3.Text = password;
                
                string cnic = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["cnicCol"].Value);
                textBox1.Text = cnic;
                string email = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["email"].Value);
                textBox2.Text = email;
                string phoneNumber = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["pnCol"].Value);
                textBox4.Text = phoneNumber;
            }
            }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
