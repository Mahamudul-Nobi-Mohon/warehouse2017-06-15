using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WMS
{
    public partial class StockReport : Form
    {
        public StockReport()
        {
            InitializeComponent();
        }

        ReportDocument cryRpt = new ReportDocument();
        public string ReportPaths = ReportPath.rPath;
        private void StockReport_Load(object sender, EventArgs e)
        {
            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            string rPath = ReportPaths + "rpt_StockReport.rpt";
            cryRpt.Load(rPath);
            crConnectionInfo.ServerName = ConfigurationManager.ConnectionStrings["cryServer"].ToString();
            crConnectionInfo.DatabaseName = ConfigurationManager.ConnectionStrings["cryDatabase"].ToString();
            crConnectionInfo.UserID = ConfigurationManager.ConnectionStrings["cryUserID"].ToString();
            crConnectionInfo.Password = ConfigurationManager.ConnectionStrings["cryPass"].ToString();
            foreach (Table CrTable in cryRpt.Database.Tables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.RefreshReport();
        }

        private void StockReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            cryRpt.Close();
            cryRpt.Dispose();
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.Dispose();
            crystalReportViewer1 = null;
        }
    }
}
