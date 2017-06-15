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
    public partial class Sales : Form
    {
        DataTable dt = new DataTable();
        int indexRows;
       // int stock = 0;
        public Sales()
        {
            InitializeComponent();
            
            textBoxQuantity.KeyPress += new KeyPressEventHandler(QuantityKeyPress);
            
            textBoxQuantity.KeyDown += new KeyEventHandler(textBoxQuantity_KeyDown);
           

            ShowTreeViewItem();

            //string query12 = "SELECT * FROM LocationMain";
            //fillCombo(comboBoxWarehouse, query12, "LocationMainName", "LocationMainID");

            string query = "SELECT * FROM LocationMain";
            comboBoxWarehouse.SelectedValue = -1;
            fillCombo(comboBoxWarehouse, query, "LocationMainName", "LocationMainID");

            int comboboxWarehouseId = Convert.ToInt32(comboBoxWarehouse.SelectedValue);


            Int32.TryParse(comboBoxWarehouse.SelectedValue.ToString(), out comboboxWarehouseId);

            string query2 = "SELECT * FROM Location where LocationMainID = " + comboboxWarehouseId + " ";
            //comboBoxRoomName.SelectedValue = -1;
            fillCombo(comboBoxFloor, query2, "LocationName", "LocationID");

        }
        public string SNo = "01";
        public string currentuser = Login.loguser;
        public int CompanyID = GetUserLogInfo.Company();

        private void TextboxValue(string ParameterName, int ParameterValue, ParameterField myParameterField, ParameterDiscreteValue myDiscreteValue, ParameterFields myParameterFields)
        {
            myParameterField.ParameterFieldName = ParameterName;
            myDiscreteValue.Value = ParameterValue;
            myParameterField.CurrentValues.Add(myDiscreteValue);
            myParameterFields.Add(myParameterField);
        }

        public void fillCombo(ComboBox combo, string query, string displayMember, string valueMember)
        {
            SqlCommand command;
            SqlDataAdapter adapter;
            DataTable table;
            SqlConnection conss = new SqlConnection(ConfigurationManager.ConnectionStrings["PosConString"].ToString());
            command = new SqlCommand(query, conss);
            adapter = new SqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            combo.DataSource = table;
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;
        }
        public void ShowTreeViewItem()
        {
            treeViewPurchaseItemSales.Nodes.Clear();
            string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
            SqlConnection connection = new SqlConnection(conStr);
            string query = "SELECT * FROM CategoryMain";
            SqlCommand command1 = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command1.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                treeViewPurchaseItemSales.Nodes.Add(reader["MaincategoryName"].ToString());
                FirstChild(Convert.ToInt32(reader["MainCategoryID"]), i);
                i++;
            }
            treeViewPurchaseItemSales.TabStop = false;
            reader.Close();
            connection.Close();

        }

        string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();

        public void FirstChild(int mainID, int i)
        {
            string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
            SqlConnection connection1 = new SqlConnection(conStr);
            string query1 = "SELECT * FROM Category WHERE MaincategoryID = '" + mainID + "'";
            SqlCommand command11 = new SqlCommand(query1, connection1);

            connection1.Open();
            SqlDataReader reader1 = command11.ExecuteReader();
            int j = 0;
            while (reader1.Read())
            {
                treeViewPurchaseItemSales.Nodes[i].Nodes.Add(reader1["CategoryName"].ToString());
                SecondChild(Convert.ToInt32(reader1["CategoryID"]), i, j);
                j++;
            }
            reader1.Close();
            connection1.Close();
        }

        public void SecondChild(int catID, int i, int j)
        {
            string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
            SqlConnection connection12 = new SqlConnection(conStr);
            string query12 = "SELECT * FROM CategorySub WHERE CategoryID = '" + catID + "'";
            SqlCommand command112 = new SqlCommand(query12, connection12);

            connection12.Open();
            SqlDataReader reader12 = command112.ExecuteReader();
            int k = 0;
            while (reader12.Read())
            {
                treeViewPurchaseItemSales.Nodes[i].Nodes[j].Nodes.Add(reader12["SubCategoryName"].ToString());
                ThirdChild(Convert.ToInt32(reader12["SubCategoryID"]), i, j, k);
                k++;
            }
            reader12.Close();
            connection12.Close();
        }
        public void ThirdChild(int SubcatID, int i, int j, int k)
        {
            string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
            SqlConnection connection12 = new SqlConnection(conStr);
            string query12 = "SELECT * FROM Product WHERE SubCategoryID = '" + SubcatID + "'";
            SqlCommand command112 = new SqlCommand(query12, connection12);

            connection12.Open();
            SqlDataReader reader12 = command112.ExecuteReader();

            while (reader12.Read())
            {

                TreeNode tn = new TreeNode();
                tn.Tag = reader12["ID"];
                tn.Text = reader12["Name"].ToString();
                treeViewPurchaseItemSales.Nodes[i].Nodes[j].Nodes[k].Nodes.Add(tn);

            }
            reader12.Close();
            connection12.Close();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
           // buttonReports.Enabled = false;
           // Temp_Sales_Truncate();

            Load_Form();
            Auto_Complete();

            this.ActiveControl = textBoxProductSearch;

            DateTime today = DateTime.Today;

            dt.Columns.AddRange(new DataColumn[8] { new DataColumn("Id", typeof(string)),
                new DataColumn("Name", typeof(string)),new DataColumn("warehouse_name", typeof(string)),new DataColumn("comboBoxFloor", typeof(string)),new DataColumn("Quantity", typeof(string)),new DataColumn("Unit", typeof(string)),new DataColumn("WarehouseId", typeof(string)),new DataColumn("FloorId", typeof(string))});

        }
        private void Auto_Complete()
        {
            //Auto Complete search
            textBoxProductSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxProductSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;

            textBoxCustomerName.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxCustomerName.AutoCompleteSource = AutoCompleteSource.CustomSource;

            string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
            SqlConnection conSS = new SqlConnection(conStr);
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            col.Clear();
            conSS.Open();
            string sql = "SELECT * FROM Product";
            SqlCommand cmd = new SqlCommand(sql, conSS);
            SqlDataReader sdr = null;
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                col.Add(sdr["Code"].ToString());
                col.Add(sdr["Name"].ToString());

            }
            sdr.Close();
            textBoxProductSearch.AutoCompleteCustomSource = col;



            AutoCompleteStringCollection col2 = new AutoCompleteStringCollection();
            col2.Clear();

            string sql2 = "SELECT CustomerName FROM Customer";
            SqlCommand cmd2 = new SqlCommand(sql2, conSS);
            SqlDataReader sdr2 = null;
            sdr2 = cmd2.ExecuteReader();
            while (sdr2.Read())
            {
                col2.Add(sdr2["CustomerName"].ToString());

            }
            sdr2.Close();
            textBoxCustomerName.AutoCompleteCustomSource = col2;

            conSS.Close();
        }

        private void Load_Form()
        {
            DateTime now = DateTime.Now;
            textBoxDate.Text = now.ToString("yyyy-MM-dd");
            textBoxDate.ReadOnly = true;
            textBoxTime.Text = now.ToLongTimeString();
            textBoxTime.ReadOnly = true;
            textBoxInvoiceNo.Text = now.ToLocalTime().ToString("yyyyMMddhhmmssfff");
        }
        
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PosConString"].ToString());
        
        
        private void buttonClear_Click_1(object sender, EventArgs e)
        {
            textBoxProductName.Text = textBoxQuantity.Text = "";
            textBoxInvoiceNo.Text = textBoxPdoductId.Text = "";
            treeViewPurchaseItemSales.SelectedNode = null;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            FormPurchaseClosed();
            Close();
        }
        public void GetUnitName(int unit_id)
        {
            string conStr111 = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
            SqlConnection connection12111 = new SqlConnection(conStr111);
            string query12111 = "SELECT * FROM Unit WHERE UnitID = '" + unit_id + "'";
            SqlCommand command112111 = new SqlCommand(query12111, connection12111);

            connection12111.Open();
            SqlDataReader reader12111 = command112111.ExecuteReader();

            while (reader12111.Read())
            {
                textBoxUnitType.Text = reader12111["UnitName"].ToString();
            }
            reader12111.Close();
            connection12111.Close();
        }
       
        private void treeViewPurchaseItemSales_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                textBoxPdoductId.Text = "";
                textBoxPdoductId.Text = treeViewPurchaseItemSales.SelectedNode.Tag.ToString();
                textBoxProductName.Text = "";
                int pro_id = Convert.ToInt32(textBoxPdoductId.Text);
                string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
                SqlConnection connection12 = new SqlConnection(conStr);
                string query12 = "SELECT * FROM Product WHERE ID = '" + pro_id + "'";
                SqlCommand command112 = new SqlCommand(query12, connection12);

                connection12.Open();
                SqlDataReader reader12 = command112.ExecuteReader();

                while (reader12.Read())
                {

                    textBoxProductName.Text = reader12["Name"].ToString();
                   // textBoxPdoductID.Text = reader12["Code"].ToString();
                    textBoxPdoductId.Text = reader12["ID"].ToString();
                }
                reader12.Close();
                connection12.Close();


                //unit name
                string conStr11 = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
                SqlConnection connection1211 = new SqlConnection(conStr11);
                string query1211 = "SELECT * FROM Product WHERE ID = '" + pro_id + "'";
                SqlCommand command11211 = new SqlCommand(query1211, connection1211);

                connection1211.Open();
                SqlDataReader reader1211 = command11211.ExecuteReader();

                while (reader1211.Read())
                {
                    
                    int unit_id = Convert.ToInt32(reader1211["UnitID"]);
                    GetUnitName(unit_id);
                }
                reader1211.Close();



                string query13 = "SELECT CategorySub.SubCategoryName FROM CategorySub INNER JOIN Product ON CategorySub.SubCategoryID = Product.SubCategoryID WHERE Product.ID = '" + pro_id + "'";
                SqlCommand command113 = new SqlCommand(query13, connection12);

                connection12.Open();
                SqlDataReader reader13 = command113.ExecuteReader();

                while (reader13.Read())
                {

                    // textBoxProductName.Text = reader12["Name"].ToString();
                    textBoxProductCategory.Text = reader13["SubCategoryName"].ToString();
                    // textBoxPrice.Text = reader12["SalePrice"].ToString();
                    // int unit_id = Convert.ToInt32(reader12["UnitID"]);
                    //  GetUnitName(unit_id);
                }
                reader13.Close();

                connection1211.Close();

                //show current stock
                int val;
                Int32.TryParse(comboBoxWarehouse.SelectedValue.ToString(), out val);
                textBoxCurrentStock.Text = Currently_Stock(val).ToString();
                //end show current stock

                //See Currently Stock
                // Currently_Stock(textBoxPdoductId.Text, Convert.ToInt32(comboBoxWarehouse.SelectedValue.ToString()));
                textBoxProductSearch.Text = "";

            }
            catch (Exception)
            {
                textBoxPdoductId.Text = "";
                textBoxProductName.Text = "";
                textBoxProductCategory.Text = "";
               
                textBoxUnitType.Text = "";
                MessageBox.Show("Please Select the Product First..");
            }
        }
       
        //private void Currently_Stock( string prod_id ,int val )
        //{
        //    double stock = 0;
        //    string conStrPross = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
        //    SqlConnection connectionPross = new SqlConnection(conStrPross);
        //    string queryPross = "SELECT Stock FROM ProductDetails WHERE ProductID = '" + prod_id + "' AND WarehouseID = '"+ val +"'";
        //    SqlCommand commandPross = new SqlCommand(queryPross, connectionPross);
        //    connectionPross.Open();
        //    SqlDataReader readerPross = commandPross.ExecuteReader();

        //    while (readerPross.Read())
        //    {
        //        stock = Convert.ToDouble(readerPross["Stock"]);
        //    }
            
        //    readerPross.Close();
        //    connectionPross.Close();
        //    textBoxCurrentStock.Text = stock.ToString();
        //}

        private void comboBoxWarehouseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int val;
            //Int32.TryParse(comboBoxWarehouseName.SelectedValue.ToString(), out val);
            //string query12 = "SELECT * FROM Location WHERE LocationMainID = '" + val + "'";
            //fillCombo(comboBoxFloor, query12, "LocationName", "LocationID");
            //Currently_Stock(textBoxPdoductID.Text, val);

            int val;
            Int32.TryParse(comboBoxWarehouse.SelectedValue.ToString(), out val);

            string query2 = "SELECT * FROM Location where LocationMainID = " + val + " ";
            //comboBoxRoomName.SelectedValue = -1;
            fillCombo(comboBoxFloor, query2, "LocationName", "LocationID");
            textBoxCurrentStock.Text = Currently_Stock(val).ToString();
        }
        public void FormPurchaseClosed()
        {
            //Temp_Sales_Truncate();
        }

        //Add Button Event


        private double previous_stock(int id)
        {
            double previous_stock = 0;

            string conStrCal1 = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
            SqlConnection connectionCal1 = new SqlConnection(conStrCal1);
            string queryCal1 = "SELECT * FROM Product WHERE ID = '" + id+"'";
            SqlCommand commandCal1 = new SqlCommand(queryCal1, connectionCal1);
            connectionCal1.Open();
            SqlDataReader readerCal1 = commandCal1.ExecuteReader();

            while (readerCal1.Read())
            {
                previous_stock = Convert.ToDouble(readerCal1["Stock"]);
            }
            readerCal1.Close();
            connectionCal1.Close();
            return previous_stock;
        }
        private double SalesTotal()
        {
            double total = 0;
            double p_stock = 0;
            SqlConnection connection = new SqlConnection(conStr);
            string query = "SELECT * FROM TempSales WHERE TempSalesCompanyID='"+CompanyID+"'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                total = total + Convert.ToDouble(reader["TempSalesTotal"]);
                p_stock = previous_stock(Convert.ToInt32(reader["TempSalesProductID"]));
                UpdateProductDetails(Convert.ToInt32(reader["TempSalesProductID"]), p_stock-Convert.ToDouble(reader["TempSalesQuantity"]));
            }
            reader.Close();
            connection.Close();
            return total;

        }
        private int GetCustId(string name)
        {
            int id = 0;
            SqlConnection connection = new SqlConnection(conStr);
            string query = "SELECT * FROM Customer Where CustomerName ='"+name+"'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                id = Convert.ToInt32(reader["CustomerID"]);
            }
            reader.Close();
            connection.Close();
            return id;

        }

        private void UpdateProductDetails(int pro_id, double quantity)
        {
            SqlConnection connection1 = new SqlConnection(conStr);
            string query1 = "UPDATE Product SET Stock = '" + quantity + "' WHERE ID = '" + pro_id + "'";
            SqlCommand command1 = new SqlCommand(query1, connection1);
            connection1.Open();
            command1.ExecuteNonQuery();
            connection1.Close();
           
        }
        private void SeeTotal_Component()
        {
            double total = 0;
            double total_product = 0;
            double total_item = 0;
            double total_dis = 0;

            SqlConnection connection = new SqlConnection(conStr);
            string query = "SELECT * FROM TempSales WHERE TempSalesCompanyID='" + CompanyID + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                total_product = total_product + Convert.ToDouble(reader["TempSalesQuantity"]);
                total = total + (Convert.ToDouble(reader["TempSalesTotal"])+ Convert.ToDouble(reader["TempSalesProductDiscount"])); //Change
                total_dis = total_dis + Convert.ToDouble(reader["TempSalesProductDiscount"]);
                total_item++;
            }
            reader.Close();
            connection.Close();
            textBoxItemTotal.Text = total_item.ToString();
            textBoxProductTotal.Text = total_product.ToString();
          

          //  textBoxNetTotal.Text= (total - total_dis).ToString();


            //textBoxInvoiceTotalAmount.Text = Math.Ceiling(total - total_dis).ToString();
            textBoxInvoiceTotalAmount.Text = Math.Ceiling(total).ToString();

        }

        //private double GetPurchasePrice(int id)
        //{
        //    double purchase_price = 0.0;
        //    SqlConnection con = new SqlConnection(conStr);
        //    string query = "SELECT PurchasePrice FROM Product WHERE ID= '" + id + "'";
        //    SqlCommand command = new SqlCommand(query, con);
        //    con.Open();
        //    SqlDataReader reader = command.ExecuteReader();

        //    while (reader.Read())
        //    {
        //        purchase_price = Convert.ToDouble(reader["PurchasePrice"]);
        //    }

        //    reader.Close();
        //    con.Close();
        //    return purchase_price;
        //}

        public void Clear_All_Last()
        {
            textBoxPdoductId.Text = textBoxProductName.Text = textBoxQuantity.Text = textBoxUnitType.Text = textBoxCurrentStock.Text = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            
            if (textBoxCustomerName.Text == "" || textBoxCompanyAddress.Text == "")
            {
                MessageBox.Show("Please Select valid Customer..");
            }

            //else if (textBoxSupplierInvoiceNo.Text == "")
            //{
            //    MessageBox.Show("Please Fill the Supplier Invoice No..");
            //}
            else if (textBoxPdoductId.Text == "")
            {
                MessageBox.Show("Please Select a Product on Data Tree view..!!");
            }
            else if (textBoxQuantity.Text == "")
            {
                MessageBox.Show("Please Fill the quantity..");
            }

            else if (comboBoxFloor.Text == "")
            {
                MessageBox.Show("Please Select the Floor Name..");
            }

            else
            {
                int isEdited = 0;

                if (textBoxQuantity.Text == "")
                {
                    textBoxQuantity.Text = "0";

                }

                if (dataGridViewSales.Rows.Count > 0)
                {


                    String searchValue = textBoxPdoductId.Text;
                    int rowIndex = -1;
                    if (isEdited == 0)
                    {
                        foreach (DataGridViewRow row in dataGridViewSales.Rows)
                        {
                            if (row.Cells["Id"].Value != null) // Need to check for null if new row is exposed
                            {
                                rowIndex = -1;
                                if (row.Cells["Id"].Value.ToString().Equals(searchValue) && row.Cells["warehouse_name"].Value.ToString().Equals(comboBoxWarehouse.Text) && row.Cells["comboBoxFloor"].Value.ToString().Equals(comboBoxFloor.Text))
                                {
                                    rowIndex = row.Index;
                                    // break;
                                    DataGridViewRow newDataRow = dataGridViewSales.Rows[rowIndex];
                                    double sum = Convert.ToDouble(newDataRow.Cells[4].Value) + Convert.ToDouble(textBoxQuantity.Text);

                                    if (checkStock()>=  sum)
                                    {
                                        newDataRow.Cells[0].Value = textBoxPdoductId.Text;
                                        newDataRow.Cells[1].Value = textBoxProductName.Text;
                                        newDataRow.Cells[2].Value = comboBoxWarehouse.Text;
                                        newDataRow.Cells[3].Value = comboBoxFloor.Text;
                                        newDataRow.Cells[4].Value = sum;
                                        newDataRow.Cells[5].Value = textBoxUnitType.Text;
                                        newDataRow.Cells[6].Value = comboBoxWarehouse.SelectedValue;
                                        newDataRow.Cells[7].Value = comboBoxFloor.SelectedValue;
                                        isEdited = 1;
                                        Clear_All_Last();
                                        break;
                                    }

                                    else
                                    {
                                        MessageBox.Show("Your Product is not available for Sale.");
                                        isEdited = 1;
                                        break;
                                    }
                                    
                                }

                            }
                           // isEdited = 1;
                        }
                        
                    } 

                }
                if (isEdited != 1)
                {


                   

                    if(checkStock() >= Convert.ToInt32(textBoxQuantity.Text))
                    {
                        dt.Rows.Add(textBoxPdoductId.Text, textBoxProductName.Text, comboBoxWarehouse.Text, comboBoxFloor.Text, textBoxQuantity.Text, textBoxUnitType.Text, comboBoxWarehouse.SelectedValue, comboBoxFloor.SelectedValue);
                        this.dataGridViewSales.DataSource = dt;
                        //clearAll();
                        Clear_All_Last();
                    }

                    else
                    {
                        MessageBox.Show("Your Product is not available for Sale.");
                    }

                }

            }
           treeViewPurchaseItemSales.SelectedNode = null;
            
        }

        public int checkStock()
        {
            int stock = 0;
            SqlConnection connection = new SqlConnection(conStr);
            string query = "SELECT STOCK FROM ProductDetails WHERE ProductID='" + textBoxPdoductId.Text + "' and WarehouseID='" + comboBoxWarehouse.SelectedValue + "' AND RackID = '" + comboBoxFloor.SelectedValue + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                stock = Convert.ToInt32(reader["Stock"]);

            }
            return stock;
        }

        private void SalesClosed(object sender, FormClosedEventArgs e)
        {
            FormPurchaseClosed();
        }

        private void QuantityKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back) //The  character represents a backspace
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }

        private void DiscountKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back) //The  character represents a backspace
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }


        private void DiscountPercent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar=='.' || e.KeyChar == (char)Keys.Back) //The  character represents a backspace
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }

        }
        private void InsertSales()
        {
           SalesTotal();
            
        }
       int PaymentType = 0;
        private void AddSalesDetails()
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string sql = @"INSERT INTO Sales(CompanyID,SalesNo,SalesDate,SalesTime,SalesCustomerID,SalesRemarks,Reference,SalesProductID,SalesPurchasePrice,SalesSalePrice,SalesQuantity,SalesProductDiscount,SalesTotal,SalesCustomerName,SalesSoldBy,SalesReceivedAmount,SalesChangeAmount,SalesVatRate,SalesVatTotal,SalesPuechaseBy,SalesPurchaseByContact) SELECT TempSalesCompanyID,TempSalesNo,TempSalesDate,TempSaleTime,TempSalesCustomerID,TempSalesRemarks,TempSalesReference,TempSalesProductID,TempSalesPurchasePrice,TempSalesSalePrice,TempSalesQuantity,TempSalesProductDiscount,TempSalesTotal,TempSalesCustomerName,TempSalesSoldBy,TempSalesReceivedAmount,TempSalesChangeAmount,TempSalesVatRate,TempSalesVatTotal, TempSalesPuechaseBy, TempSalesPurchaseByContact FROM TempSales  WHERE TempSalesCompanyID='" + CompanyID + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            
            

            //int IsChequeReceive = 0;
            //if (checkBoxChequeReceive.Checked==true)
            //{
            //    IsChequeReceive = 1;
            //}

            con.Open();
            sql = @"UPDATE Sales SET SalesRemarks ='" + textBoxRemarks.Text + "', PaymentType = '" + PaymentType + "'  WHERE SalesNo='" + SerialNo + "'";
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public void TempAmountTruncate()
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string sql = @"DELETE FROM TempSalesAmount WHERE CompanyID='"+CompanyID+"'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
         
        private void InsertTempAmount(int Companyid, int CustomerID, double TotalVat,double NetPayable,double Cashpaid,double ReturnAmount,double DueAmount,string  CurrentUserSales, string Remarks)
        {
            TempAmountTruncate();
            SqlConnection con1 = new SqlConnection(conStr);
            con1.Open();
            string sql1 = @"INSERT INTO TempSalesAmount(CompanyID, CustomerID, TotalVat, NetPayable, CashPaid, ReturnAmount, DueAmount,CurrentUserSales,Remarks) VALUES('" + Companyid + "','" + CustomerID + "','" + TotalVat + "','" + NetPayable + "','" + Cashpaid + "','" + ReturnAmount + "','" + DueAmount + "','" + CurrentUserSales + "','" + Remarks + "')";
            SqlCommand cmd1 = new SqlCommand(sql1, con1);
            cmd1.ExecuteNonQuery();
            con1.Close();
        }

        public string ReportPaths = ReportPath.rPath;
        private void Print_report()
        {
            ReportDocument cryRpt = new ReportDocument();
            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            
            string rPath = ReportPaths + "CrystalReportSalesReportInvoiceA4.rpt";
            cryRpt.Load(rPath);

            cryRpt.SetParameterValue("CompanyID", CompanyID);
           
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

            cryRpt.PrintOptions.PrinterName = "";
            cryRpt.PrintToPrinter(1, false, 0, 0);
            cryRpt.Close();
            cryRpt.Dispose();

        }
        private void Print_Challan_report()
        {
            ReportDocument cryRpt = new ReportDocument();
            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();

            string rPath = ReportPaths + "CrystalReportSalesInvoiceChallanA4.rpt";
            cryRpt.Load(rPath);

            cryRpt.SetParameterValue("CompanyID", CompanyID);

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

            cryRpt.PrintOptions.PrinterName = "";
            cryRpt.PrintToPrinter(1, false, 0, 0);
            cryRpt.Close();
            cryRpt.Dispose();

        }

        public string SerialNo = "";
        private void UpdateTempSalesDiscount(int countsales)
        {
           

            SerialNo = SNo + countsales.ToString("D6");
           
            string Custname = textBoxCustomerName.Text;
            int id = GetCustId(Custname);
            SqlConnection con1 = new SqlConnection(conStr);
            con1.Open();
           // string sql1 = @"UPDATE TempSales SET TempSalesProductDiscount ='" + textBoxDisTotal.Text + "', TempSalesReference='" + textBoxReference.Text + "',TempSalesCustomerID='" + id+ "',TempSalesNo='" + SerialNo + "' WHERE TempSalesCompanyID = '" + CompanyID + "'";
            string sql1 = @"UPDATE TempSales SET TempSalesReference='" + textBoxReference.Text + "',TempSalesCustomerID='" + id + "',TempSalesNo='" + SerialNo + "', TempSalesPaymentType = '" + PaymentType +"' WHERE TempSalesCompanyID = '" + CompanyID + "'";    // Change
            SqlCommand cmd1 = new SqlCommand(sql1, con1);
            cmd1.ExecuteNonQuery();
            con1.Close();
        }


        private int CountSalesNo()
        {
            int no = 0;
            SqlConnection con = new SqlConnection(conStr);
            string query = "SELECT COUNT(DISTINCT(SalesNo)) as 'No' FROM Sales";
            SqlCommand command = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                no = Convert.ToInt32(reader["No"]);
            }

            reader.Close();
            con.Close();
            return no;

        }

        private int CountSaleNo()
        {
            int no = 0;
            SqlConnection con = new SqlConnection(conStr);
            string query = "SELECT COUNT(DISTINCT(SalesNo)) as 'No' FROM sales";
            SqlCommand command = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                no = Convert.ToInt32(reader["No"]);
            }

            reader.Close();
            con.Close();
            return no;
        }

      
        private void UpdateProductDetails(int pro_id, double quantity, int wareHouseId, int floorId)
        {
            SqlConnection connection1 = new SqlConnection(conStr);
            // string query1 = "UPDATE ProductDetails SET Stock = ((SELECT Stock FROM ProductDetails WHERE ID = '" + pro_id + "' ) - '" + quantity + "') WHERE ID = '" + pro_id + "'";
            string query1 = "IF EXISTS (SELECT * FROM ProductDetails WHERE ProductID ='" + pro_id + "' AND WarehouseID = '" + wareHouseId + "' AND RackID = '" + floorId + "' ) UPDATE ProductDetails SET stock = ((SELECT Stock FROM ProductDetails WHERE ProductID = '" + pro_id + "' AND WarehouseID = '" + wareHouseId + "' AND RackID = '" + floorId + "' )-'" + quantity + "') WHERE ProductID = '" + pro_id + "' AND WarehouseID = '" + wareHouseId + "' AND RackID = '" + floorId + "' ";
           // string query1 = "IF EXISTS (SELECT * FROM ProductDetails WHERE ProductID ='" + pro_id + "' AND WarehouseID = '" + wareHouseId + "' AND RackID = '" + floorId + "' ) UPDATE ProductDetails SET stock = ((SELECT Stock FROM ProductDetails WHERE ProductID = '" + pro_id + "' AND WarehouseID = '" + wareHouseId + "'  AND RackID = '" + floorId + "')+'" + quantity + "') WHERE ProductID = '" + pro_id + "' AND WarehouseID = '" + wareHouseId + "'  AND RackID = '" + floorId + "' ELSE INSERT INTO ProductDetails(ProductID, WarehouseID, RackID, CellID, Stock) VALUES('" + pro_id + "', '" + wareHouseId + "', '" + floorId + "', 0, '" + quantity + "')";
            SqlCommand command1 = new SqlCommand(query1, connection1);
            connection1.Open();
            command1.ExecuteNonQuery();
            connection1.Close();

        }

        private void Insert_Customer_Ledger(int id)
        {
            string date = textBoxDate.Text;
            string ledger_invoice_no = SerialNo;
            double ledger_credit = 0.0;
            string ledger_remarks = "";
            int zero = 0;
            int Adjustment = 0;
            string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
            SqlConnection connection = new SqlConnection(conStr);
            string query11 = "INSERT INTO CustomerLedger(ReceiveDate,CustomerID,InvoiceNo,Debit,Credit,Adjustment,Remarks,NextPaymentDate,IsPreviousDue) VALUES('" + date + "','" + id + "','" + ledger_invoice_no + "','" + ledger_credit + "','"+ Adjustment + "','" + ledger_remarks + "','"+ zero + "')";
            SqlCommand command = new SqlCommand(query11, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
           
        }

        private void Clear_all()
        {
            textBoxPdoductId.Text = "";
            textBoxProductName.Text = "";
            textBoxQuantity.Text = "";
            textBoxUnitType.Text = "";
           
            //textBoxDiscountTaka.Text = "";
            textBoxProductSearch.Text = "";
            textBoxItemTotal.Text = "";
            textBoxProductTotal.Text = "";
           
            textBoxInvoiceTotalAmount.Text = "";
            //textBoxVAT.Text = "";
        }
        
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            String searchValue = textBoxPdoductId.Text;
            int isEdited = 0;
            int count = 0;

            if (textBoxQuantity.Text == "")
            {
                textBoxQuantity.Text = "0";
            }

            if (dataGridViewSales.Rows.Count > 0)
            {
                indexRows = dataGridViewSales.CurrentCell.RowIndex;

                int rowIndex = -1;
                if (isEdited == 0)
                {
                    foreach (DataGridViewRow row in dataGridViewSales.Rows)
                    {
                        if (row.Cells["Id"].Value != null) // Need to check for null if new row is exposed
                        {
                            rowIndex = row.Index;
                            if ((row.Cells["Id"].Value.ToString().Equals(searchValue) && row.Cells["warehouse_name"].Value.ToString().Equals(comboBoxWarehouse.Text) && row.Cells["comboBoxFloor"].Value.ToString().Equals(comboBoxFloor.Text)) && rowIndex == indexRows)
                            {
                                if (checkStock() >= Convert.ToInt32(textBoxQuantity.Text))
                                {
                                    DataGridViewRow newDataRow = dataGridViewSales.Rows[indexRows];
                                    double sum = Convert.ToDouble(textBoxQuantity.Text);
                                    newDataRow.Cells[0].Value = textBoxPdoductId.Text;
                                    newDataRow.Cells[1].Value = textBoxProductName.Text;
                                    newDataRow.Cells[2].Value = comboBoxWarehouse.Text;
                                    newDataRow.Cells[3].Value = comboBoxFloor.Text;
                                    newDataRow.Cells[4].Value = sum;
                                    newDataRow.Cells[5].Value = textBoxUnitType.Text;
                                    newDataRow.Cells[6].Value = comboBoxWarehouse.SelectedValue;
                                    newDataRow.Cells[7].Value = comboBoxFloor.SelectedValue;
                                   
                                   
                                }
                                else
                                {
                                    MessageBox.Show("Your Product is not available for Sale.");
                                }
                                isEdited = 1;
                                count++;
                                Clear_All_Last();
                                break;
                            }
                            if ((row.Cells["Id"].Value.ToString().Equals(searchValue) && row.Cells["warehouse_name"].Value.ToString().Equals(comboBoxWarehouse.Text) && row.Cells["comboBoxFloor"].Value.ToString().Equals(comboBoxFloor.Text)))
                            {

                                count = 2;
                            }

                        }
                    }

                }

            }
            if (dataGridViewSales.Rows.Count > 0)
            {
                if (isEdited != 1 && count == 0)
                {
                    if (checkStock() >= Convert.ToInt32(textBoxQuantity.Text))
                    {
                        indexRows = dataGridViewSales.CurrentCell.RowIndex;

                        DataGridViewRow newDataRow = dataGridViewSales.Rows[indexRows];
                        double sum = Convert.ToDouble(textBoxQuantity.Text);
                        newDataRow.Cells[0].Value = textBoxPdoductId.Text;
                        newDataRow.Cells[1].Value = textBoxProductName.Text;
                        newDataRow.Cells[2].Value = comboBoxWarehouse.Text;
                        newDataRow.Cells[3].Value = comboBoxFloor.Text;
                        newDataRow.Cells[4].Value = sum;
                        newDataRow.Cells[5].Value = textBoxUnitType.Text;
                        newDataRow.Cells[6].Value = comboBoxWarehouse.SelectedValue;
                        newDataRow.Cells[7].Value = comboBoxFloor.SelectedValue;
                        isEdited = 1;
                        Clear_All_Last();
                    }

                }
                if (count == 2)
                {
                    MessageBox.Show("This product already exists in datagrid...");

                }
                //else
                //{
                //    MessageBox.Show("Please select a data. then click update button.");
                //}
            }
            treeViewPurchaseItemSales.SelectedNode = null;


            //if (textBoxQuantity.Text == "")
            //{
            //    textBoxQuantity.Text = "0";
            //}
            //if (dataGridViewSales.Rows.Count >= 1)
            //{
            //    indexRows = dataGridViewSales.CurrentCell.RowIndex;
            //    if (checkStock() >= Convert.ToInt32(textBoxQuantity.Text))
            //    {
            //        DataGridViewRow newDataRow = dataGridViewSales.Rows[indexRows];
            //        newDataRow.Cells[0].Value = textBoxPdoductId.Text;
            //        newDataRow.Cells[1].Value = textBoxProductName.Text;
            //        newDataRow.Cells[2].Value = comboBoxWarehouse.Text;
            //        newDataRow.Cells[3].Value = comboBoxFloor.Text;
            //        newDataRow.Cells[4].Value = textBoxQuantity.Text;
            //        newDataRow.Cells[5].Value = textBoxUnitType.Text;
            //        newDataRow.Cells[6].Value = comboBoxWarehouse.SelectedValue;
            //        newDataRow.Cells[7].Value = comboBoxFloor.SelectedValue;
            //        Clear_All_Last();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Your Product is not available for Sale.");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Please select a data. then click update button.");
            //}
            //treeViewPurchaseItemSales.SelectedNode = null;
        }
        private void Temp_delete()
        {
            try
            {
                SqlConnection connection1 = new SqlConnection(conStr);
                string query1 = @"DELETE FROM TempSales WHERE TempSalesCompanyID='" + CompanyID + "' AND TempSalesProductID = '" + textBoxPdoductId.Text + "'";
                SqlCommand command1 = new SqlCommand(query1, connection1);
                connection1.Open();
                int rowEffict1 = command1.ExecuteNonQuery();
                connection1.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Please Select a Product in DataGrid...");
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewSales.Rows.Count >= 1)
            {
                int rowIndex = dataGridViewSales.CurrentCell.RowIndex;
                dataGridViewSales.Rows.RemoveAt(rowIndex);
                //clearAll();
            }
            else
            {
                MessageBox.Show("Please select a data. then click Remove button.");
            }
            treeViewPurchaseItemSales.SelectedNode = null;
        }
    
        private int IsProductExist(string proname)
        {
            int exist = 0;
            SqlConnection conww = new SqlConnection(conStr);
            conww.Open();
            string sqlww = "SELECT * FROM Product WHERE Name ='" + proname + "' OR Code ='" + proname + "'";
            SqlCommand cmdww = new SqlCommand(sqlww, conww);
            SqlDataReader sdrww = null;
            sdrww = cmdww.ExecuteReader();
            while (sdrww.Read())
            {
                exist = Convert.ToInt32(sdrww["ID"]);
            }
            sdrww.Close();
            conww.Close();
            return exist;
        }
        

        private void comboBoxBuyerName_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            string Custname = textBoxCustomerName.Text;
            int id = GetCustId(Custname);

            double ledger_debit = 0.0;
            double ledger_credit = 0.0;
            string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
            SqlConnection con = new SqlConnection(conStr);
            string query = "SELECT * FROM CustomerLedger WHERE CustomerID = " + id;
            SqlCommand command112 = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader12 = command112.ExecuteReader();
            while (reader12.Read())
            {

                ledger_debit = ledger_debit + Convert.ToDouble(reader12["Debit"]);
                ledger_credit = ledger_credit + Convert.ToDouble(reader12["Credit"]);

            }
            reader12.Close();
            con.Close();
           
            // Get Data from Customer Table
            
            con = new SqlConnection(conStr);
            query = "SELECT * FROM Customer WHERE CustomerID = " + id;
            command112 = new SqlCommand(query, con);
            con.Open();
            reader12 = command112.ExecuteReader();
            while (reader12.Read())
            {

                textBoxGroupName.Text = reader12["GroupName"].ToString();
                textBoxVatRegNo.Text = reader12["VatRegNo"].ToString();
                textBoxCompanyAddress.Text = reader12["Address"].ToString();

            }
            reader12.Close();
            con.Close();

            // End




        }

        private void buttonNewCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer ac = new AddCustomer();
           ac.Show();
            
        }

        //private void comboBoxBuyerName_Click(object sender, EventArgs e)
        //{
        //    string query12 = "SELECT * FROM Customer";
        //    fillCombo(comboBoxBuyerName, query12, "CustomerName", "CustomerID");
        //}

        
        private void textBoxQuantity_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.Enter && textBoxQuantity.Text!="")
            {
                this.ActiveControl = buttonAdd;
            }
        }

        

        private void Sales_KeyDown(object sender, KeyEventArgs e)
        {
           
        }



        private void textBoxProCode_TextChanged(object sender, EventArgs e)
        {
            if (textBoxProductCategory.Text != "")
            {
                buttonAdd.Enabled = true;
            }
        }


        private void textBoxReceiveAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               // this.ActiveControl = buttonReports;
            }
        }

        private void textBoxReceiveAmount_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back) //The  character represents a backspace
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }

        private void textBoxReceiveAmount_CursorChanged(object sender, EventArgs e)
        {
           

        }


        private void textBoxRemarks_TextChanged(object sender, EventArgs e)
        {

        }

        private void Demo1PrintReport()
        {
            ReportDocument cryRpt = new ReportDocument();
            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();

            ParameterFields myParameterFields = new ParameterFields();

            ParameterField myParameterField1 = new ParameterField();
            ParameterDiscreteValue myDiscreteValue1 = new ParameterDiscreteValue();


            string rPath = ReportPaths + "CrystalReportSalesReportInvoiceA4.rpt";
            cryRpt.Load(rPath);
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
        private void Demo2PrintReport()
        {
            ReportDocument cryRpt = new ReportDocument();
            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();

            ParameterFields myParameterFields = new ParameterFields();

            ParameterField myParameterField1 = new ParameterField();
            ParameterDiscreteValue myDiscreteValue1 = new ParameterDiscreteValue();

            string rPath = ReportPaths + "CrystalReportSalesInvoiceChallanA4.rpt";
            cryRpt.Load(rPath);
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
        private void buttonSalesInvoice_Click(object sender, EventArgs e)
        {
            if (textBoxItemTotal.Text == "")
            {
                MessageBox.Show("Please Select a Customer to due sell....!!!");
            }

            else if (textBoxInvoiceTotalAmount.Text == "")
            {
                MessageBox.Show("Please Add Product First....???");
            }

            else
            {

                Demo1PrintReport();
            }
        }

        private void buttonChallan_Click(object sender, EventArgs e)
        {
                if (textBoxItemTotal.Text == "")
                {
                    MessageBox.Show("Please Select a Customer to due sell....!!!");
                }

                else if (textBoxInvoiceTotalAmount.Text == "")
                {
                    MessageBox.Show("Please Add Product First....???");
                }
                
                else
                {
                    Demo2PrintReport();
                }
        }

        private void textBoxCustomerName_TextChanged(object sender, EventArgs e)
        {

            string Custname = textBoxCustomerName.Text;
            int id = GetCustId(Custname);

            //double ledger_debit = 0.0;
            //double ledger_credit = 0.0;
            //string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
            //SqlConnection con = new SqlConnection(conStr);
            //string query = "SELECT * FROM CustomerLedger WHERE CustomerID = " + id;
            //SqlCommand command112 = new SqlCommand(query, con);
            //con.Open();
            //SqlDataReader reader12 = command112.ExecuteReader();
            //while (reader12.Read())
            //{

            //    ledger_debit = ledger_debit + Convert.ToDouble(reader12["Debit"]);
            //    ledger_credit = ledger_credit + Convert.ToDouble(reader12["Credit"]);

            //}
            //reader12.Close();
            //con.Close();

            // Get Data from Customer Table

            con = new SqlConnection(conStr);
            string query = "SELECT * FROM Customer WHERE CustomerID = " + id;
            SqlCommand command112 = new SqlCommand(query, con);
            SqlDataReader reader12;
            con.Open();
            reader12 = command112.ExecuteReader();
            while (reader12.Read())
            {

                textBoxGroupName.Text = reader12["GroupName"].ToString();
                textBoxVatRegNo.Text = reader12["VatRegNo"].ToString();
                textBoxCompanyAddress.Text = reader12["Address"].ToString();

            }
            reader12.Close();
            con.Close();
        }

        private void textBoxCustomerName_MouseClick(object sender, MouseEventArgs e)
        {
            Auto_Complete();
        }

        private void textBoxProductSearch_TextChanged(object sender, EventArgs e)
        {
            if (IsProductExist(textBoxProductSearch.Text) > 0)
            {
                string spro_id = textBoxProductSearch.Text;
                SqlConnection conww = new SqlConnection(conStr);
                conww.Open();
                string sqlww = "SELECT * FROM Product WHERE Name ='" + spro_id + "' OR Code ='" + spro_id + "'";
                SqlCommand cmdww = new SqlCommand(sqlww, conww);
                SqlDataReader sdrww = null;
                sdrww = cmdww.ExecuteReader();
                while (sdrww.Read())
                {
                    spro_id = sdrww["ID"].ToString();
                }
                sdrww.Close();
                conww.Close();

                try
                {
                    textBoxPdoductId.Text = "";
                    textBoxProductName.Text = "";
                    textBoxUnitType.Text = "";

                    textBoxPdoductId.Text = spro_id;
                    int pro_id = Convert.ToInt32(textBoxPdoductId.Text);
                    textBoxProductName.Text = "";
                    SqlConnection connection12 = new SqlConnection(conStr);
                    string query12 = "SELECT * FROM Product WHERE ID = '" + pro_id + "'";
                    SqlCommand command112 = new SqlCommand(query12, connection12);

                    connection12.Open();
                    SqlDataReader reader12 = command112.ExecuteReader();

                    while (reader12.Read())
                    {

                        textBoxProductName.Text = reader12["Name"].ToString();
                        // textBoxProCode.Text = reader12["Code"].ToString();
                        int unit_id = Convert.ToInt32(reader12["UnitID"]);
                        GetUnitName(unit_id);
                    }
                    reader12.Close();
                    connection12.Close();

                    string query13 = "SELECT CategorySub.SubCategoryName FROM CategorySub INNER JOIN Product ON CategorySub.SubCategoryID = Product.SubCategoryID WHERE Product.ID = '" + pro_id + "'";
                    SqlCommand command113 = new SqlCommand(query13, connection12);

                    connection12.Open();
                    SqlDataReader reader13 = command113.ExecuteReader();

                    while (reader13.Read())
                    {

                        // textBoxProductName.Text = reader12["Name"].ToString();
                        textBoxProductCategory.Text = reader13["SubCategoryName"].ToString();
                        // textBoxPrice.Text = reader12["SalePrice"].ToString();
                        // int unit_id = Convert.ToInt32(reader12["UnitID"]);
                        //  GetUnitName(unit_id);
                    }
                    reader13.Close();
                    connection12.Close();




                    //See Currently Stock
                    //textBoxCurrentStock.Text = Currently_Stock().ToString();
                    //if (textBoxProductCategory.Text != "")
                    //{
                    //    this.ActiveControl = textBoxQuantity;

                    //}

                }
                catch (Exception)
                {
                    textBoxPdoductId.Text = "";
                    textBoxProductCategory.Text = "";
                    textBoxProductName.Text = "";

                    textBoxCurrentStock.Text = "";
                    textBoxUnitType.Text = "";
                }
            }
        }

        private void dataGridViewSales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxPdoductId.Text = textBoxProductName.Text = textBoxQuantity.Text = textBoxUnitType.Text = "";
            textBoxPdoductId.Text = dataGridViewSales.SelectedRows[0].Cells[0].Value.ToString();
            textBoxProductName.Text = dataGridViewSales.SelectedRows[0].Cells[1].Value.ToString();
            comboBoxWarehouse.Text = dataGridViewSales.SelectedRows[0].Cells[2].Value.ToString();
            comboBoxFloor.Text = dataGridViewSales.SelectedRows[0].Cells[3].Value.ToString();
            textBoxQuantity.Text = dataGridViewSales.SelectedRows[0].Cells[4].Value.ToString();
            textBoxUnitType.Text = dataGridViewSales.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void buttonReports_Click_1(object sender, EventArgs e)
        {
            

            

        }

        private void buttonSale_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure, you will Sale these product?", "Sale Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                return;
            }
            else
            {
                try
                {
                    if (textBoxCompanyAddress.Text == "")
                    {
                        MessageBox.Show("Please select a valid Customer..");
                    }
                    else
                    {
                        SqlConnection con = new SqlConnection(conStr);
                        con.Open();
                        int countSale = CountSaleNo();
                        countSale = countSale + 1;
                        SerialNo = SNo + countSale.ToString("D6");
                        int id = GetCustId(textBoxCustomerName.Text);
                        int n = 0;

                        foreach (DataGridViewRow row in dataGridViewSales.Rows)
                        {
                            int prod_id = Convert.ToInt32(dataGridViewSales.Rows[n].Cells[0].Value);
                            // double purchaseProductPrice = Convert.ToDouble(dataGridViewSales.Rows[n].Cells[4].Value);
                            double quantity = Convert.ToDouble(dataGridViewSales.Rows[n].Cells[4].Value);
                            int wareHouseId = Convert.ToInt32(dataGridViewSales.Rows[n].Cells[6].Value);
                            int floorId = Convert.ToInt32(dataGridViewSales.Rows[n].Cells[7].Value);

                            //string query = "INSERT INTO Purchase(PurchaseNo,CompanyID, PurchaseDate, SupplierID, PurchaseSupplierInvoiceNo, PurchaseRemarks, PurchaseProductID, PurchaseProductPrice, PurchaseQuantity, PurchaseTotal, PurchaseWarehouseID, PurchaseFloorID) VALUES('" + SerialNo + "', '" + CompanyID + "', '" + textBoxDate.Text + "', '" + comboBoxSupplierName.SelectedValue + "', '" + textBoxSupplierInvoiceNo.Text + "', '" + textBoxRemarks.Text + "', '" + prod_id + "', 0, '" + quantity + "' , 0 , '" + wareHouseId + "', '" + floorId + "' )";
                            string query = "INSERT INTO Sales (CompanyID, SalesNo, SalesDate, SalesTime, SalesCustomerID, SalesRemarks, Reference, SalesProductID, SalesPurchasePrice, SalesSalePrice, SalesQuantity, SalesProductDiscount, SalesTotal, SalesCustomerName, SalesSoldBy, SalesReceivedAmount, SalesChangeAmount, SalesVatRate, SalesVatTotal, SalesPuechaseBy, SalesPurchaseByContact, PaymentType, WareHouseID, FloorID)" +
                                                          " VALUES ('" + CompanyID + "', '" + SerialNo + "', '" + textBoxDate.Text + "', '" + textBoxTime.Text + "', '" + id + "', '" + textBoxRemarks.Text + "', '" + textBoxReference.Text + "', '" + prod_id + "', 0, 0, '" + quantity + "',0,0, '" + textBoxCustomerName.Text + "', '" + currentuser + "', 0, 0, 0,  0,  '" + textBoxPurchaseBy.Text + "', '" + textBoxPruchaseByContact.Text + "', 0, '" + wareHouseId+ "', '" + floorId + "')";
                            SqlCommand cmd = new SqlCommand(query, con);

                            cmd.ExecuteNonQuery();

                            UpdateProductDetails(prod_id, quantity, wareHouseId, floorId);
                            n++;

                        }
                        con.Close();



                        MessageBox.Show("Sale Successfully....!!!!");
                        dt.Rows.Clear();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            }

        private void comboBoxFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(comboBoxWarehouse.SelectedValue.ToString(), out val);
            textBoxCurrentStock.Text = Currently_Stock(val).ToString();
        }

        private double Currently_Stock(int val)
        {

            double stock = 0.0;

            string conStrPross = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
            SqlConnection connectionPross = new SqlConnection(conStrPross);
            // string queryPross = "SELECT * FROM Product WHERE ID = '" + Convert.ToInt32(textBoxPdoductCode.Text) + "'";
            string queryPross = " select stock from productDetails where WarehouseID = '" + val + "' and ProductId = '" + textBoxPdoductId.Text + "' AND RackID = '" + comboBoxFloor.SelectedValue + "' ";
            SqlCommand commandPross = new SqlCommand(queryPross, connectionPross);
            connectionPross.Open();
            SqlDataReader readerPross = commandPross.ExecuteReader();

            while (readerPross.Read())
            {
                stock = Convert.ToDouble(readerPross["Stock"]);
            }

            readerPross.Close();
            connectionPross.Close();
            return stock;
        }
    }
}
