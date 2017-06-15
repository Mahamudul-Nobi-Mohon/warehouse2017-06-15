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
    public partial class SalesReport : Form
    {
        public SalesReport()
        {
            InitializeComponent();
        }

        public int CompanyID = GetUserLogInfo.Company();
        public int S_AMOUNT = 0;
        private void Sales_Date_Range_On()
        {
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
            buttonSearch.Enabled = true;
        }
        private void Sales_Date_Range_Off()
        {
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            buttonSearch.Enabled = false;
        }
        private void Sales_Invoice_On()
        {
            textBoxInvoice.Enabled = true;
            buttonInvoiceSearch.Enabled = true;
            comboBoxType.Enabled = true;
        }

        private void Sales_Invoice_Off()
        {
            textBoxInvoice.Enabled = false;
            buttonInvoiceSearch.Enabled = false;
            comboBoxType.Enabled = false;
        }
        private void SalesReport_Load_1(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            DateTime today = DateTime.Today;
            dateTimePicker1.Value = today;
            dateTimePicker2.Value = today;

            comboBoxType.Items.Add("Invoice");
            comboBoxType.Items.Add("Challan");
            comboBoxType.SelectedIndex = 0;
            radioButtonDataSales.Checked = true;



        }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PosConString"].ToString());
        private void DataGrid(string date1, string date2)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "SELECT Sales.SalesDate as 'Date', Sales.SalesCustomerName as 'Customer', Sales.SalesNo as 'Code',  Product.Name as 'Name', Product.ID as 'Product_ID', Sales.SalesSalePrice as 'Price', Sales.SalesQuantity as 'Quantity', Sales.SalesProductDiscount as 'Discount', Sales.SalesRemarks as 'Remarks', Sales.SalesTotal as 'Total', (case when Sales.SalesChangeAmount <0 then (Sales.SalesChangeAmount)*(-1) else 0 END) as 'Due_Amount', PaymentType as 'PaymentType' FROM Sales, Product WHERE Product.ID = Sales.SalesProductID AND Sales.SalesDate BETWEEN '" + date1 + "' AND '" + date2 + "' ORDER BY Sales.SalesDate";
            cmd.CommandText = "SELECT Sales.SalesDate as 'Date', Sales.SalesCustomerName as 'Customer', Sales.SalesNo as 'Code', (SELECT SubCategoryName FROM CategorySub WHERE SubCategoryID = Product.SubCategoryID) as 'SubCategoty', Product.Name as 'Name', Product.ID as 'Product_ID', Sales.SalesSalePrice as 'Price', Sales.SalesQuantity as 'Quantity', Sales.SalesProductDiscount as 'Discount', Sales.SalesRemarks as 'Remarks', Sales.SalesTotal as 'Total', (case when Sales.SalesChangeAmount <0 then (Sales.SalesChangeAmount)*(-1) else 0 END) as 'Due_Amount', PaymentType as 'PaymentType' FROM Sales, Product WHERE Product.ID = Sales.SalesProductID AND Sales.SalesDate BETWEEN '" + date1 + "' AND '" + date2 + "' ORDER BY Sales.SalesDate";    // Change
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewSalesReport.DataSource = dt;
            con.Close();
        }

        private void DataGrid2(string date1, string date2, int paymentType)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "SELECT Sales.SalesDate as 'Date', Sales.SalesCustomerName as 'Customer', Sales.SalesNo as 'Code',  Product.Name as 'Name', Product.ID as 'Product_ID', Sales.SalesSalePrice as 'Price', Sales.SalesQuantity as 'Quantity', Sales.SalesProductDiscount as 'Discount', Sales.SalesRemarks as 'Remarks', Sales.SalesTotal as 'Total', (case when Sales.SalesChangeAmount <0 then (Sales.SalesChangeAmount)*(-1) else 0 END) as 'Due_Amount', PaymentType as 'PaymentType' FROM Sales, Product WHERE Product.ID = Sales.SalesProductID AND Sales.SalesDate BETWEEN '" + date1 + "' AND '" + date2 + "' ORDER BY Sales.SalesDate";
            cmd.CommandText = "SELECT Sales.SalesDate as 'Date', Sales.SalesCustomerName as 'Customer', Sales.SalesNo as 'Code', (SELECT SubCategoryName FROM CategorySub WHERE SubCategoryID = Product.SubCategoryID) as 'SubCategoty', Product.Name as 'Name', Product.ID as 'Product_ID', Sales.SalesSalePrice as 'Price', Sales.SalesQuantity as 'Quantity', Sales.SalesProductDiscount as 'Discount', Sales.SalesRemarks as 'Remarks', Sales.SalesTotal as 'Total', (case when Sales.SalesChangeAmount <0 then (Sales.SalesChangeAmount)*(-1) else 0 END) as 'Due_Amount', PaymentType as 'PaymentType' FROM Sales, Product WHERE Product.ID = Sales.SalesProductID AND Sales.SalesDate BETWEEN '" + date1 + "' AND '" + date2 + "' AND Sales.PaymentType = '"+ paymentType + "' ORDER BY Sales.SalesDate";    // Change
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewSalesReport.DataSource = dt;
            con.Close();
        }
        private int SpecialDiscount(string date1, string date2)
        {
            string sdiscount = "Special-Discount";
            int sAmount = 0;
            SqlConnection connection1211 = new SqlConnection(ConfigurationManager.ConnectionStrings["PosConString"].ToString());
            string query1211 = "SELECT * FROM Expense WHERE ExpenseType = '" + sdiscount + "' AND Date BETWEEN '" + date1 + "' AND '" + date2 + "'";
            SqlCommand command11211 = new SqlCommand(query1211, connection1211);
            connection1211.Open();
            SqlDataReader reader1211 = command11211.ExecuteReader();
            while (reader1211.Read())
            {
                sAmount = sAmount + Convert.ToInt32(reader1211["Amount"]);
            }
            reader1211.Close();
            connection1211.Close();
            return sAmount;
        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
            Temp_Sales_Stock_Truncket();
            string date1 = dateTimePicker1.Text;
            string date2 = dateTimePicker2.Text;
            DataGrid(date1, date2);
            Temp_Sales_Stock();
            S_AMOUNT = SpecialDiscount(date1, date2);
            PrintReport();
            }
            else
            {
            Temp_Sales_Stock_Truncket();
            string date1 = dateTimePicker1.Text;
            string date2 = dateTimePicker2.Text;
            int paymentType = comboBox1.SelectedIndex;
            DataGrid2(date1, date2, paymentType);
            Temp_Sales_Stock();
            S_AMOUNT = SpecialDiscount(date1, date2);
            PrintReport();
            }
            
        }

        private void TextboxValue(string ParameterName, int ParameterValue, ParameterField myParameterField, ParameterDiscreteValue myDiscreteValue, ParameterFields myParameterFields)
        {
            myParameterField.ParameterFieldName = ParameterName;
            myDiscreteValue.Value = ParameterValue;
            myParameterField.CurrentValues.Add(myDiscreteValue);
            myParameterFields.Add(myParameterField);
        }

        private void Temp_Sales_Stock()
        {
            foreach (DataGridViewRow row in dataGridViewSalesReport.Rows)
            {
                //string constring = @"SERVER = Kamrul-pc; DATABASE =pos; user id = sa; PASSWORD = 123";
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PosConString"].ToString()))
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO TempSalesStock VALUES('"+ CompanyID + "',@Date,@Code,@SubCategoty, @Name,@Product_ID,@Price,@Quantity,@Discount,@Due_Amount,@Total,@Customer,@Remarks,'" + dateTimePicker1.Text+ "','" + dateTimePicker2.Text + "', @PaymentType)", con))
                    {
                        cmd.Parameters.AddWithValue("@Date", row.Cells["Date"].Value); 
                        cmd.Parameters.AddWithValue("@Code", row.Cells["Code"].Value); 
                        cmd.Parameters.AddWithValue("@SubCategoty", row.Cells["SubCategoty"].Value);
                        cmd.Parameters.AddWithValue("@Name", row.Cells["Name"].Value);
                        cmd.Parameters.AddWithValue("@Product_ID", row.Cells["Product_ID"].Value);
                        cmd.Parameters.AddWithValue("@Price", row.Cells["Price"].Value);
                        cmd.Parameters.AddWithValue("@Quantity", row.Cells["Quantity"].Value);
                        cmd.Parameters.AddWithValue("@Discount", row.Cells["Discount"].Value);
                        cmd.Parameters.AddWithValue("@Due_Amount", row.Cells["Due_Amount"].Value);
                        cmd.Parameters.AddWithValue("@Total", row.Cells["Total"].Value);
                        cmd.Parameters.AddWithValue("@Customer", row.Cells["Customer"].Value);
                        cmd.Parameters.AddWithValue("@Remarks", row.Cells["Remarks"].Value);
                        cmd.Parameters.AddWithValue("@PaymentType", row.Cells["PaymentType"].Value);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
            // MessageBox.Show("Records inserted.");
        }
        private void Temp_Sales_Stock_Truncket()
        {
            con.Open();
            string sql = @"DELETE FROM TempSalesStock WHERE CompanyID='" + CompanyID + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            }
        public string ReportPaths = ReportPath.rPath;
        ReportDocument cryRpt = new ReportDocument();
        private void PrintReport()
        {
            cryRpt.Dispose();
            cryRpt.Close();

            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();

            ParameterFields myParameterFields = new ParameterFields();

            ParameterField myParameterField1 = new ParameterField();
            ParameterField myParameterField2 = new ParameterField();
            ParameterDiscreteValue myDiscreteValue1 = new ParameterDiscreteValue();
            ParameterDiscreteValue myDiscreteValue2 = new ParameterDiscreteValue();

            string rPath = ReportPaths + "CrystalReportSalesStockReport.rpt";
            cryRpt.Load(rPath);
            //cryRpt.Load(rPath);
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

            TextboxValue("SAmount", S_AMOUNT, myParameterField1, myDiscreteValue1, myParameterFields);
            TextboxValue("ComID", CompanyID, myParameterField2, myDiscreteValue2, myParameterFields);

            crystalReportViewer1.ParameterFieldInfo = myParameterFields;
            crystalReportViewer1.Refresh();
            crystalReportViewer1.ReportSource = cryRpt;
           
        }
       
        private void radioButtonDataSales_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDataSales.Checked == true)
            {
                Sales_Date_Range_On();
                Sales_Invoice_Off();

            }
            
        }

        private void radioButtonInvoice_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonInvoice.Checked == true)
            {
                Sales_Date_Range_Off();
                Sales_Invoice_On();


            }
        }
       
        private void DataGrid(string InvoiceNo)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Sales.SalesNo as 'SalesNo', Sales.SalesDate as 'SalesDate', Sales.SalesTime as 'SalesTime', Sales.SalesCustomerID as 'SalesCustomerID', Sales.SalesRemarks as 'SalesRemarks', Sales.Reference as 'Reference', Sales.SalesProductID as 'SalesProductID', Sales.SalesPurchasePrice as 'SalesPurchasePrice', Sales.SalesSalePrice as 'SalesSalePrice', Sales.SalesQuantity as 'SalesQuantity', Sales.SalesProductDiscount as 'SalesProductDiscount', Sales.SalesTotal as 'SalesTotal',Sales.SalesCustomerName as 'SalesCustomerName',Sales.SalesSoldBy as 'SalesSoldBy',Sales.SalesReceivedAmount as 'SalesReceivedAmount',Sales.SalesChangeAmount as 'SalesChangeAmount',Sales.SalesVatRate as 'SalesVatRate',Sales.SalesVatTotal as 'SalesVatTotal', Sales.SalesPuechaseBy as 'SalesPuechaseBy', Sales.SalesPurchaseByContact as 'SalesPurchaseByContact', Sales.PaymentType as 'PaymentType' FROM Sales WHERE Sales.SalesNo = '" + InvoiceNo + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewInvoice.DataSource = dt;
            con.Close();
        }
        private void Temp_Invoice_Sales_Report_Truncket()
        {
            con.Open();
            string sql = @"DELETE FROM TempInvoiceSalesReport WHERE CompanyID='" + CompanyID + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void TempSales_Truncket()
        {
            con.Open();
            string sql = @"DELETE FROM TempSales WHERE TempSalesCompanyID='" + CompanyID + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void Temp_Invoice_Sales_Stock()
        {
            TempSales_Truncket();

            foreach (DataGridViewRow row in dataGridViewInvoice.Rows)
            {
                //string constring = @"SERVER = Kamrul-pc; DATABASE =pos; user id = sa; PASSWORD = 123";
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PosConString"].ToString()))
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO TempSales VALUES('"+ CompanyID + "',@SalesNo, @SalesDate,@SalesTime,@SalesCustomerID,@SalesRemarks,@Reference,@SalesProductID,@SalesPurchasePrice,@SalesSalePrice,@SalesQuantity,@SalesProductDiscount,@SalesTotal,@SalesCustomerName,@SalesSoldBy,@SalesReceivedAmount,@SalesChangeAmount,@SalesVatRate,@SalesVatTotal,0,@SalesPuechaseBy,@SalesPurchaseByContact, @PaymentType)", con))
                    {
                       
                        cmd.Parameters.AddWithValue("@SalesNo", row.Cells["SalesNo"].Value);
                        cmd.Parameters.AddWithValue("@SalesDate", row.Cells["SalesDate"].Value);
                        cmd.Parameters.AddWithValue("@SalesTime", row.Cells["SalesTime"].Value);
                        cmd.Parameters.AddWithValue("@SalesCustomerID", row.Cells["SalesCustomerID"].Value);
                        cmd.Parameters.AddWithValue("@SalesRemarks", row.Cells["SalesRemarks"].Value);
                        cmd.Parameters.AddWithValue("@Reference", row.Cells["Reference"].Value);
                        cmd.Parameters.AddWithValue("@SalesProductID", row.Cells["SalesProductID"].Value);
                        cmd.Parameters.AddWithValue("@SalesPurchasePrice", row.Cells["SalesPurchasePrice"].Value);
                        cmd.Parameters.AddWithValue("@SalesSalePrice", row.Cells["SalesSalePrice"].Value);
                        cmd.Parameters.AddWithValue("@SalesQuantity", row.Cells["SalesQuantity"].Value);
                        cmd.Parameters.AddWithValue("@SalesProductDiscount", row.Cells["SalesProductDiscount"].Value);
                        cmd.Parameters.AddWithValue("@SalesTotal", row.Cells["SalesTotal"].Value);
                        cmd.Parameters.AddWithValue("@SalesCustomerName", row.Cells["SalesCustomerName"].Value);
                        cmd.Parameters.AddWithValue("@SalesSoldBy", row.Cells["SalesSoldBy"].Value);
                        cmd.Parameters.AddWithValue("@SalesReceivedAmount", row.Cells["SalesReceivedAmount"].Value);
                        cmd.Parameters.AddWithValue("@SalesChangeAmount", row.Cells["SalesChangeAmount"].Value);
                        cmd.Parameters.AddWithValue("@SalesVatRate", row.Cells["SalesVatRate"].Value);
                        cmd.Parameters.AddWithValue("@SalesVatTotal", row.Cells["SalesVatTotal"].Value);
                        cmd.Parameters.AddWithValue("@SalesPuechaseBy", row.Cells["SalesPuechaseBy"].Value);
                        cmd.Parameters.AddWithValue("@SalesPurchaseByContact", row.Cells["SalesPurchaseByContact"].Value);
                        cmd.Parameters.AddWithValue("@PaymentType", row.Cells["PaymentType"].Value);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
            // MessageBox.Show("Records inserted.");
        }
        private void Insert_Temp_Sales_Amount()
        {
            
            int CustomerID = 1;
            int TotalVat = 0;
            double NetPayable = 0;
            double CashPaid = 0;
            double ReturnAmount = 0;
            double DueAmount = 0;
            string CurrentUserSales = "";
            string Remarks = "";
            double TempSalesTotal = 0;
            double TempSalesProductDiscount = 0;
            double VatRate = 0;
            string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
            SqlConnection connection = new SqlConnection(conStr);
            string query = "SELECT * FROM TempSales";
            SqlCommand command1 = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command1.ExecuteReader();
            while (reader.Read())
            {
                CashPaid =   Convert.ToDouble(reader["TempSalesReceivedAmount"]);
                ReturnAmount = Convert.ToDouble(reader["TempSalesChangeAmount"]);
                DueAmount= Convert.ToDouble(reader["TempSalesVatTotal"])- Convert.ToDouble(reader["TempSalesReceivedAmount"]);
                Remarks = reader["TempSalesRemarks"].ToString();
                TempSalesTotal = TempSalesTotal+ Convert.ToDouble(reader["TempSalesTotal"]);
                TempSalesProductDiscount= Convert.ToDouble(reader["TempSalesProductDiscount"]);
                VatRate= Convert.ToDouble(reader["TempSalesVatRate"]);

            }
            reader.Close();
            connection.Close();

            TotalVat = (int)Math.Ceiling((((TempSalesTotal + TempSalesProductDiscount) * VatRate) / 100));

            con.Open();
            string sql = @"DELETE FROM TempSalesAmount WHERE CompanyID = '"+ CompanyID+ "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();

            SqlConnection con1 = new SqlConnection(conStr);
            con1.Open();
            string sql1 = @"INSERT INTO TempSalesAmount(CompanyID, CustomerID, TotalVat, NetPayable, CashPaid, ReturnAmount, DueAmount,CurrentUserSales,Remarks) VALUES('" + CompanyID + "','" + CustomerID + "','" + TotalVat + "','" + NetPayable + "','" + CashPaid + "','" + ReturnAmount + "','" + DueAmount + "','" + CurrentUserSales + "','" + Remarks + "')";
            SqlCommand cmd1 = new SqlCommand(sql1, con1);
            cmd1.ExecuteNonQuery();
            con1.Close();

        }
       

        private void PrintReport_Invoice()
        {

           // ReportDocument cryRpt = new ReportDocument();
            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();

            ParameterFields myParameterFields = new ParameterFields();

            ParameterField myParameterField1 = new ParameterField();
            ParameterDiscreteValue myDiscreteValue1 = new ParameterDiscreteValue();


            string rPath = ReportPaths + "CrystalReportSalesReportInvoiceA4.rpt";
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

            TextboxValue("CompanyID", CompanyID, myParameterField1, myDiscreteValue1, myParameterFields);

            crystalReportViewer1.ParameterFieldInfo = myParameterFields;
            crystalReportViewer1.Refresh();
            crystalReportViewer1.ReportSource = cryRpt;


        }
        private void PrintReport_Challan()
        {
           // ReportDocument cryRpt = new ReportDocument();
            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();

            ParameterFields myParameterFields = new ParameterFields();

            ParameterField myParameterField1 = new ParameterField();
            ParameterDiscreteValue myDiscreteValue1 = new ParameterDiscreteValue();


            string rPath = ReportPaths + "CrystalReportSalesInvoiceChallanA4.rpt";
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

            TextboxValue("CompanyID", CompanyID, myParameterField1, myDiscreteValue1, myParameterFields);

            crystalReportViewer1.ParameterFieldInfo = myParameterFields;
            crystalReportViewer1.Refresh();
            crystalReportViewer1.ReportSource = cryRpt;


        }
        private void buttonInvoiceSearch_Click(object sender, EventArgs e)
        {
            string InvoiceNo = textBoxInvoice.Text;

            DataGrid(InvoiceNo);
            Temp_Invoice_Sales_Report_Truncket();
            Temp_Invoice_Sales_Stock();
            Insert_Temp_Sales_Amount();
            if (comboBoxType.Text== "Invoice")
            {
                PrintReport_Invoice();
            }
            if (comboBoxType.Text == "Challan")
            {
                PrintReport_Challan();
            }
           

        }

        private void SalesReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            //con.Open();
            //string sql = @"DELETE FROM TempSales WHERE TempSalesCompanyID='" + CompanyID + "'";
            //sql += @"DELETE FROM TempSalesAmount WHERE CompanyID = '" + CompanyID + "'";
            //SqlCommand cmd = new SqlCommand(sql, con);
            //cmd.ExecuteNonQuery();
            //con.Close();
            //crystalReportViewer1.ReportSource = null;
            //crystalReportViewer1.RefreshReport();
        }
    }
}
