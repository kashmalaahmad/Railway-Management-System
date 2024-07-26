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
    public partial class customerService : Form
    {
        string ID;
        public customerService(string id)
        {
            InitializeComponent();
            ID = id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reportComplaint obj = new reportComplaint(ID);
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            giveFeedback obj = new giveFeedback(ID);
            obj.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            requestAssistance obj = new requestAssistance();
            obj.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
