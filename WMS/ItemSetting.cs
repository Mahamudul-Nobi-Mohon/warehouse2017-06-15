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
    public partial class ItemSetting : Form
    {
        public ItemSetting()
        {
            InitializeComponent();
            textBoxPurchasePrice.KeyPress += new KeyPressEventHandler(textBoxPurchasePrice_KeyPress);
            textBoxSalePrice.KeyPress += new KeyPressEventHandler(textBoxSalePrice_KeyPress);
            textBoxMinimumProduct.KeyPress += new KeyPressEventHandler(textBoxMinimumProduct_KeyPress);
            string query = "SELECT * FROM CategoryMain";
            fillCombo(comboBoxMainCategory, query, "MaincategoryName", "MainCategoryID");
            fillCombo(comboBoxAddMain, query, "MaincategoryName", "MainCategoryID");
            fillCombo(comboBoxAddMainCateS4, query, "MaincategoryName", "MainCategoryID");

            string query1 = "SELECT * FROM CategoryMain";
            fillCombo(comboBoxP1, query1, "MaincategoryName", "MainCategoryID");

            string queryUnit = "SELECT * FROM Unit";
            fillCombo(comboBoxAddUnit, queryUnit, "UnitName", "UnitID");

            string query22 = "SELECT * FROM LocationMain";
            fillCombo(comboBoxWarehouse, query22, "LocationMainName", "LocationMainID");

            query22 = "SELECT * FROM Location";
            fillCombo(comboBoxRack, query22, "LocationName", "LocationID");

            query22 = "SELECT * FROM LocationSub";
            fillCombo(comboBoxCell, query22, "LocationSubName", "LocationSubID");
        }
        string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PosConString"].ToString());
        SqlCommand command;
        SqlDataAdapter adapter;
        DataTable table;
        public void fillCombo(ComboBox combo, string query, string displayMember, string valueMember)
        {
            command = new SqlCommand(query, con);
            adapter = new SqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            combo.DataSource = table;
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;
        }
        private int Get_MainCategory(string name)
        {
            int exist = 0;
            SqlConnection con = new SqlConnection(conStr);
            string query = "SELECT * FROM CategoryMain WHERE MaincategoryName='" + name + "'";
            SqlCommand command = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                exist = Convert.ToInt32(reader["MainCategoryID"]);
            }

            reader.Close();
            con.Close();
            return exist;
        }
        private int Get_Category(int main_id, string name)
        {
            int exist = 0;
            SqlConnection con = new SqlConnection(conStr);
            string query = "SELECT * FROM Category WHERE CategoryName='" + name + "' AND MaincategoryID ='" + main_id + "'";
            SqlCommand command = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                exist = Convert.ToInt32(reader["CategoryID"]);
            }

            reader.Close();
            con.Close();
            return exist;
        }
        private int Get_Sub_Category(int val2, string name)
        {
            int exist = 0;
            SqlConnection con = new SqlConnection(conStr);
            string query = "SELECT * FROM CategorySub WHERE SubCategoryName='" + name + "' AND CategoryID='" + val2 + "'";
            SqlCommand command = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                exist = Convert.ToInt32(reader["SubCategoryID"]);
            }

            reader.Close();
            con.Close();
            return exist;
        }
     

        //private void Insert_product_detail(int Id)
        //{
        //    int v = 0;
        //    string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
        //    SqlConnection connection = new SqlConnection(conStr);
        //    string query112 = "INSERT INTO Product() VALUES('" + Id + "','" + v + "','" + v + "','" + v + "','" + v + "','" + v + "','" + v + "',1)";
        //    SqlCommand command = new SqlCommand(query112, connection);
        //    connection.Open();
        //    int rowEffict = command.ExecuteNonQuery();
        //    connection.Close();


        //}
        private int Get_Pro_Category(int val23, string name)
        {
            int exist = 0;
            SqlConnection con = new SqlConnection(conStr);
            string query = "SELECT * FROM Product WHERE Name='" + name + "' AND SubCategoryID='" + val23 + "'";
            SqlCommand command = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                exist = Convert.ToInt32(reader["ID"]);
            }

            reader.Close();
            con.Close();
            return exist;
        }
        private void Insert_product_Code(int Id)
        {

            string code = "P";
            code = code + Id.ToString("D4");
            string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
            SqlConnection connection = new SqlConnection(conStr);
            string query112 = "UPDATE [Product] SET Code = '" + code + "' WHERE ID = '" + Id + "'";
            SqlCommand command = new SqlCommand(query112, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        private string GetUnitName(int unit_id)
        {
            string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
            SqlConnection con = new SqlConnection(conStr);
            string unit_name = "";
            string query = "SELECT * FROM Unit WHERE UnitID = " + unit_id;
            SqlCommand command112 = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader12 = command112.ExecuteReader();
            while (reader12.Read())
            {
                unit_name = reader12["UnitName"].ToString();
            }
            reader12.Close();
            con.Close();
            return unit_name;
        }
        private void ItemSetting_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddMainCategory_Click(object sender, EventArgs e)
        {
            if (textBoxAddMainCategory.Text == "")
            {
                MessageBox.Show("Please fill the textbox..");
            }
            else if (Get_MainCategory(textBoxAddMainCategory.Text) > 0)
            {
                textBoxAddMainCategory.Text = "";
                MessageBox.Show("**********MainCategory Name is Already Exits!!!***********");

            }
            else
            {
                string addMainCate = textBoxAddMainCategory.Text;
                SqlConnection connection = new SqlConnection(conStr);
                string query = "INSERT INTO CategoryMain(MaincategoryName) VALUES('" + addMainCate + "')";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                int rowEffict = command.ExecuteNonQuery();
                connection.Close();
                if (rowEffict > 0)
                {
                    textBoxAddMainCategory.Text = string.Empty;
                    string query11 = "SELECT * FROM CategoryMain";
                    fillCombo(comboBoxMainCategory, query11, "MaincategoryName", "MainCategoryID");
                    fillCombo(comboBoxP1, query11, "MaincategoryName", "MainCategoryID");
                    MessageBox.Show("Main Category Insert Successfully !");
                }
            }
        }

        private void buttonAddCatecory_Click(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(comboBoxMainCategory.SelectedValue.ToString(), out val);
            if (textBoxAddCate.Text == "" && comboBoxMainCategory.SelectedText == "")
            {
                MessageBox.Show("Please fill the textbox..");
            }
            else if (Get_Category(val, textBoxAddCate.Text) > 0)
            {
                textBoxAddCate.Text = "";
                MessageBox.Show("**********Category Name is Already Exits!!!***********");

            }
            else
            {

                string addCate = textBoxAddCate.Text;
                SqlConnection connection = new SqlConnection(conStr);
                string query = "INSERT INTO Category(MaincategoryID,CategoryName) VALUES('" + val + "','" + addCate + "')";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                int rowEffict = command.ExecuteNonQuery();
                connection.Close();
                if (rowEffict > 0)
                {
                    textBoxAddCate.Text = string.Empty;
                    string query11 = "SELECT * FROM CategoryMain";
                    fillCombo(comboBoxAddMain, query11, "MaincategoryName", "MainCategoryID");
                    MessageBox.Show("Category Insert Successfully !");
                }
            }
        }

        private void btnAddSubCategory_Click(object sender, EventArgs e)
        {
            try
            {
                int val2;
                Int32.TryParse(comboBoxAddCat.SelectedValue.ToString(), out val2);

                if (txtAddSubCate.Text == "")
                {
                    MessageBox.Show("Please Fill all information....");
                }
                else if (Get_Sub_Category(val2, txtAddSubCate.Text) > 0)
                {
                    txtAddSubCate.Text = "";
                    MessageBox.Show("**********SubCategory Name is Already Exits!!!***********");

                }
                else
                {
                    int val1;
                    Int32.TryParse(comboBoxAddMain.SelectedValue.ToString(), out val1);



                    string addSubCate = txtAddSubCate.Text;
                    string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
                    SqlConnection connection = new SqlConnection(conStr);
                    string query11 = "INSERT INTO CategorySub(MainCategoryID,CategoryID,SubCategoryName) VALUES('" + val1 + "','" + val2 + "','" + addSubCate + "')";
                    SqlCommand command = new SqlCommand(query11, connection);
                    connection.Open();
                    int rowEffict = command.ExecuteNonQuery();
                    connection.Close();
                    if (rowEffict > 0)
                    {
                        string query1111 = "SELECT * FROM CategoryMain";
                        fillCombo(comboBoxAddMainCateS4, query1111, "MaincategoryName", "MainCategoryID");
                        txtAddSubCate.Text = string.Empty;
                        MessageBox.Show("Sub Category Insert Successfully !");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAddProductS4_Click(object sender, EventArgs e)
        {

            try
            {
                int val23;
                Int32.TryParse(comboBoxAddSubCateS4.SelectedValue.ToString(), out val23);
                if (textBoxAddProductS4.Text == "")
                {
                    MessageBox.Show("Please Fill all information....");
                }
                else if (Get_Pro_Category(val23, textBoxAddProductS4.Text) > 0)
                {
                    textBoxAddProductS4.Text = "";
                    MessageBox.Show("**********Product Name is Already Exits!!!***********");

                }
                else
                {
                    int val12;
                    Int32.TryParse(comboBoxAddMainCateS4.SelectedValue.ToString(), out val12);

                    int val22;
                    Int32.TryParse(comboBoxAddCateS4.SelectedValue.ToString(), out val22);
                    int zero = 0;
                    string pro_name = textBoxAddProductS4.Text;
                    string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
                    SqlConnection connection = new SqlConnection(conStr);
                    string query112 = "INSERT INTO Product(MainCateID,CategoryID,SubCategoryID,Name,Code,PurchasePrice,SalePrice,Description,UnitID,MinimumProductQuantity,Status) OUTPUT INSERTED.ID VALUES('" + val12 + "','" + val22 + "','" + val23 + "','" + pro_name + "','" + zero + "','" + zero + "','" + zero + "','" + zero + "','" + zero + "','" + zero + "','" + zero + "')";
                    SqlCommand command = new SqlCommand(query112, connection);
                    connection.Open();

                    //int rowEffict = command.ExecuteNonQuery();
                    int newId = (Int32)command.ExecuteScalar();
                    connection.Close();
                    if (newId > 0)
                    {
                        //Insert_product_detail(newId);
                        Insert_product_Code(newId);
                        textBoxAddProductS4.Text = string.Empty;
                        MessageBox.Show("Product Insert Successfully !");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            
            //string conStrProd = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
            //SqlConnection connection11 = new SqlConnection(conStrProd);
            //string query = "SELECT * FROM Product Where ID ='" + prod_id + "'";
            //SqlCommand command1 = new SqlCommand(query, connection11);

            //connection11.Open();
            //SqlDataReader reader = command1.ExecuteReader();
            //while (reader.Read())
            //{
            //    textBoxProductStock.Text = reader["Stock"].ToString();
            //}
            //connection11.Close();
            try
            {

                if (comboBoxP4.SelectedValue.ToString() =="")
                {
                    MessageBox.Show("Please Fill the all Field...");
                }
                
                else
                {
                    int prod_id;
                    Int32.TryParse(comboBoxP4.SelectedValue.ToString(), out prod_id);
                    //double purchase_price = Convert.ToDouble(textBoxPurchasePrice.Text);
                    //double sale_price = Convert.ToDouble(textBoxSalePrice.Text);
                   
                    //double minimum_pro_quantity = Convert.ToDouble(textBoxMinimumProduct.Text);

                    int unit_id;
                    Int32.TryParse(comboBoxAddUnit.SelectedValue.ToString(), out unit_id);
                    //Warehouse Start

                    int WarehouseID;
                    Int32.TryParse(comboBoxWarehouse.SelectedValue.ToString(), out WarehouseID);

                    int RackID;
                    Int32.TryParse(comboBoxRack.SelectedValue.ToString(), out RackID);

                    int CellID;
                    Int32.TryParse(comboBoxCell.SelectedValue.ToString(), out CellID);

                    //Warehouse End
                    string product_description = textBoxProductDiscription.Text;

                    string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
                    SqlConnection connection = new SqlConnection(conStr);
                    string query11 = "UPDATE Product SET UnitID = '" + unit_id + "' WHERE ID = '" + prod_id + "'";
                    //string query11 = "UPDATE Product SET PurchasePrice = '" + purchase_price + "',SalePrice = '" + sale_price + "', MinimumProductQuantity = '" + minimum_pro_quantity + "',UnitID = '" + unit_id + "',WarehouseID = '" + WarehouseID + "',RackID = '" + RackID + "',CellID = '" + CellID + "' WHERE ID = '" + prod_id + "'";
                    //string query11 = "INSERT INTO product_details VALUES('" + prod_id + "','" + purchase_price + "','" + sale_price + "','" + product_stock + "','" + product_description + "','" + unit_id + "',1)";
                    SqlCommand command = new SqlCommand(query11, connection);
                    connection.Open();
                    int rowEffict11 = command.ExecuteNonQuery();
                    connection.Close();
                    if (rowEffict11 > 0)
                    {
                        textBoxPurchasePrice.Text = textBoxSalePrice.Text = textBoxMinimumProduct.Text = string.Empty;
                        textBoxProductDiscription.Text = string.Empty;
                        //ShowTreeViewItem(); 
                        MessageBox.Show("Product Add Successfully !");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxAddMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(comboBoxAddMain.SelectedValue.ToString(), out val);
            string query = "SELECT * FROM Category WHERE MaincategoryID = " + val;

            fillCombo(comboBoxAddCat, query, "CategoryName", "CategoryID");
        }

        private void comboBoxAddMainCateS4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int vals4;
            Int32.TryParse(comboBoxAddMainCateS4.SelectedValue.ToString(), out vals4);
            string query = "SELECT * FROM Category WHERE MaincategoryID = " + vals4;

            fillCombo(comboBoxAddCateS4, query, "CategoryName", "CategoryID");
        }

        private void comboBoxAddCateS4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int vals41;
            Int32.TryParse(comboBoxAddCateS4.SelectedValue.ToString(), out vals41);
            string query = "SELECT * FROM CategorySub WHERE CategoryID = " + vals41;

            fillCombo(comboBoxAddSubCateS4, query, "SubCategoryName", "SubCategoryID");
        }

        private void comboBoxP1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(comboBoxP1.SelectedValue.ToString(), out val);
            string query = "SELECT * FROM Category WHERE MaincategoryID = " + val;

            fillCombo(comboBoxP2, query, "CategoryName", "CategoryID");
        }

        private void comboBoxP2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(comboBoxP2.SelectedValue.ToString(), out val);
            string query = "SELECT * FROM CategorySub WHERE CategoryID = " + val;

            fillCombo(comboBoxP3, query, "SubCategoryName", "SubCategoryID");
        }

        private void comboBoxP3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(comboBoxP3.SelectedValue.ToString(), out val);
            string query = "SELECT * FROM Product WHERE SubCategoryID = " + val;

            fillCombo(comboBoxP4, query, "Name", "ID");
        }

        private void comboBoxP4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id;
            Int32.TryParse(comboBoxP4.SelectedValue.ToString(), out id);

            int unit_id = 0;
            string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
            SqlConnection con = new SqlConnection(conStr);
            string query = "SELECT * FROM Product WHERE ID = " + id;
            SqlCommand command112 = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader12 = command112.ExecuteReader();
            while (reader12.Read())
            {
                //        textBoxPurchasePrice.Text = reader12["PurchasePrice"].ToString();
                //        textBoxSalePrice.Text = reader12["SalePrice"].ToString();
                //        textBoxProductDiscription.Text = reader12["Description"].ToString();
                unit_id = Convert.ToInt32(reader12["UnitID"]);
                //        textBoxMinimumProduct.Text = reader12["MinimumProductQuantity"].ToString();

            }
            comboBoxAddUnit.SelectedValue = unit_id;
            reader12.Close();
            con.Close();
           
        }
        
    private void textBoxPurchasePrice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxSalePrice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxMinimumProduct_KeyPress(object sender, KeyPressEventArgs e)
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

        private void comboBoxWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(comboBoxWarehouse.SelectedValue.ToString(), out val);
            string query = "SELECT * FROM Location WHERE LocationMainID = " + val;

            fillCombo(comboBoxRack, query, "LocationName", "LocationID");
        }

        private void comboBoxRack_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(comboBoxRack.SelectedValue.ToString(), out val);
            string query = "SELECT * FROM LocationSub WHERE LocationID = " + val;

            fillCombo(comboBoxCell, query, "LocationSubName", "LocationSubID");
        }
     }
}
