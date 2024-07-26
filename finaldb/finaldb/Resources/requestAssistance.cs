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
    public partial class requestAssistance : Form
    {
        public requestAssistance()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] words = comboBox1.Text.Split(' ');
            string issue = words.FirstOrDefault();
          
            switch (issue)
            {
                case "Billing":
                    string billingDescription = "For assistance with billing-related issues, please contact our billing department at billing@example.com.";
                    panel1.Controls.Clear();
                    Label billingLabel = new Label();
                    billingLabel.Text = billingDescription;
                    billingLabel.Dock = DockStyle.Fill;
                    panel1.Controls.Add(billingLabel);
                    break;
                case "Technical":
                    string technicalDescription = "For technical support, please contact our technical team at support@example.com.";
                    panel1.Controls.Clear();
                    Label technicalLabel = new Label();
                    technicalLabel.Text = technicalDescription;
                    technicalLabel.Dock = DockStyle.Fill;
                    panel1.Controls.Add(technicalLabel);
                    break;
                case "Account":
                    string accountDescription = "If you are having trouble accessing your account, please reset your password using the 'Forgot Password' link on the login page.";
                    panel1.Controls.Clear();
                    Label accountLabel = new Label();
                    accountLabel.Text = accountDescription;
                    accountLabel.Dock = DockStyle.Fill;
                    panel1.Controls.Add(accountLabel);
                    break;
                default:
                    string defaultDescription = "For further info, please contact us at support@example.com.";
                    panel1.Controls.Clear();
                    Label defaultLabel = new Label();
                    defaultLabel.Text = defaultDescription;
                    defaultLabel.Dock = DockStyle.Fill;
                    panel1.Controls.Add(defaultLabel);
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label5.Text = comboBox1.Text;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
