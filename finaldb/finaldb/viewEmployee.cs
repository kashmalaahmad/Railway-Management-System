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
using Oracle.ManagedDataAccess.Client;
namespace finaldb
{
    public partial class viewEmployee : Form
    {
        string ID;
        public viewEmployee()
        {
            InitializeComponent();
            FILLdgv();
 
        }
        public viewEmployee(string id)
        {
            InitializeComponent();
          
            ID = id;
            FILLdgv(ID);
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

                            // Bind the transposed DataTable to the DataGridView
                            dataGridView1.DataSource = transposedTable;

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


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }


}