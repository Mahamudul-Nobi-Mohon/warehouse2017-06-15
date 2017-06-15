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
    public partial class PurchaseEdit : Form
    {
        public PurchaseEdit()
        {
            InitializeComponent();

            string query12 = "SELECT * FROM Product";
            fillCombo(comboBoxProductCode, query12, "Code", "ID");
        }
        public static string InvoiceNoForEdit = "";
        private void PurchaseEdit_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            dateTimePickerPurchaseDate.CustomFormat = "yyyy-MM-dd";
            DateTime today = DateTime.Today;
            dateTimePicker1.Value = today;
            dateTimePicker2.Value = today;
            dateTimePickerPurchaseDate.Value = today;

        }
        private void DataGrid(string InvoiceNo)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PosConString"].ToString());
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT PurchaseID as 'PurchaseID', PurchaseSupplierInvoiceNo as 'Supplier-Invoice', PurchaseDate as 'Purchase-Date',  Product.Code as 'Product-Code', Product.Name as 'Product-Name', PurchaseProductPrice as 'Purchase-Price', PurchaseQuantity as 'Quantity',  PurchaseTotal as 'Total' FROM Purchase, Product WHERE Purchase.PurchaseNo='" + InvoiceNo + "' AND Product.ID=Purchase.PurchaseProductID";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewSalesEdit.DataSource = dt;
            con.Close();
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
                    DataGrid(comboBoxInvoiceNo.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void PurchaseEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string date1 = dateTimePicker1.Text;
            string date2 = dateTimePicker2.Text;
            string query = "SELECT DISTINCT(PurchaseNo) FROM Purchase WHERE PurchaseDate  BETWEEN '" + date1 + "' AND '" + date2 + "'";
            fillCombo(comboBoxInvoiceNo, query, "PurchaseNo", "PurchaseNo");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            string date1 = dateTimePicker1.Text;
            string date2 = dateTimePicker2.Text;
            string query = "SELECT DISTINCT(PurchaseNo) FROM Purchase WHERE PurchaseDate  BETWEEN '" + date1 + "' AND '" + date2 + "'";
            fillCombo(comboBoxInvoiceNo, query, "PurchaseNo", "PurchaseNo");
        }
        private void ClearAll()
        {
            textBoxPurchaseID.Text = "";
            textBoxSupplierInvoice.Text = "";
           
            textBoxPreviousQuantity.Text = "";
            textBoxProductID.Text = "";
        }
        private void dataGridViewSalesEdit_DoubleClick(object sender, EventArgs e)
        {
            ClearAll();
            textBoxPurchaseID.Text = dataGridViewSalesEdit.SelectedRows[0].Cells[0].Value.ToString();
            textBoxSupplierInvoice.Text = dataGridViewSalesEdit.SelectedRows[0].Cells[1].Value.ToString();
            dateTimePickerPurchaseDate.Text= dataGridViewSalesEdit.SelectedRows[0].Cells[2].Value.ToString();
            comboBoxProductCode.Text= dataGridViewSalesEdit.SelectedRows[0].Cells[3].Value.ToString();
            textBoxPreviousCode.Text = dataGridViewSalesEdit.SelectedRows[0].Cells[3].Value.ToString();
            textBoxPurchasePrice.Text = dataGridViewSalesEdit.SelectedRows[0].Cells[5].Value.ToString();
            textBoxPreviousQuantity.Text = dataGridViewSalesEdit.SelectedRows[0].Cells[6].Value.ToString();
            textBoxQuantity.Text= dataGridViewSalesEdit.SelectedRows[0].Cells[6].Value.ToString();

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PosConString"].ToString());
            string query = "SELECT * FROM Product WHERE Code = '" + comboBoxProductCode.Text + "'";
            SqlCommand command = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                textBoxProductName.Text = reader["Name"].ToString();
            }
            reader.Close();
            con.Close();


        }

        private void comboBoxProductCode_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PosConString"].ToString());
            string query = "SELECT * FROM Product WHERE Code = '" + comboBoxProductCode.Text + "'";
            SqlCommand command = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                textBoxProductName.Text = reader["Name"].ToString();
                textBoxPurchasePrice.Text = reader["PurchasePrice"].ToString();
                textBoxProductID.Text= reader["ID"].ToString();
                textBoxQuantity.Text = textBoxPreviousQuantity.Text;
                //double quantity = Convert.ToDouble(textBoxQuantity.Text);
               // textBoxTotal.Text = (Convert.ToDouble(reader["PurchasePrice"]) * quantity).ToString();
            }
            reader.Close();
            con.Close();

           
        }

        
        private void UpdateProductStockMinus(string PreCode)
        {
            try
            {
                //Find pre stock
                double Stock = 0;
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PosConString"].ToString());
                string query = "SELECT * FROM Product WHERE Code = '" + PreCode + "'";
                SqlCommand command = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Stock = Convert.ToDouble(reader["Stock"]);
                }
                reader.Close();
                con.Close();
                Stock = Stock - Convert.ToDouble(textBoxPreviousQuantity.Text);
                //Update pre stock
                SqlConnection cons = new SqlConnection(ConfigurationManager.ConnectionStrings["PosConString"].ToString());
                string querys = "UPDATE Product SET Stock = '" + Stock + "' WHERE Code = '" + PreCode + "'";
                SqlCommand commands = new SqlCommand(querys, cons);
                cons.Open();
                commands.ExecuteNonQuery();
                cons.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        private void UpdateProductStockPlus(int NewID)
        {
            try
            {
                //Find pre stock
                double Stock = 0;
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PosConString"].ToString());
                string query = "SELECT * FROM Product WHERE ID = '" + NewID + "'";
                SqlCommand command = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Stock = Convert.ToDouble(reader["Stock"]);
                }
                reader.Close();
                con.Close();
                Stock = Stock + Convert.ToDouble(textBoxQuantity.Text);
                //Update pre stock
                SqlConnection cons = new SqlConnection(ConfigurationManager.ConnectionStrings["PosConString"].ToString());
                string querys = "UPDATE Product SET Stock = '" + Stock + "' WHERE ID = '" + NewID + "'";
                SqlCommand commands = new SqlCommand(querys, cons);
                cons.Open();
                commands.ExecuteNonQuery();
                cons.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            if (textBoxPurchaseID.Text == "")
            {
                MessageBox.Show("Please Select a Row in Datagrid to Edit And then Click Update....!!!");
            }
            else if (textBoxPreviousQuantity.Text == "")
            {
                MessageBox.Show("Please Select a Row in Datagrid to Edit And then Click Update....!!!");
            }
            else if (textBoxSupplierInvoice.Text == "")
            {
                MessageBox.Show("Please Input Supplier Invoice....!!!");
            }
            else if (dateTimePickerPurchaseDate.Text == "")
            {
                MessageBox.Show("Please Input Purchase Date....!!!");
            }
            else if (comboBoxProductCode.Text == "")
            {
                MessageBox.Show("Please Input Product Code....!!!");
            }
            else if (textBoxPurchasePrice.Text == "")
            {
                MessageBox.Show("Please Input Purchase Price....!!!");
            }
            else if (textBoxQuantity.Text == "")
            {
                MessageBox.Show("Please Input Quantity....!!!");
            }
           
            else
            {
                try
                {
                    double total = Convert.ToDouble(textBoxQuantity.Text) * Convert.ToDouble(textBoxPurchasePrice.Text);
                    SqlConnection cons = new SqlConnection(ConfigurationManager.ConnectionStrings["PosConString"].ToString());
                    string querys = "UPDATE Purchase SET PurchaseDate = '" + dateTimePickerPurchaseDate.Text + "', PurchaseSupplierInvoiceNo = '" + textBoxSupplierInvoice.Text + "', PurchaseProductID = '" + textBoxProductID.Text + "', PurchaseProductPrice = '" + textBoxPurchasePrice.Text + "',PurchaseQuantity = '" + textBoxQuantity.Text + "',PurchaseTotal = '" + total + "'  WHERE PurchaseID = '" + textBoxPurchaseID.Text + "'";
                    SqlCommand commands = new SqlCommand(querys, cons);
                    cons.Open();
                    commands.ExecuteNonQuery();
                    cons.Close();
                    UpdateProductStockMinus(textBoxPreviousCode.Text);
                    UpdateProductStockPlus(Convert.ToInt32(textBoxProductID.Text));
                    DataGrid(comboBoxInvoiceNo.Text);
                   
                    MessageBox.Show("Update Successfully...!!!!");
                    //ClearAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void buttonAddMore_Click(object sender, EventArgs e)
        {
            if (comboBoxInvoiceNo.Text=="")
            {
                MessageBox.Show("There Is No Selected Invoice No...");
            }
            else
            {
                InvoiceNoForEdit = comboBoxInvoiceNo.Text;
                PurchaseMore amp = new PurchaseMore();
                amp.Show();
            }
               
        }
    }
}
