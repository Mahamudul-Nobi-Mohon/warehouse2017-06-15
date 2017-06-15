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
using System.Windows.Forms;

namespace WMS
{
    public partial class DamageProductReceiveReport : Form
    {
        public DamageProductReceiveReport()
        {
            InitializeComponent();
        }

        private void DamageProductReceiveReport_Load(object sender, EventArgs e)
        {
            dateTimePickerStartDate.CustomFormat = "yyyy-MM-dd";
            dateTimePickerEndDate.CustomFormat = "yyyy-MM-dd";
            DateTime date = DateTime.Today;
            dateTimePickerStartDate.Value = date;
            dateTimePickerEndDate.Value = date;
        }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PosConString"].ToString());
        private void DataGrid(string date1, string date2)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DamageProductReceive.DamageProductDate as 'Date', DamageProductReceive.DamageProductNo as 'DamageProductNo', DamageProductReceive.InvoiceNo as 'InvoiceNo', DamageProductReceive.DamageProductProductID as 'ProductID', Product.Name as 'ProductName', DamageProductReceive.DamageProductPrice as 'Price', DamageProductReceive.DamageProductQuantity as 'Quantity', DamageProductReceive.DamageProductTotal as 'Total' FROM DamageProductReceive, Product WHERE DamageProductReceive.DamageProductProductID = Product.ID AND DamageProductReceive.DamageProductDate BETWEEN '" + date1 + "' AND '" + date2 + "' ORDER BY DamageProductReceive.DamageProductDate";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewDamageProductReceiveReport.DataSource = dt;
            con.Close();
        }
    
    private void TempDamageProductReceiveReport_Stock()
    {
        foreach (DataGridViewRow row in dataGridViewDamageProductReceiveReport.Rows)
        {
            //string constring = @"SERVER = Kamrul-pc; DATABASE =pos; user id = sa; PASSWORD = 123";
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PosConString"].ToString()))
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO TempDamageProductReceiveReport VALUES('" + dateTimePickerStartDate.Text + "','" + dateTimePickerEndDate.Text + "',@DamageProductNo,@Date,@InvoiceNo,@ProductName,@Price,@Quantity,@Total)", con))
                {
                    
                    cmd.Parameters.AddWithValue("@DamageProductNo", row.Cells["DamageProductNo"].Value);
                    cmd.Parameters.AddWithValue("@Date", row.Cells["Date"].Value);
                    cmd.Parameters.AddWithValue("@InvoiceNo", row.Cells["InvoiceNo"].Value);
                    cmd.Parameters.AddWithValue("@ProductName", row.Cells["ProductName"].Value);
                    cmd.Parameters.AddWithValue("@Price", row.Cells["Price"].Value);
                    cmd.Parameters.AddWithValue("@Quantity", row.Cells["Quantity"].Value);
                    cmd.Parameters.AddWithValue("@Total", row.Cells["Total"].Value);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
        // MessageBox.Show("Records inserted.");
    }
    public string ReportPaths = ReportPath.rPath;
        private void PrintReport()
        {
            TempDamageProductReceiveReport_Truncket();
            TempDamageProductReceiveReport_Stock();
            ReportDocument cryRpt = new ReportDocument();
            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            //string rPath = @"C:\Reports\CrystalReportPurchaseReturnReport.rpt";
            string rPath = ReportPaths + "CrystalReportDamageProductReceiveReport.rpt";
            cryRpt.Load(rPath);
            crConnectionInfo.ServerName = ConfigurationManager.ConnectionStrings["cryServer"].ToString();
            crConnectionInfo.DatabaseName = ConfigurationManager.ConnectionStrings["cryDatabase"].ToString();
            crConnectionInfo.UserID = ConfigurationManager.ConnectionStrings["cryUserID"].ToString();
            crConnectionInfo.Password = ConfigurationManager.ConnectionStrings["cryPass"].ToString();

            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in cryRpt.Database.Tables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }

            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.RefreshReport();
        }
        private void TempDamageProductReceiveReport_Truncket()
        {
            con.Open();
            string sql = @"TRUNCATE TABLE TempDamageProductReceiveReport";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {

            string date1 = dateTimePickerStartDate.Text;
            string date2 = dateTimePickerEndDate.Text;
            DataGrid(date1, date2);
            PrintReport();
        }
    }
}
