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
    public partial class SalesReturn : Form
    {
        public SalesReturn()
        {
            InitializeComponent();
            textBoxQuantity.KeyPress += new KeyPressEventHandler(textBoxQuantity_KeyPress);
            labelInvoiceNo.Text = "Products Against Invoice No : ";
        }
        public string currentuser = Login.loguser;
        public int CompanyID = GetUserLogInfo.Company();
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PosConString"].ToString());
        private void DataGrid(string InvoiceNo)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT SalesID as 'Sales ID', SalesProductID as 'Product ID', Name as Name, SalesQuantity as Quantity,(SELECT LocationMainName FROM LocationMain WHERE LocationMainID = WareHouseID) as WareHouse, (SELECT LocationName FROM Location WHERE LocationMainID = WareHouseID AND LocationID = FloorID) as FloorID  FROM Product, Sales WHERE SalesNo = '" + InvoiceNo + "' AND Sales.SalesProductID = Product.ID ORDER BY Sales.SalesID ASC";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewSalesReturn.DataSource = dt;
            con.Close();
        }
        int CustID = 0;
        private void CustomerInfo(string InvoiceNo)
        {
            string querypd = "SELECT SalesCustomerID FROM Sales WHERE SalesNo = '" + InvoiceNo + "'";
            SqlCommand commandpd = new SqlCommand(querypd, con11);
            con11.Open();
            SqlDataReader reader = commandpd.ExecuteReader();
            
            while (reader.Read())
            {
                CustID = Convert.ToInt32(reader["SalesCustomerID"]);
            }
            reader.Close();
            con11.Close();

            //Fill Customer Info
            textBoxCustomerName.Text = textBoxGroupName.Text = textBoxCompanyAddress.Text = "";
            querypd = "SELECT CustomerID,CustomerName,GroupName,Address FROM Customer WHERE CustomerID = '" + CustID + "'";
            commandpd = new SqlCommand(querypd, con11);
            con11.Open();
            reader = commandpd.ExecuteReader();
            while (reader.Read())
            {
                textBoxCustomerName.Text = reader["CustomerName"].ToString();
                textBoxGroupName.Text = reader["GroupName"].ToString();
                textBoxCompanyAddress.Text = reader["Address"].ToString();
                textBoxCustomerID.Text = reader["CustomerID"].ToString();
            }
            reader.Close();
            con11.Close();


        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string InvoiceNo = textBoxInvoiceNo.Text;
            textBoxInvoiceNoHidden.Text = textBoxInvoiceNo.Text;
            DataGrid(InvoiceNo);
            labelInvoiceNo.Text = "Products Against Invoice No : " + InvoiceNo;
            CustomerInfo(InvoiceNo);
        }
        private void Auto_Complete()
        {
            //Auto Complete search
            textBoxInvoiceNo.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxInvoiceNo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
            SqlConnection conSS = new SqlConnection(conStr);
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            col.Clear();
            conSS.Open();
            string sql = "SELECT DISTINCT(SalesNo) FROM Sales";
            SqlCommand cmd = new SqlCommand(sql, conSS);
            SqlDataReader sdr = null;
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                col.Add(sdr["SalesNo"].ToString());
            }
            sdr.Close();
            textBoxInvoiceNo.AutoCompleteCustomSource = col;
            conSS.Close();
        }
        private void SalesReturn_Load(object sender, EventArgs e)
        {
            Auto_Complete();
            DateTime now = DateTime.Now;
            textBoxDate.Text = now.ToString("yyyy-MM-dd");
        }
        private void Clear_all()
        {
            textBoxName.Text = "";

            textBoxQuantity.Text = "";
            textBoxProductID.Text = "";
            textBoxReturnQuantity.Text = "";
            textBoxNewQuantity.Text = "";
        }
        private void dataGridViewSalesReturn_DoubleClick(object sender, EventArgs e)
        {
            Clear_all();
            textBoxSalesId.Text = dataGridViewSalesReturn.SelectedRows[0].Cells[0].Value.ToString();
            textBoxProductID.Text = dataGridViewSalesReturn.SelectedRows[0].Cells[1].Value.ToString();
            textBoxName.Text = dataGridViewSalesReturn.SelectedRows[0].Cells[2].Value.ToString();
            textBoxQuantity.Text = dataGridViewSalesReturn.SelectedRows[0].Cells[3].Value.ToString();
            textBoxWarehouse.Text = dataGridViewSalesReturn.SelectedRows[0].Cells[4].Value.ToString();
            textBoxFloor.Text = dataGridViewSalesReturn.SelectedRows[0].Cells[5].Value.ToString();
            // textBoxAdjustment.Text = dataGridViewSalesReturn.SelectedRows[0].Cells[5].Value.ToString();
            textBoxquantity_Previous.Text = dataGridViewSalesReturn.SelectedRows[0].Cells[3].Value.ToString();
        }
        SqlConnection con11 = new SqlConnection(ConfigurationManager.ConnectionStrings["PosConString"].ToString());
        private void DEl_Zero_Quantity()
        {
            SqlConnection con112 = new SqlConnection(ConfigurationManager.ConnectionStrings["PosConString"].ToString());
            string query12 = @"DELETE FROM Sales WHERE  SalesQuantity <= 0";
            query12 += @"DELETE FROM Sales WHERE SalesTotal <= 0";
            SqlCommand command12 = new SqlCommand(query12, con112);
            con112.Open();
            int rowEffict1 = command12.ExecuteNonQuery();
            con112.Close();
        }
        private void Update_Sales_Details(int final_quantity, string hiddeninvoiceno,int prod_id, int salesid, string UPremarks)
        {
            
            string query11 = "UPDATE Sales SET SalesQuantity = '" + final_quantity + "' WHERE SalesID = '" + salesid + "'";
            query11 += "UPDATE Sales SET SalesRemarks = '" + UPremarks + "' WHERE SalesNo = '" + hiddeninvoiceno + "'";     //Change
            SqlCommand command11 = new SqlCommand(query11, con11);
            con11.Open();
            int rowEffict11 = command11.ExecuteNonQuery();
            if (rowEffict11 > 0)
            {
                //DEl_Zero_Quantity();
                DataGrid(hiddeninvoiceno);
               
            }
            con11.Close();
        }

        //private void Update_Sales_Total(int ftotal, string hiddeninvoiceno)
        //{
        //    string query11 = "UPDATE Sales SET SalesTotal = '" + ftotal + "'WHERE SalesNo = '" + hiddeninvoiceno + "'";
        //    SqlCommand command11 = new SqlCommand(query11, con11);
        //    con11.Open();
        //    command11.ExecuteNonQuery();
        //    con11.Close();
        //}
        public void Sales_Return(int pro_id, string Date, string hiddeninvoiceno, int quantity)
        {
            string query11 = "INSERT INTO SalesReturn(CompanyID,Date,InvoiceNo,ProductID,SalePrice,Quantity,Discount,Total) VALUES('"+ CompanyID + "','" + Date + "','" + hiddeninvoiceno + "','" + pro_id + "',0,'" + quantity + "',0,0)";
            SqlCommand command11 = new SqlCommand(query11, con11);
            con11.Open();
            command11.ExecuteNonQuery();
            con11.Close();
        }
        
        private void Update_Product_Details(int pros_id, int fstock)
        {
            SqlConnection con22 = new SqlConnection(ConfigurationManager.ConnectionStrings["PosConString"].ToString());
            string query1111 = "UPDATE Product SET Stock = '" + fstock+ "' WHERE ID = '" + pros_id+ "'";
            SqlCommand command1111 = new SqlCommand(query1111, con22);
            con22.Open();
            command1111.ExecuteNonQuery();
            con22.Close();
        }
        public int StockINProduct(int pro_id)
        {
            string querypd = "SELECT Stock FROM Product WHERE ID = '" + pro_id + "'";
            SqlCommand commandpd = new SqlCommand(querypd, con11);
            con11.Open();
            SqlDataReader reader = commandpd.ExecuteReader();
            int stock_total = 0;
            while (reader.Read())
            {
                stock_total = Convert.ToInt32(reader["Stock"]);
            }
            reader.Close();
            con11.Close();
            return stock_total;
        }
        private void Update_Customer_Ledger(int CustID, double UpAmount, string InvoiceNo, int NetReturn)
        {
            //double Debit = 0;
            //double Credit = 0;
            //string querypd = "SELECT Debit,Credit FROM CustomerLedger WHERE CustomerID = '" + CustID + "' AND InvoiceNo='"+ InvoiceNo + "'";
            //SqlCommand commandpd = new SqlCommand(querypd, con11);
            //con11.Open();
            //SqlDataReader reader = commandpd.ExecuteReader();
            //while (reader.Read())
            //{
            //    Debit = Convert.ToDouble(reader["Debit"]);
            //    Credit = Convert.ToDouble(reader["Credit"]);
            //}
            //reader.Close();
            //con11.Close();

            ////Update Debit Credit
            //Debit = Debit - UpAmount;
            //Credit = Credit - UpAmount;

            //SqlConnection con22 = new SqlConnection(ConfigurationManager.ConnectionStrings["PosConString"].ToString());
            //string query1111 = "UPDATE CustomerLedger SET Debit = '" + Debit + "', Credit= '" + Credit + "'WHERE CustomerID = '" + CustID + "' AND InvoiceNo='" + InvoiceNo + "'";
            //SqlCommand command1111 = new SqlCommand(query1111, con22);
            //con22.Open();
            //command1111.ExecuteNonQuery();
            //con22.Close();

            //Insert Customer Ledger
            string Invoice = "SRE" + InvoiceNo;
            int Adjustment = 0;
            int zero = 0;
            int Debit = 0;
            string ledger_remarks = "***SRE Adjustment : " + Adjustment.ToString();
            DateTime today = DateTime.Today;
            string date = today.ToString("yyyy-MM-dd");
            string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
            SqlConnection connection = new SqlConnection(conStr);
            string query11 = "INSERT INTO CustomerLedger(ReceiveDate,CustomerID,InvoiceNo,Debit,Credit,Adjustment,Remarks,NextPaymentDate,IsPreviousDue) VALUES('" + date + "','" + CustID + "','" + Invoice + "','" + Debit + "','" + NetReturn + "','"+ Adjustment + "','" + ledger_remarks + "','" + zero + "','" + zero + "')";
            SqlCommand command = new SqlCommand(query11, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();


        }

        private double Discount(int salesid)
        {
            double dis = 0;
            string query11 = "SELECT SalesProductDiscount FROM Sales WHERE SalesID = '" + salesid + "'";
            SqlCommand command11 = new SqlCommand(query11, con11);
            con11.Open();
            SqlDataReader reader = command11.ExecuteReader();
            while (reader.Read())
            {
                dis = Convert.ToInt32(reader["SalesProductDiscount"]);
            }
            reader.Close();
            con11.Close();
            return dis;
        }
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            try
            {
                string Date = textBoxDate.Text;
                string hiddeninvoiceno = textBoxInvoiceNoHidden.Text;
                if (textBoxProductID.Text == "")
                {
                    MessageBox.Show("Please Select a product in Data Grid.....1");
                }
                int salesid = Convert.ToInt32(textBoxSalesId.Text); 

                int prod_id = Convert.ToInt32(textBoxProductID.Text);

                if (textBoxReturnQuantity.Text == "")
                {
                    MessageBox.Show("Please give return quantity.....");
                }
                int return_quantity =  Convert.ToInt32(textBoxReturnQuantity.Text);


                int previous_quantity = Convert.ToInt32(textBoxquantity_Previous.Text);
                int final_quantity = previous_quantity - return_quantity;
            
                if (textBoxName.Text == "")
                {
                    MessageBox.Show("Please Select a product in Data Grid.....2");
                }
                else if (final_quantity < 0)
                {
                    MessageBox.Show("Product Quantity is not Correct.....");
                }
                
                else if (textBoxReturnQuantity.Text == "")
                {
                    MessageBox.Show("Please give return quantity.....");
                }
                
                else
                {
                    DialogResult dr = MessageBox.Show("Are you sure, you will return "+"( "+ textBoxReturnQuantity.Text + " )"+" product?", "Sales Return", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        Sales_Return(prod_id, Date, hiddeninvoiceno, return_quantity);
                        string query11 = "SELECT SalesRemarks FROM Sales WHERE SalesNo = '" + hiddeninvoiceno + "'";
                        SqlCommand command11 = new SqlCommand(query11, con11); 
                        con11.Open();
                        SqlDataReader reader = command11.ExecuteReader();
                        string Upremarks = "";
                        while (reader.Read())
                        {
                            Upremarks = reader["SalesRemarks"].ToString();                         
                        }
                        reader.Close();
                        con11.Close();

                        Upremarks = "***Sales Returned By : "+ currentuser + " On "+ textBoxDate.Text +" \n"+ Upremarks;
                      
                        Update_Sales_Details(final_quantity, hiddeninvoiceno, prod_id, salesid, Upremarks);

                        //int pre_stockss = 0;
                        //pre_stockss = StockINProduct(prod_id);
                        //int fpre_stockss = 0;
                        //fpre_stockss = pre_stockss + return_quantity;
                        //Update_Product_Details(prod_id, fpre_stockss);
                       
                        //int CustIDUP = Convert.ToInt32(textBoxCustomerID.Text);
                        // double NetReturn = Convert.ToDouble(textBoxNetReturn.Text);
                      
                        //Clear_all();
                        ClearAll();
                    }
                }
            }
            catch (Exception)
            {
               MessageBox.Show("Please Select a Product on Data Grid.....!!!!!!8");
            }                
        }

        private void textBoxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back) //The  character represents a backspace
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }
        public void ClearAll()
        {
            textBoxProductID.Text = textBoxName.Text = textBoxQuantity.Text = textBoxFloor.Text = textBoxWarehouse.Text = textBoxReturnQuantity.Text = textBoxNewQuantity.Text = "";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private bool IsNumer(string num)
        {
            int n;
            bool isNumeric = int.TryParse(num, out n);
            return isNumeric;
        }
        private void textBoxReturnQuantity_TextChanged(object sender, EventArgs e)
        {
                if (textBoxReturnQuantity.Text == "")
                {
                    textBoxNewQuantity.Text = "0";
                }

                if (textBoxReturnQuantity.Text != "")
                {
                    if (IsNumer(textBoxReturnQuantity.Text))
                    {
                        if (Convert.ToInt32(textBoxReturnQuantity.Text)<= Convert.ToInt32(textBoxQuantity.Text))
                        {
                        textBoxNewQuantity.Text = (Convert.ToInt32(textBoxQuantity.Text) - Convert.ToInt32(textBoxReturnQuantity.Text)).ToString();
                        }
                        else
                        {
                            MessageBox.Show("Return Quantity is too big...");
                        }
                    }
                else
                {
                    MessageBox.Show("Please Input a valid Number...");
                }

                 }
            
        }

        //private void textBoxAdjustment_TextChanged(object sender, EventArgs e)
        //{
        //    double ReturnQuantity = 0;
        //    double Adjustment = 0;
            
        //    if (textBoxReturnQuantity.Text == "")
        //    {
        //        MessageBox.Show("Please Input a Return Number...");
        //        return;
        //    }
            
        //}
    }
}
