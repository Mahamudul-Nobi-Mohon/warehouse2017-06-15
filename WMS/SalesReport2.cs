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
    public partial class SalesReport2 : Form
    {

        ReportDocument cryRpt = new ReportDocument();
        public SalesReport2()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PosConString"].ToString());

        public string ReportPaths = ReportPath.rPath;

        private DataTable GetData()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PosConString"].ToString()))
            {
                using (SqlCommand cmd = new SqlCommand("sales_report", con))
                {
                    con.Open();

                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    
                    cmd.Parameters.AddWithValue("@SalesNo", comboBoxInvoiceNo.Text);
                   
                    SqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);

                }
            }

            return dt;
        }

        private void ShowReport(DataTable dtReportData)
        {
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            
          //  crConnectionInfo.ServerName = ConfigurationManager.ConnectionStrings["cryServer"].ToString();
          //  crConnectionInfo.DatabaseName = ConfigurationManager.ConnectionStrings["cryDatabase"].ToString();
          //  crConnectionInfo.UserID = ConfigurationManager.ConnectionStrings["cryUserID"].ToString();
          //  crConnectionInfo.Password = ConfigurationManager.ConnectionStrings["cryPass"].ToString();

          //   ReportDocument rdoc = new ReportDocument();
          //  // rdoc.SetDatabaseLogon("sa", "123");

          //  rdoc.Load(ReportPaths + "rpt_SalesReport.rpt");
          //  rdoc.SetDatabaseLogon(crConnectionInfo.UserID, crConnectionInfo.Password, crConnectionInfo.ServerName, crConnectionInfo.DatabaseName, false);
          //  rdoc.SetDataSource(dtReportData);
            
          ////  rdoc.SetDatabaseLogon("sa", "123", servername, "WAREHOUSE");
           
          //  crystalReportViewer1.ReportSource = rdoc;
          //  crystalReportViewer1.RefreshReport();

            

            ReportDocument cryRpt = new ReportDocument();
            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
          //  ConnectionInfo crConnectionInfo = new ConnectionInfo();
            Tables CrTables;
            cryRpt.Load(ReportPaths + "rpt_SalesReport.rpt");
            crConnectionInfo.ServerName = ConfigurationManager.ConnectionStrings["cryServer"].ToString();
            crConnectionInfo.DatabaseName = ConfigurationManager.ConnectionStrings["cryDatabase"].ToString();
            crConnectionInfo.UserID = ConfigurationManager.ConnectionStrings["cryUserID"].ToString();
            crConnectionInfo.Password = ConfigurationManager.ConnectionStrings["cryPass"].ToString();

            CrTables = cryRpt.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }
            cryRpt.SetDataSource(dtReportData);
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }
        private void buttonSearch_Click(object sender, EventArgs e)
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
                    //con.Open();
                    //SqlCommand cmd = new SqlCommand("exec sp_PurchaseReport '" + comboBoxInvoiceNo.Text + "'", con);
                    //SqlDataReader rdr = cmd.ExecuteReader();
                    //DataTable dtt = new DataTable();
                    //dtt.Load(rdr);
                    //ReportDocument cryRpt = new ReportDocument();
                    //string rPath = ReportPaths + "rpt_PurchaseReport.rpt";
                    //cryRpt.Load(rPath);
                    //cryRpt.SetDataSource(dtt);
                    //crystalReportViewer1.ReportSource = cryRpt;
                    //crystalReportViewer1.RefreshReport();
                    //con.Close();


                  
                    DataTable dtReportData = GetData();
                    ShowReport(dtReportData);




                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SalesReport2_FormClosed(object sender, FormClosedEventArgs e)
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
            string query = "SELECT DISTINCT(SalesNo) FROM Sales WHERE SalesDate  BETWEEN '" + date1 + "' AND '" + date2 + "'";
            fillCombo(comboBoxInvoiceNo, query, "SalesNo", "SalesNo");

        }

       
        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            string date1 = dateTimePicker1.Text;
            string date2 = dateTimePicker2.Text;
            string query = "SELECT DISTINCT(SalesNo) FROM Sales WHERE SalesDate  BETWEEN '" + date1 + "' AND '" + date2 + "'";
            fillCombo(comboBoxInvoiceNo, query, "SalesNo", "SalesNo");
        }

        private void SalesReport2_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            DateTime today = DateTime.Today;
            dateTimePicker1.Value = today;
            dateTimePicker2.Value = today;
        }

      
    }
}
