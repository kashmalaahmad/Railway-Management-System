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
    public partial class handleCustomerAffairs : Form
    {
        public handleCustomerAffairs()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string connectionString = @"DATA SOURCE=localhost:1521/XE;USER ID=system;PASSWORD=mala";
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();
                try
                {
                    
                    string sql = @"
            SELECT I.IssueType, I.IssueDescription, P.PassengerID, P.PassengerName 
            FROM ISSUES I 
            INNER JOIN Passengers P ON I.PassengerID = P.PassengerID
            WHERE I.IssueType = :issueType";

                    using (OracleCommand command = new OracleCommand(sql, connection))
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

                connection.Close();
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string connectionString = @"DATA SOURCE=localhost:1521/XE;USER ID=system;PASSWORD=mala";
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();
                try
                {
                    string sql = @"
            SELECT C.ComplaintType, C.ComplaintDescription, P.PassengerID, P.PassengerName 
            FROM COMPLAINTS C
            INNER JOIN Passengers P ON C.PassengerID = P.PassengerID
            WHERE C.ComplaintType = :complaintType";

                    using (OracleCommand command = new OracleCommand(sql, connection))
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

                connection.Close();
            }

        }
    }
}
