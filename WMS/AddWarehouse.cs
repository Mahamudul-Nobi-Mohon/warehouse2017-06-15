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
    public partial class AddWarehouse : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PosConString"].ToString());

        public AddWarehouse()
        {
            InitializeComponent();
        }

        private void DataGrid()
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT LocationMainID as 'ID', LocationMainName as 'Warehouse' FROM LocationMain";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewViewFloor.DataSource = dt;
            con.Close();
            dataGridViewViewFloor.Columns["ID"].Width = 70;
            dataGridViewViewFloor.Columns["Warehouse"].Width = 160;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string floor_name = textBoxWarehouseName.Text;
            
            try
            {
                if (textBoxWarehouseName.Text == "")
                {
                    MessageBox.Show("Please fill the all field...");
                }
                
                else if (Already_Floor_Name(textBoxWarehouseName.Text) > 0)
                {
                    Clear_All();
                    MessageBox.Show("Warehouse Name Already Exist....!!!");
                }

                else
                {
                    string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
                    SqlConnection connection = new SqlConnection(conStr);
                    string query11 = "INSERT INTO LocationMain  VALUES(1,'" + floor_name + "')";
                    SqlCommand command = new SqlCommand(query11, connection);
                    connection.Open();
                    int rowEffict11 = command.ExecuteNonQuery();
                    connection.Close();
                    if (rowEffict11 > 0)
                    {
                        textBoxWarehouseName.Text = string.Empty;
                        DataGrid();
                        MessageBox.Show("Warehouse Name Add Successfully !");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int Already_Floor_Name(string Floor_Name)
        {
            string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
            SqlConnection connection = new SqlConnection(conStr);
            string query = "SELECT LocationMainName FROM LocationMain WHERE LocationMainName = '" + Floor_Name + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            int rowEffict = Convert.ToInt32(reader.Read());
            connection.Close();
            return rowEffict;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxWarehouseName.Text == "")
            {
                MessageBox.Show("Please Select a Warehouse in Datagrid to Edit And then Click Update....!!!");
            }
            else
            {
                if (Already_Floor_Name(textBoxWarehouseName.Text) > 0)
                {
                    
                    MessageBox.Show("Warehouse Name Already Exist....!!!");
                }
                else
                {
                    try
                    {
                        SqlConnection cons = new SqlConnection(ConfigurationManager.ConnectionStrings["PosConString"].ToString());

                        string querys = "UPDATE LocationMain SET LocationMainName = '" + textBoxWarehouseName.Text + "'  WHERE LocationMainID = '" + textBoxFloorId.Text + "'";
                        SqlCommand commands = new SqlCommand(querys, cons);
                        cons.Open();
                        commands.ExecuteNonQuery();
                        cons.Close();
                        DataGrid();
                        buttonUpdate.Enabled = false;
                        textBoxWarehouseName.Text = "";
                        MessageBox.Show("Warehouse Name Updated Successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                }
            }
        }

        private void AddFloor_Load(object sender, EventArgs e)
        {
            DataGrid();
        }

        private void Clear_All()
        {
            textBoxWarehouseName.Text = "";
        }

        private void dataGridViewViewFloor_DoubleClick(object sender, EventArgs e)
        {
            buttonUpdate.Enabled = true;
            Clear_All();
            textBoxFloorId.Text = dataGridViewViewFloor.SelectedRows[0].Cells[0].Value.ToString();
            textBoxWarehouseName.Text = dataGridViewViewFloor.SelectedRows[0].Cells[1].Value.ToString();
        }

    }
}
