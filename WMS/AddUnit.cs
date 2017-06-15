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
    public partial class AddUnit : Form
    {
        public AddUnit()
        {
            InitializeComponent();
        }
        
        private void UnitType_Load(object sender, EventArgs e)
        {
            DataGrid();
        }
        public void DataGrid()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PosConString"].ToString());
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT UnitID as 'Unit ID', UnitName as 'Unit Name' FROM Unit";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewViewUnit.DataSource = dt;
            con.Close();
        }
        private int AlreadyHas(string unitname)
        {
            string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
            SqlConnection connection = new SqlConnection(conStr);
            string query = "SELECT * FROM Unit WHERE UnitName = '" + unitname + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            int rowEffict = Convert.ToInt32(reader.Read());
            connection.Close();
            return rowEffict;

        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string unit_name = textBoxUnitName.Text;
                if (unit_name == "")
                {
                    MessageBox.Show("Please Fill The Text Box.");
                }
                else if (AlreadyHas(textBoxUnitName.Text)>0)
                {
                    MessageBox.Show("Unit Name Already exit....!!!!!!");
                }
                else
                {

                    string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
                    SqlConnection connection = new SqlConnection(conStr);
                    string query = "INSERT INTO Unit(UnitName) VALUES('" + unit_name + "')";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    int rowEffict = command.ExecuteNonQuery();
                    connection.Close();
                    if (rowEffict > 0)
                    {

                        textBoxUnitName.Text = string.Empty;
                        DataGrid();
                        MessageBox.Show("Unit Add Successfully !");
                    }
                   
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string new_unit_name = textBoxUnitName.Text;
                if (new_unit_name == "")
                {
                    MessageBox.Show("Please Fill the text box.");
                }
                else if (AlreadyHas(textBoxUnitName.Text) > 0)
                {
                    MessageBox.Show("Unit Name Already exit....!!!!!!");
                }
                else
                {
                    string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
                    SqlConnection connection = new SqlConnection(conStr);
                    string query = "UPDATE Unit SET UnitName = '" + new_unit_name + "' WHERE UnitID ='" + textBoxUnitID.Text+ "'";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    int rowEffict = command.ExecuteNonQuery();
                    connection.Close();
                    if (rowEffict > 0)
                    {
                        textBoxUnitName.Text = textBoxUnitName.Text =  string.Empty;
                        DataGrid();
                        MessageBox.Show("Unit Update Successfully !");
                    }
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridViewViewUnit_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxUnitID.Text = dataGridViewViewUnit.SelectedRows[0].Cells[0].Value.ToString();
            textBoxUnitName.Text = dataGridViewViewUnit.SelectedRows[0].Cells[1].Value.ToString();
        }

       
    }
}
