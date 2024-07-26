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
    public partial class viewSalary : Form
    {
        string ID;
        public viewSalary(string id)
        {
            InitializeComponent();
            ID = id;
            LoadSalaries();
        }
        private void LoadSalaries()
        {
            string connectionString = @"DATA SOURCE=localhost:1521/XE;USER ID=system;PASSWORD=mala";
            string sqlQuery = "SELECT * FROM ADMIN.Salary WHERE employee_id = '" + ID + "'";


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
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn column = dataGridView1.Columns[e.ColumnIndex];
            ListSortDirection sortDirection = column.HeaderCell.SortGlyphDirection == SortOrder.Descending ?
                                   ListSortDirection.Descending : ListSortDirection.Descending;
            dataGridView1.Sort(column, sortDirection);
            column.HeaderCell.SortGlyphDirection = sortDirection == ListSortDirection.Descending ? SortOrder.Descending : SortOrder.Descending;
        }
    }
}
