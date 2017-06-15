using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace WMS
{
    public partial class AddCell : Form
    {
        public AddCell()
        {
            InitializeComponent();
        }

        //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PosConString"].ToString());
        //public void fillCombo(ComboBox combo, string query, string displayMember, string valueMember)
        //{
        //    SqlCommand command = new SqlCommand(query, con);
        //    SqlDataAdapter adapter = new SqlDataAdapter(command);
        //    DataTable table = new DataTable();
        //    adapter.Fill(table);
        //    combo.DataSource = table;
        //    combo.DisplayMember = displayMember;
        //    combo.ValueMember = valueMember;

        //}

        //private void AddCell_Load(object sender, EventArgs e)
        //{
        //    string query = "SELECT * FROM LocationMain";
        //    comboBoxWareHouse.SelectedValue = -1;
        //    fillCombo(comboBoxWareHouse, query, "LocationMainName", "LocationMainID");
        //    DataGrid();
        //}
        //public void DataGrid()
        //{
        //    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PosConString"].ToString());
        //    con.Open();
        //    SqlCommand cmd = con.CreateCommand();
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = "SELECT FactoryCell.FactoryCellId AS 'ID', FactoryCell.FactoryCellName AS 'Cell Name', FactoryFloor.FactoryFloorName AS 'Floor Name' FROM FactoryCell INNER JOIN FactoryFloor ON FactoryCell.FloorId = FactoryFloor.FactoryFloorId";
        //    cmd.ExecuteNonQuery();
        //    DataTable dt = new DataTable();
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    da.Fill(dt);
        //    dataGridView1.DataSource = dt;
        //    con.Close();
        //}
        //private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    buttonUpdate.Enabled = true;
        //    textBoxCellName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        //    comboBoxWareHouse.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        //    textBoxFloorId.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        //}

        //private int AlreadyHas(string Cell_name)
        //{
        //    string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
        //    SqlConnection connection = new SqlConnection(conStr);
        //    string query = "SELECT * FROM FactoryCell WHERE FactoryCellName = '" + Cell_name + "'";
        //    SqlCommand command = new SqlCommand(query, connection);
        //    connection.Open();
        //    SqlDataReader reader = command.ExecuteReader();
        //    int rowEffict = Convert.ToInt32(reader.Read());
        //    connection.Close();
        //    return rowEffict;

        //}
        //private void buttonAdd_Click(object sender, EventArgs e)
        //{
        //    if (textBoxCellName.Text != "")
        //    {
        //        if(AlreadyHas(textBoxCellName.Text) > 0)
        //        {
        //            MessageBox.Show("Cell Name Already Exist....!!!!!!");
        //        }
        //        else
        //        {
        //        string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
        //        SqlConnection conn = new SqlConnection(conStr);
        //        string query = "INSERT INTO FactoryCell(FloorId, FactoryCellName) VALUES('" + comboBoxWareHouse.SelectedValue.ToString() + "','" + textBoxCellName.Text + "')";
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand(query, conn);
        //        cmd.ExecuteNonQuery();
        //        DataGrid();
        //        conn.Close();
        //        MessageBox.Show("Saction added Successfully");
        //        textBoxCellName.Text = comboBoxWareHouse.Text = String.Empty;
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please fill the texbox");
        //    }
        //}

        //private void buttonUpdate_Click(object sender, EventArgs e)
        //{
        //    if (textBoxCellName.Text != "")
        //    {
        //        if (AlreadyHas(textBoxCellName.Text) > 0)
        //        {
        //            MessageBox.Show("Cell Name Already Exist....!!!!!!");
        //        }
        //        else
        //        {
        //            string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
        //            SqlConnection conn = new SqlConnection(conStr);
        //            string query = "UPDATE FactoryCell SET FloorId = '" + comboBoxWareHouse.SelectedValue + "', FactoryCellName = '" + textBoxCellName.Text + "' WHERE FactoryCellId ='" + textBoxFloorId.Text + "'";
        //            conn.Open();
        //            SqlCommand cmd = new SqlCommand(query, conn);
        //            cmd.ExecuteNonQuery();
        //            DataGrid();
        //            conn.Close();
        //            buttonUpdate.Enabled = false;
        //            textBoxCellName.Text = comboBoxWareHouse.Text = String.Empty;
        //            MessageBox.Show("Saction Name is Updated");
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please fill the texbox");
        //    }
        //}

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PosConString"].ToString());
        public void fillCombo(ComboBox combo, string query, string displayMember, string valueMember)
        {
            SqlCommand command = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            combo.DataSource = table;
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;

        }

       

        private void AddSection_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM LocationMain";
            comboBoxWareHouse.SelectedValue = -1;
            fillCombo(comboBoxWareHouse, query, "LocationMainName", "LocationMainID");

            DataGrid();
        }
        public void DataGrid()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PosConString"].ToString());
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT LocationSub.LocationSubID AS 'ID', LocationMain.LocationMainName AS 'Location Main Name',Location.LocationName AS 'Location Name', LocationSub.LocationSubName  AS 'Cell Name'  FROM LocationSub  INNER JOIN LocationMain    ON LocationSub.LocationMainID = LocationMain.LocationMainID INNER JOIN Location ON Location.LocationID = LocationSub.LocationID";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            buttonUpdate.Enabled = true;
            textBoxLocationSubId.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            comboBoxWareHouse.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            comboBoxRoomName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBoxCellName.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

        }

        private int AlreadyHas(string section_name)
        {
            string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
            SqlConnection connection = new SqlConnection(conStr);
            string query = "SELECT LocationName FROM Location WHERE LocationName = '" + section_name + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            int rowEffict = Convert.ToInt32(reader.Read());
            connection.Close();
            return rowEffict;

        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxCellName.Text != "")
            {
                if (AlreadyHas(textBoxCellName.Text) > 0)
                {
                    MessageBox.Show("Cell Name Already Exist....!!!!!!");
                }
                else
                {
                    string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
                    SqlConnection conn = new SqlConnection(conStr);
                    string query = "INSERT INTO LocationSub(LocationMainID, LocationID,LocationSubName) VALUES('" + comboBoxWareHouse.SelectedValue.ToString() + "','" + comboBoxRoomName.SelectedValue.ToString() + "','" + textBoxCellName.Text + "')";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    DataGrid();
                    conn.Close();
                    MessageBox.Show("Cell added Successfully");
                    textBoxCellName.Text = comboBoxWareHouse.Text = comboBoxRoomName.Text = String.Empty;
                }
            }
            else
            {
                MessageBox.Show("Please fill the texbox");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxCellName.Text != "")
            {
                if (AlreadyHas(textBoxCellName.Text) > 0)
                {
                    MessageBox.Show("Cell Name Already Exist....!!!!!!");
                }
                else
                {
                    string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
                    SqlConnection conn = new SqlConnection(conStr);
                    string query = "UPDATE LocationSub SET LocationMainID = '" + comboBoxWareHouse.SelectedValue.ToString() + "', LocationID = '" + comboBoxRoomName.SelectedValue.ToString() + "', LocationSubName ='" + textBoxCellName.Text + "'  WHERE LocationSubID ='" + textBoxLocationSubId.Text + "'";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    DataGrid();
                    conn.Close();
                    buttonUpdate.Enabled = false;
                    textBoxCellName.Text = comboBoxWareHouse.Text = comboBoxRoomName.Text = String.Empty;
                    MessageBox.Show("Cell Name is Updated");
                }
            }
            else
            {
                MessageBox.Show("Please fill the texbox");
            }
        }

        private void comboBoxWareHouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(comboBoxWareHouse.SelectedValue.ToString(), out val);

            string query2 = "SELECT * FROM Location where LocationMainID = " + val + " ";
            //comboBoxRoomName.SelectedValue = -1;
            fillCombo(comboBoxRoomName, query2, "LocationName", "LocationID");
            //string query2 = "SELECT * FROM Location where LocationMainID = " + comboBoxWareHouse.SelectedValue.ToString() + " ";
            //comboBoxRoomName.SelectedValue = -1;
            //fillCombo2(comboBoxRoomName, query2, "LocationName", "LocationID");
        }
    }
}
