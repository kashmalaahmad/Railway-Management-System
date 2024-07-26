using finaldb.Properties;
using finaldb.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Expando;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finaldb
{
    public partial class Form2 : Form
    {
        string adminid;
        private bool isCollapsed;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string id)
        {
            InitializeComponent();
             adminid = id;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(isCollapsed)
            {
                button2.Image = Image.FromFile(@"C:\Users\Mala\Downloads\icons8-collapse-arrow-20.png");
                panel1.Height += 10;
                if(panel1.Size==panel1.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                button2.Image = Image.FromFile(@"C:\Users\Mala\Desktop\dbcheckp\finaldb\finaldb\Resources\icons8-expand-arrow-20.png");
                panel1.Height -= 10;
                if (panel1.Size == panel1.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                button3.Image = Image.FromFile(@"C:\Users\Mala\Desktop\dbcheckp\finaldb\finaldb\Resources\icons8-expand-arrow-20.png");
                panel2.Height += 10;
                panel2.Height += 10;
                if (panel2.Size == panel2.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                button3.Image = Image.FromFile(@"C:\Users\Mala\Desktop\dbcheckp\finaldb\finaldb\Resources\icons8-expand-arrow-20.png");
                panel2.Height += 10;
                panel2.Height -= 10;
                if (panel2.Size == panel2.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            viewEmployee obj=new viewEmployee();
            obj.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            deleteemployees obj=new deleteemployees();
            obj.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            addemployee obj = new addemployee();
            obj.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            viewSchedule obj=new viewSchedule();
            obj.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            deleteSchedule obj=new deleteSchedule();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewAdmin obj=new ViewAdmin(adminid);
            obj.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ViewTrains obj=new ViewTrains();
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            generateRevenue obj=new generateRevenue();
            obj.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            viewFeedback obj=new viewFeedback();
            obj.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            assigntask obj = new assigntask();
            obj.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            updateEmployee obj = new updateEmployee();
            obj.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            AddSchedule obj = new AddSchedule();
            obj.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            updateSchedule obj = new updateSchedule();
            obj.Show();
        }
    }
}
