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
    public partial class ItemSettingEdit : Form
    {
        public ItemSettingEdit()
        {
            InitializeComponent();
            //Category state
            FillCateMainCate();
            //Sub Category state
            FillSubMainCategory();
            //FillSubCatetegory();
            //Product state
            FillProMainCategory();
            //FillProCategory();
           // FillProSubCategory();



        }
        private void FillCateMainCate()
        {
            string query12 = "SELECT * FROM CategoryMain";
            fillCombo(comboBoxCateMainCategory, query12, "MaincategoryName", "MainCategoryID");
        }
        private void FillSubMainCategory()
        {
            string query12 = "SELECT * FROM CategoryMain";
            fillCombo(comboBoxSubMainCategory, query12, "MaincategoryName", "MainCategoryID");
        }
        private void FillSubCatetegory(int main_cate)
        {
            string query12 = "SELECT * FROM Category WHERE MaincategoryID='" + main_cate + "'";
            fillCombo(comboBoxSubCatetegory, query12, "CategoryName", "CategoryID");
        }
        //Product state
        private void FillProMainCategory()
        {
            string query12 = "SELECT * FROM CategoryMain";
            fillCombo(comboBoxProMainCategory, query12, "MaincategoryName", "MainCategoryID");
        }
        private void FillProCategory(int main_cate)
        {
            string query12 = "SELECT * FROM Category WHERE MaincategoryID='" + main_cate + "'";
            fillCombo(comboBoxProCategory, query12, "CategoryName", "CategoryID");
        }
        private void FillProSubCategory(int cate_id)
        {
            string query12 = "SELECT * FROM CategorySub WHERE CategoryID='" + cate_id + "'";
            fillCombo(comboBoxProSubCategory, query12, "SubCategoryName", "SubCategoryID");
        }

        public void DataGridMainCate()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PosConString"].ToString());
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT MaincategoryName as 'Name',  MainCategoryID as 'ID' FROM CategoryMain";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewMainCategory.DataSource = dt;
            con.Close();
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
        private void ItemSettingEdit_Load(object sender, EventArgs e)
        {
            DataGridMainCate();
        }
        public void CateMainCategory(int maincate_id)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PosConString"].ToString());
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT CategoryName as 'Name',  CategoryID as 'ID' FROM Category WHERE MaincategoryID='" + maincate_id+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewCategory.DataSource = dt;
            con.Close();
        }
        private void comboBoxCateMainCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id;
            Int32.TryParse(comboBoxCateMainCategory.SelectedValue.ToString(), out id);
            CateMainCategory(id);
        }

        private void comboBoxSubMainCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id;
            Int32.TryParse(comboBoxSubMainCategory.SelectedValue.ToString(), out id);
            FillSubCatetegory(id);
        }
        public void SubCatetegory(int cate_id)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PosConString"].ToString());
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT SubCategoryName as 'Name',  SubCategoryID as 'ID' FROM CategorySub WHERE CategoryID='" + cate_id + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewSubCategory.DataSource = dt;
            con.Close();
        }
        private void comboBoxSubCatetegory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id;
            Int32.TryParse(comboBoxSubCatetegory.SelectedValue.ToString(), out id);
            SubCatetegory(id);

        }

        private void comboBoxProMainCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id;
            Int32.TryParse(comboBoxProMainCategory.SelectedValue.ToString(), out id);
            FillProCategory(id);
        }

        private void comboBoxProCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id;
            Int32.TryParse(comboBoxProCategory.SelectedValue.ToString(), out id);
            FillProSubCategory(id);
        }
        public void ProSubCategory(int subcate_id)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PosConString"].ToString());
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Name as 'Name',  ID as 'ID' FROM Product WHERE SubCategoryID='" + subcate_id + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewProduct.DataSource = dt;
            con.Close();
        }
        private void comboBoxProSubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id;
            Int32.TryParse(comboBoxProSubCategory.SelectedValue.ToString(), out id);
            ProSubCategory(id);
        }

        private void dataGridViewMainCategory_DoubleClick(object sender, EventArgs e)
        {
            textBoxMainCategory.Text = textBoxMainCateID.Text = "";
            textBoxMainCategory.Text = dataGridViewMainCategory.SelectedRows[0].Cells[0].Value.ToString();
            textBoxMainCateID.Text = dataGridViewMainCategory.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void dataGridViewCategory_DoubleClick(object sender, EventArgs e)
        {
            textBoxCategory.Text = textBoxCateID.Text = "";
            textBoxCategory.Text = dataGridViewCategory.SelectedRows[0].Cells[0].Value.ToString();
            textBoxCateID.Text = dataGridViewCategory.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void dataGridViewSubCategory_DoubleClick(object sender, EventArgs e)
        {
            textBoxSubCategory.Text = textBoxSubCateID.Text = "";
            textBoxSubCategory.Text = dataGridViewSubCategory.SelectedRows[0].Cells[0].Value.ToString();
            textBoxSubCateID.Text = dataGridViewSubCategory.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void dataGridViewProduct_DoubleClick(object sender, EventArgs e)
        {
            textBoxProduct.Text = textBoxProID.Text = "";
            textBoxProduct.Text = dataGridViewProduct.SelectedRows[0].Cells[0].Value.ToString();
            textBoxProID.Text = dataGridViewProduct.SelectedRows[0].Cells[1].Value.ToString();
        }
        string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
        private void buttonUpdateMainCate_Click(object sender, EventArgs e)
        {
            if (textBoxMainCategory.Text=="")
            {
                MessageBox.Show("Please Double Click in Data Grid View...");
            }
            else if (textBoxMainCateID.Text=="")
            {
                MessageBox.Show("Please Double Click in Data Grid View...");
            }
            else
            {
                try
                {
                    string main_cate_name = textBoxMainCategory.Text;
                    int main_cate_id = Convert.ToInt32(textBoxMainCateID.Text);
                    SqlConnection connection1 = new SqlConnection(conStr);
                    string query1 = "UPDATE CategoryMain SET MaincategoryName = '" + main_cate_name + "' WHERE MainCategoryID = '" + main_cate_id + "'";
                    SqlCommand command1 = new SqlCommand(query1, connection1);
                    connection1.Open();
                    int rowEffict1 = command1.ExecuteNonQuery();
                    connection1.Close();
                    if (rowEffict1>0)
                    {
                        DataGridMainCate();
                        FillCateMainCate();
                        textBoxMainCategory.Text = textBoxMainCateID.Text = "";
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonUpdateCate_Click(object sender, EventArgs e)
        {
            if (textBoxCategory.Text == "")
            {
                MessageBox.Show("Please Double Click in Data Grid View...");
            }
            else if (textBoxCateID.Text == "")
            {
                MessageBox.Show("Please Double Click in Data Grid View...");
            }
            else
            {
                try
                {
                    string cate_name = textBoxCategory.Text;
                    int cate_id = Convert.ToInt32(textBoxCateID.Text);
                    SqlConnection connection1 = new SqlConnection(conStr);
                    string query1 = "UPDATE Category SET CategoryName = '" + cate_name + "' WHERE CategoryID = '" + cate_id + "'";
                    SqlCommand command1 = new SqlCommand(query1, connection1);
                    connection1.Open();
                    int rowEffict1 = command1.ExecuteNonQuery();
                    connection1.Close();
                    if (rowEffict1 > 0)
                    {
                        comboBoxCateMainCategory_SelectedIndexChanged(sender, e);
                        textBoxCategory.Text = textBoxCateID.Text = "";
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonUpdateSubCate_Click(object sender, EventArgs e)
        {
            if (textBoxSubCategory.Text == "")
            {
                MessageBox.Show("Please Double Click in Data Grid View...");
            }
            else if (textBoxSubCateID.Text == "")
            {
                MessageBox.Show("Please Double Click in Data Grid View...");
            }
            else
            {
                try
                {
                    string sub_cate_name = textBoxSubCategory.Text;
                    int sub_cate_id = Convert.ToInt32(textBoxSubCateID.Text);
                    SqlConnection connection1 = new SqlConnection(conStr);
                    string query1 = "UPDATE CategorySub SET SubCategoryName = '" + sub_cate_name + "' WHERE SubCategoryID = '" + sub_cate_id + "'";
                    SqlCommand command1 = new SqlCommand(query1, connection1);
                    connection1.Open();
                    int rowEffict1 = command1.ExecuteNonQuery();
                    connection1.Close();
                    if (rowEffict1 > 0)
                    {
                        comboBoxSubCatetegory_SelectedIndexChanged(sender, e);
                        textBoxSubCategory.Text = textBoxSubCateID.Text = "";
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonUpdatePro_Click(object sender, EventArgs e)
        {
            if (textBoxProduct.Text == "")
            {
                MessageBox.Show("Please Double Click in Data Grid View...");
            }
            else if (textBoxProID.Text == "")
            {
                MessageBox.Show("Please Double Click in Data Grid View...");
            }
            else
            {
                try
                {
                    string pro_name = textBoxProduct.Text;
                    int pro_id = Convert.ToInt32(textBoxProID.Text);
                    SqlConnection connection1 = new SqlConnection(conStr);
                    string query1 = "UPDATE Product SET Name = '" + pro_name + "' WHERE ID = '" + pro_id + "'";
                    SqlCommand command1 = new SqlCommand(query1, connection1);
                    connection1.Open();
                    int rowEffict1 = command1.ExecuteNonQuery();
                    connection1.Close();
                    if (rowEffict1 > 0)
                    {
                        comboBoxProSubCategory_SelectedIndexChanged(sender, e);
                        textBoxProduct.Text = textBoxProID.Text = "";
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
    }
}
