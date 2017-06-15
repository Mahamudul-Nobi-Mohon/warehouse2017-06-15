using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMS
{
    public partial class PurchaseReport : Form
    {
       
        ReportDocument cryRpt = new ReportDocument();
        public PurchaseReport()
        {
            InitializeComponent();           
        }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PosConString"].ToString());

        public string ReportPaths = ReportPath.rPath;
        private void PurchaseReport_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            DateTime today = DateTime.Today;
            dateTimePicker1.Value = today;
            dateTimePicker2.Value = today;
        }
        private void buttonSearch_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxInvoiceNo.Text == "")
                {
                    MessageBox.Show("Please Fill Invoice No....!!!");
                    return;
                }

                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("exec sp_PurchaseReport '" + comboBoxInvoiceNo.Text + "'", con);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    DataTable dtt = new DataTable();
                    dtt.Load(rdr);
                    ReportDocument cryRpt = new ReportDocument();
                    string rPath = ReportPaths + "rpt_PurchaseReport.rpt";
                    cryRpt.Load(rPath);
                    cryRpt.SetDataSource(dtt);
                    crystalReportViewer1.ReportSource = cryRpt;
                    crystalReportViewer1.RefreshReport();
                    con.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void PurchaseReport_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            cryRpt.Close();
            cryRpt.Dispose();
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.Dispose();
            crystalReportViewer1 = null;
        }
        SqlCommand command;
        SqlDataAdapter adapter;
        DataTable table;
        public void fillCombo(ComboBox combo, string query, string displayMember, string valueMember)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PosConString"].ToString());
            command = new SqlCommand(query, con);
            adapter = new SqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            combo.DataSource = table;
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;

        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            string date1 = dateTimePicker1.Text;
            string date2 = dateTimePicker2.Text;
            string query = "SELECT DISTINCT(PurchaseNo) FROM Purchase WHERE PurchaseDate  BETWEEN '" + date1 + "' AND '" + date2 + "'";
            fillCombo(comboBoxInvoiceNo, query, "PurchaseNo", "PurchaseNo");

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string date1 = dateTimePicker1.Text;
            string date2 = dateTimePicker2.Text;
            string query = "SELECT DISTINCT(PurchaseNo) FROM Purchase WHERE PurchaseDate  BETWEEN '" + date1 + "' AND '" + date2 + "'";
            fillCombo(comboBoxInvoiceNo, query, "PurchaseNo", "PurchaseNo");
        }
    }
}
