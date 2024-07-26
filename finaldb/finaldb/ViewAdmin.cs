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

namespace finaldb
{
    public partial class ViewAdmin : Form
    {
        string adminid;
        public ViewAdmin()
        {
            InitializeComponent();
        }
        public ViewAdmin(string id)
        {
            InitializeComponent();
            adminid = id;
            DisplayAdminInformation();
        }
        private void DisplayAdminInformation()
        {
            string connectionString = @"DATA SOURCE=localhost:1521/XE;USER ID=system;PASSWORD=mala";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string sqlQuery = "SELECT * FROM ADMIN.ADMIN_TABLE WHERE admin_id = :adminID";

                    using (OracleCommand command = new OracleCommand(sqlQuery, connection))
                    {
                        command.Parameters.Add(":adminID", OracleDbType.Varchar2).Value = adminid;

                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Retrieve admin information from the database
                                string adminName = reader["ADMIN_NAME"].ToString();
                                string adminRole = reader["ADMIN_ROLE"].ToString();
                                int adminLevel = Convert.ToInt32(reader["ADMIN_LEVEL"]);
                                string adminPreviliges = reader["ADMIN_PREVILIGIES"].ToString();
                                string cnic = reader["CNIC"].ToString();
                                string email = reader["EMAIL"].ToString();

                                // Create labels to display the retrieved information
                                Label nameLabel = new Label();
                                nameLabel.Text = $"Admin Name: {adminName}";
                                nameLabel.AutoSize = true;
                                nameLabel.Location = new Point(10, 10);
                                panel1.Controls.Add(nameLabel);

                                Label roleLabel = new Label();
                                roleLabel.Text = $"Admin Role: {adminRole}";
                                roleLabel.AutoSize = true;
                                roleLabel.Location = new Point(10, 30); 
                                panel1.Controls.Add(roleLabel);

                                Label levelLabel = new Label();
                                levelLabel.Text = $"Admin Level: {adminLevel}";
                                levelLabel.AutoSize = true;
                                levelLabel.Location = new Point(10, 50); 
                                panel1.Controls.Add(levelLabel);

                                Label privilegesLabel = new Label();
                                privilegesLabel.Text = $"Admin Previleges: {adminPreviliges}";
                                privilegesLabel.AutoSize = true;
                                privilegesLabel.Location = new Point(10, 70);
                                panel1.Controls.Add(privilegesLabel);

                                Label cnicLabel = new Label();
                                cnicLabel.Text = $"CNIC: {cnic}";
                                cnicLabel.AutoSize = true;
                                cnicLabel.Location = new Point(10, 90); 
                                panel1.Controls.Add(cnicLabel);

                                Label emailLabel = new Label();
                                emailLabel.Text = $"Email: {email}";
                                emailLabel.AutoSize = true;
                                emailLabel.Location = new Point(10, 110); 
                                panel1.Controls.Add(emailLabel);
                            }
                            else
                            {
                                MessageBox.Show("Admin not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
