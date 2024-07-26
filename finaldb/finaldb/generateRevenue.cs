using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;

namespace finaldb
{
    public partial class generateRevenue : Form
    {
        public generateRevenue()
        {
            InitializeComponent();
        }


        private void generateRevenue_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[] { "Week", "Month" });
            comboBox1.SelectedIndex = 0; 
        }

        private void btnGeneratePDF_Click(object sender, EventArgs e)
        {
            string period = comboBox1.SelectedItem.ToString();
            DateTime startDate;
            DateTime endDate;

            if (period == "Week")
            {
                startDate = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek); 
                endDate = startDate.AddDays(6); 
            }
            else 
            {
                startDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1); 
                endDate = startDate.AddMonths(1).AddDays(-1); 
            }

            string connectionString = @"DATA SOURCE=localhost:1521/XE;USER ID=system;PASSWORD=mala";
            string sqlQuery = "SELECT SUM(ticket_price) AS revenue FROM ADMIN.TICKET_SALES WHERE sale_date BETWEEN :startDate AND :endDate";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand(sqlQuery, connection))
                    {
                        command.Parameters.Add(":startDate", OracleDbType.Date).Value = startDate;
                        command.Parameters.Add(":endDate", OracleDbType.Date).Value = endDate;

                        object result = command.ExecuteScalar();
                        decimal revenue = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                        MessageBox.Show("Revenue: " + revenue.ToString("C"), "Revenue Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string period = comboBox1.SelectedItem.ToString();
            DateTime startDate;
            DateTime endDate;

            if (period == "Week")
            {
                startDate = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);
                endDate = startDate.AddDays(6);
            }
            else
            {
                startDate = dateTimePicker1.Value;
                endDate = startDate.AddMonths(1).AddDays(-1);
            }

            string connectionString = @"DATA SOURCE=localhost:1521/XE;USER ID=system;PASSWORD=mala";
            string sqlQuery = "SELECT SUM(price) AS revenue FROM ADMIN.TICKET_SALES WHERE issue_date BETWEEN :startDate AND :endDate";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand(sqlQuery, connection))
                    {
                        command.Parameters.Add(":startDate", OracleDbType.Date).Value = startDate;
                        command.Parameters.Add(":endDate", OracleDbType.Date).Value = endDate;

                        object result = command.ExecuteScalar();
                        decimal revenue = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                        Document doc = new Document();
                        PdfWriter.GetInstance(doc, new FileStream("revenue_report.pdf", FileMode.Create));
                        doc.Open();
                        doc.Add(new Paragraph($"Revenue: {revenue.ToString("C")}"));
                        doc.Close();

                        MessageBox.Show("PDF report generated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        string pdfPath = Path.Combine(Environment.CurrentDirectory, "revenue_report.pdf");
                        if (File.Exists(pdfPath))
                        {
                            Process.Start(pdfPath);
                        }
                        else
                        {
                            MessageBox.Show("PDF file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
