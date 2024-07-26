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
    public partial class viewReservations : Form
    {
        string Id;
        public viewReservations(string id)
        {
            InitializeComponent();
            Id = id;
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new object[] { "Purchased", "Cancelled"});
            LoadTicketSalesData();
        }
        private void LoadTicketSalesData()
        {
            string connectionString = @"DATA SOURCE=localhost:1521/XE;USER ID=system;PASSWORD=mala";
            string query = "SELECT * FROM ADMIN.ticket_sales WHERE PASSENGER_ID = :userId";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(":userId", OracleDbType.Varchar2).Value = Id;

                        OracleDataAdapter adapter = new OracleDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Filter the DataGridView based on the selected status
            if (comboBox1.SelectedItem != null)
            {
                string selectedStatus = comboBox1.SelectedItem.ToString();
                DataView dv = new DataView((DataTable)dataGridView1.DataSource);
                dv.RowFilter = $"STATUS = '{selectedStatus}'";
                dataGridView1.DataSource = dv.ToTable();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string selectedStatus = comboBox1.SelectedItem.ToString();
                dataGridView1.Sort(dataGridView1.Columns["STATUS"], ListSortDirection.Descending);
            }
        }
    }
}
