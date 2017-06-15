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
    public partial class PurchaseReturn : Form
    {
        public PurchaseReturn()
        {
            InitializeComponent();
            textBoxQuantity.KeyPress += new KeyPressEventHandler(textBoxQuantity_KeyPress_1);
            labelInvoiceNo.Text = "Products Against Invoice No : ";
        }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PosConString"].ToString());
        private void DataGrid(string InvoiceNo)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT PurchaseID as Code, PurchaseProductID as ID, Name, PurchasePrice as Price, PurchaseQuantity as Quantity, PurchaseTotal as Total FROM Product, Purchase WHERE PurchaseNo = '" + InvoiceNo + "' AND Purchase.PurchaseProductID = Product.ID ORDER BY Purchase.PurchaseID ASC";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewSalesReturn.DataSource = dt;
            con.Close();
        }
        private void buttonSearch_Click_1(object sender, EventArgs e)
        {
            string InvoiceNo = textBoxInvoiceNo.Text;
            textBoxInvoiceNoHidden.Text = textBoxInvoiceNo.Text;
            DataGrid(InvoiceNo);
            labelInvoiceNo.Text = "Products Against Invoice No : " + InvoiceNo;
        }

        
        private void Clear_all()
        {
            textBoxName.Text = "";
            textBoxPrice.Text = "";
            textBoxQuantity.Text = "";
            
            textBoxProductID.Text = "";
        }
        private void dataGridViewSalesReturn_DoubleClick_1(object sender, EventArgs e)
        {
            Clear_all();
            textBoxDetails_id.Text = dataGridViewSalesReturn.SelectedRows[0].Cells[0].Value.ToString();
            textBoxProductID.Text = dataGridViewSalesReturn.SelectedRows[0].Cells[1].Value.ToString();
            textBoxName.Text = dataGridViewSalesReturn.SelectedRows[0].Cells[2].Value.ToString();
            textBoxPrice.Text = dataGridViewSalesReturn.SelectedRows[0].Cells[3].Value.ToString();
            textBoxQuantity.Text = dataGridViewSalesReturn.SelectedRows[0].Cells[4].Value.ToString();
            
            textBoxquantity_Previous.Text = dataGridViewSalesReturn.SelectedRows[0].Cells[4].Value.ToString();

        }
        SqlConnection con11 = new SqlConnection(ConfigurationManager.ConnectionStrings["PosConString"].ToString());
        private void DEl_Zero_Quantity()
        {
            SqlConnection con112 = new SqlConnection(ConfigurationManager.ConnectionStrings["PosConString"].ToString());
            string query12 = @"DELETE FROM Purchase WHERE  PurchaseQuantity <= 0";
            SqlCommand command12 = new SqlCommand(query12, con112);
            con112.Open();
            command12.ExecuteNonQuery();
            con112.Close();
        }
        private void Update_Sales_Details(int final_quantity, int total, string hiddeninvoiceno, int prod_id, string Details_id)
        {
            string query11 = "UPDATE Purchase SET PurchaseQuantity = '" + final_quantity + "', PurchaseTotal = '" + total + "'  WHERE PurchaseID = '" + Details_id + "'";
            SqlCommand command11 = new SqlCommand(query11, con11);
            con11.Open();
            int rowEffict11 = command11.ExecuteNonQuery();
            if (rowEffict11 > 0)
            {
                DEl_Zero_Quantity();
                DataGrid(hiddeninvoiceno);

            }
            con11.Close();
        }

        //private void Update_Sales_Total(int ftotal, string hiddeninvoiceno)
        //{
        //    string query11 = "UPDATE Purchase SET PurchaseTotal = '" + ftotal + "'WHERE PurchaseNo = '" + hiddeninvoiceno + "'";
        //    SqlCommand command11 = new SqlCommand(query11, con11);
        //    con11.Open();
        //    command11.ExecuteNonQuery();
        //    con11.Close();
        //}
        public void Purchase_Return(int pro_id, string Date, string hiddeninvoiceno, int price, int quantity, int total)
        {
            string query11 = "INSERT INTO PurchaseReturn (Date, InvoiceNo, ProductID, PurchasePrice, Quantity, Total) VALUES('" + Date + "','" + hiddeninvoiceno + "','" + pro_id + "','" + price + "','" + quantity + "','" + total + "')";
            SqlCommand command11 = new SqlCommand(query11, con11);
            con11.Open();
            command11.ExecuteNonQuery();
            con11.Close();
        }

        private void Update_Product_Details(int pros_id, int fstock)
        {
            SqlConnection con22 = new SqlConnection(ConfigurationManager.ConnectionStrings["PosConString"].ToString());
            string query1111 = "UPDATE Product SET Stock = '" + fstock + "' WHERE ID = '" + pros_id + "'";
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
        private void buttonReturn_Click_1(object sender, EventArgs e)
        {
            try
            {
                int prod_id = Convert.ToInt32(textBoxProductID.Text);
                int price = Convert.ToInt32(textBoxPrice.Text);
                int quantity = Convert.ToInt32(textBoxQuantity.Text);
               
                int previous_quantity = Convert.ToInt32(textBoxquantity_Previous.Text);
                int final_quantity = previous_quantity - quantity;
                string Details_id = textBoxDetails_id.Text;
                string hiddeninvoiceno = textBoxInvoiceNoHidden.Text;
                string Date = textBoxDate.Text;

                int total;
                total = (final_quantity * Convert.ToInt32(textBoxPrice.Text));
                if (textBoxProductID.Text == "")
                {
                    MessageBox.Show("Please Select a product in Data Grid.....");
                }
                else if (textBoxName.Text == "")
                {
                    MessageBox.Show("Please Select a product in Data Grid.....");
                }
                else if (final_quantity < 0)
                {
                    MessageBox.Show("Product Quantity is not Correct.....");
                }
                else if (textBoxPrice.Text == "")
                {
                    MessageBox.Show("Please Select a product in Data Grid.....");
                }
               
                else
                {
                    DialogResult dr = MessageBox.Show("Are you sure, you will return " + "( " + textBoxQuantity.Text + " )" + " product?", "Sales Return", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        Purchase_Return(prod_id, Date, hiddeninvoiceno, price, quantity, quantity * price);
                        Update_Sales_Details(final_quantity, total, hiddeninvoiceno, prod_id, Details_id);
                        
                        //Total Amount in Sales Table Start

                        string query11 = "SELECT PurchaseTotal FROM Purchase WHERE PurchaseNo = '" + hiddeninvoiceno + "'";
                        SqlCommand command11 = new SqlCommand(query11, con11);
                        con11.Open();
                        SqlDataReader reader = command11.ExecuteReader();
                        int sales_pre_total = 0;
                        while (reader.Read())
                        {
                            sales_pre_total = Convert.ToInt32(reader["PurchaseTotal"]);
                        }
                        reader.Close();
                        con11.Close();
                        //Total Amount in Sales Table End
                        //int ftotal = sales_pre_total - (quantity * Convert.ToInt32(textBoxPrice.Text));
                        //Update_Sales_Total(ftotal, hiddeninvoiceno);

                       int pre_stockss = 0;
                        pre_stockss = StockINProduct(prod_id);
                        //MessageBox.Show(pre_stockss.ToString());
                        int fpre_stockss = 0;
                        fpre_stockss = pre_stockss - quantity;
                        //MessageBox.Show(fpre_stockss.ToString());
                        Update_Product_Details(prod_id, fpre_stockss);

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Select a Product on Data Grid.....!!!!!!");
            }
        }

        private void textBoxQuantity_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void buttonClear_Click_1(object sender, EventArgs e)
        {
            textBoxProductID.Text = textBoxName.Text = textBoxPrice.Text = textBoxQuantity.Text = "";
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
            string sql = "SELECT * FROM Purchase";
            SqlCommand cmd = new SqlCommand(sql, conSS);
            SqlDataReader sdr = null;
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                col.Add(sdr["PurchaseNo"].ToString());
            }
            sdr.Close();
            textBoxInvoiceNo.AutoCompleteCustomSource = col;
            conSS.Close();
        }
        private void PurchaseReturn_Load(object sender, EventArgs e)
        {
            Auto_Complete();
            DateTime now = DateTime.Now;
            textBoxDate.Text = now.ToString("yyyy-MM-dd");
        }

        private void textBoxInvoiceNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
