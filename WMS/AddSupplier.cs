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
    public partial class AddSupplier : Form
    {
        public AddSupplier()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PosConString"].ToString());
        private void DataGrid()
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT SupplierID as 'ID', SupplierName as 'Name', SupplierContactPerson as 'Contact Person', SupplierPhone as 'Contact Number', SupplierVatRegNo as 'Vat Reg No', SupplierEmail as 'Email', SupplierAddress as 'Address' FROM Supplier WHERE SupplierID > 1";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewViewSupplier.DataSource = dt;
            con.Close();
        }
        private void AddSupplier_Load(object sender, EventArgs e)
        {
            DataGrid();

        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {


            string supplier_name = textBoxSupplierName.Text;
            string supplier_contact_person = textBoxContactPerson.Text;
            string supplier_phone = textBoxSupplierPhone.Text;
            string supplier_vat_reg_no = textBoxVatRegNo.Text;
            string supplier_email = textBoxSupplierEmail.Text;
            string supplier_address = textBoxSupplierAddress.Text;
            try
            {


                if (textBoxSupplierName.Text == "")
                {
                    MessageBox.Show("Please fill the all field...");
                }
                else if (textBoxSupplierPhone.Text == "")
                {
                    MessageBox.Show("Please fill the all field...");
                }
                else if (textBoxSupplierEmail.Text == "")
                {
                    MessageBox.Show("Please fill the all field...");
                }
                else if (textBoxSupplierAddress.Text == "")
                {
                    MessageBox.Show("Please fill the all field...");
                }
                else if (Already_Supplier_Name(textBoxSupplierName.Text) > 0)
                {
                    Clear_All();
                    MessageBox.Show("Supplier Already Exist....!!!");
                }

                else
                {
                    string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
                    SqlConnection connection = new SqlConnection(conStr);
                    string query11 = "INSERT INTO Supplier VALUES('01', '" + supplier_name + "', '" + supplier_contact_person + "', '" + supplier_phone + "', '" + supplier_vat_reg_no + "', '" + supplier_email + "','" + supplier_address + "')";
                    SqlCommand command = new SqlCommand(query11, connection);
                    connection.Open();
                    int rowEffict11 = command.ExecuteNonQuery();
                    connection.Close();
                    if (rowEffict11 > 0)
                    {
                        textBoxSupplierName.Text = textBoxContactPerson.Text = textBoxSupplierPhone.Text = textBoxVatRegNo.Text = textBoxSupplierEmail.Text = textBoxSupplierAddress.Text = string.Empty;
                        DataGrid();
                        MessageBox.Show("Supplier Add Successfully !");
                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }
        private void Clear_All()
        {
            textBoxSupplierID.Text = textBoxSupplierName.Text = textBoxSupplierPhone.Text = textBoxSupplierEmail.Text = textBoxSupplierAddress.Text = "";
        }
        private int Already_Supplier_Name(string Supplier_Name)
        {
            int exist = 0;
            string query = "SELECT SupplierID FROM Supplier WHERE SupplierName='" + Supplier_Name + "'";
            SqlCommand command = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                exist = Convert.ToInt32(reader["SupplierID"]);
            }

            reader.Close();
            con.Close();
            return exist;

        }
        private void buttonSupplierUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxSupplierID.Text == "")
            {
                MessageBox.Show("Please Select a Supplier in Datagrid to Edit And then Click Update....!!!");
            }
            else if (textBoxSupplierName.Text=="")
            {
                MessageBox.Show("Please Input Supplier Name....!!!");
            }
            else if (textBoxSupplierPhone.Text=="")
            {
                MessageBox.Show("Please Input Supplier Phone....!!!");
            }
            else if (textBoxSupplierEmail.Text=="")
            {
                MessageBox.Show("Please Input Supplier Email....!!!");
            }
            else if (textBoxSupplierAddress.Text=="")
            {
                MessageBox.Show("Please Input Supplier Address....!!!");
            }
            
            else
            {
                try
                {
                    SqlConnection cons = new SqlConnection(ConfigurationManager.ConnectionStrings["PosConString"].ToString());
                    
                    string querys = "UPDATE Supplier SET SupplierName = '" + textBoxSupplierName.Text + "', SupplierContactPerson = '" + textBoxContactPerson.Text + "', SupplierPhone = '" + textBoxSupplierPhone.Text + "', SupplierVatRegNo = '" + textBoxVatRegNo.Text + "', SupplierEmail = '" + textBoxSupplierEmail.Text + "', SupplierAddress = '" + textBoxSupplierAddress.Text + "'  WHERE SupplierID = '" + textBoxSupplierID.Text + "'";
                    SqlCommand commands = new SqlCommand(querys, cons);
                    cons.Open();
                    commands.ExecuteNonQuery();
                    cons.Close();
                    DataGrid();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void dataGridViewViewSupplier_DoubleClick(object sender, EventArgs e)
        {
            Clear_All();
            textBoxSupplierID.Text = dataGridViewViewSupplier.SelectedRows[0].Cells[0].Value.ToString();
            textBoxSupplierName.Text = dataGridViewViewSupplier.SelectedRows[0].Cells[1].Value.ToString();
            textBoxContactPerson.Text = dataGridViewViewSupplier.SelectedRows[0].Cells[2].Value.ToString();
            textBoxSupplierPhone.Text = dataGridViewViewSupplier.SelectedRows[0].Cells[3].Value.ToString();
            textBoxVatRegNo.Text = dataGridViewViewSupplier.SelectedRows[0].Cells[4].Value.ToString();
            textBoxSupplierEmail.Text = dataGridViewViewSupplier.SelectedRows[0].Cells[5].Value.ToString();
            textBoxSupplierAddress.Text = dataGridViewViewSupplier.SelectedRows[0].Cells[6].Value.ToString();
        }

    }
}
