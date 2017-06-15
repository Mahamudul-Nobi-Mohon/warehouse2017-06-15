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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
            textBoxCustPreDue.KeyPress += new KeyPressEventHandler(textBoxCustPreDue_KeyPress);
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
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PosConString"].ToString());
        private void DataGrid()
        {
            
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT CustomerID as 'ID', CustomerName as 'Name', GroupName as 'Group Name', Phone as 'Phone', VatRegNo as 'Vat No', Email as 'Email', Address as 'Address' FROM Customer";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            DataGrid();
            Auto_Complete();
        }

        private void Auto_Complete()
        {
            //Auto Complete search
            textBoxCustomerName.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxCustomerName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxGroupName.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxGroupName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
            SqlConnection conSS = new SqlConnection(conStr);
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            col.Clear();
            conSS.Open();
            string sql = "SELECT CustomerName FROM Customer";
            SqlCommand cmd = new SqlCommand(sql, conSS);
            SqlDataReader sdr = null;
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                //col.Add(sdr["Code"].ToString());
                col.Add(sdr["CustomerName"].ToString());

            }
            sdr.Close();
            textBoxCustomerName.AutoCompleteCustomSource = col;


            AutoCompleteStringCollection col2 = new AutoCompleteStringCollection();
            col2.Clear();
           // conSS.Open();
            string sql2 = "SELECT GroupName FROM Customer";
            SqlCommand cmd2 = new SqlCommand(sql2, conSS);
            SqlDataReader sdr2 = null;
            sdr2 = cmd2.ExecuteReader();
            while (sdr2.Read())
            {
                //col.Add(sdr["Code"].ToString());
                col2.Add(sdr2["GroupName"].ToString());

            }
            sdr2.Close();

            textBoxGroupName.AutoCompleteCustomSource = col2;
            conSS.Close();
        }
        private void btnAddBuyer_Click(object sender, EventArgs e)
        {
            string customer_name = textBoxCustomerName.Text;
            string customer_phone = textBoxCustomerPhone.Text;
            string customer_email = textBoxCustomerEmail.Text;
            string customer_address = textBoxCustomerAddress.Text;
            int cust_pre_due = Convert.ToInt32(textBoxCustPreDue.Text);
            try
            {
                if (textBoxGroupName.Text == "")
                {
                    MessageBox.Show("Please fill the all field...");
                }
                //else if (comboBoxSelectCompany.Text == "")
                //{
                //    MessageBox.Show("Please fill the all field...");
                //}
                else if(textBoxCustomerName.Text == "")
                {
                    MessageBox.Show("Please fill the all field...");
                }
                else if (textBoxCustomerPhone.Text == "")
                {
                    MessageBox.Show("Please fill the all field...");
                }
                //else if (textBoxVatRegNo.Text == "")
                //{
                //    MessageBox.Show("Please fill the all field...");
                //}
                //else if (textBoxCustomerEmail.Text == "")
                //{
                //    MessageBox.Show("Please fill the all field...");
                //}
                else if (textBoxCustomerAddress.Text == "")
                {
                    MessageBox.Show("Please fill the all field...");
                }
                else if (textBoxCustPreDue.Text == "")
                {
                    MessageBox.Show("Please fill the all field...");
                }

                else
                {
                    string group = textBoxGroupName.Text;
                    string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
                    SqlConnection connection = new SqlConnection(conStr);
                    string query11 = "INSERT INTO Customer(CompanyID,GroupName,CompanyName,CustomerName,Gender,Phone,VatRegNo,Email,Address) OUTPUT INSERTED.CustomerID VALUES(1,'" + group +"','Default Company','" + customer_name + "','Male','" + customer_phone + "','"+ textBoxVatRegNo.Text+ "','" + customer_email + "','" + customer_address + "')";
                    SqlCommand command = new SqlCommand(query11, connection);
                    connection.Open();
                    // int rowEffict11 = command.ExecuteNonQuery();
                    int rowEffict11 = (int)command.ExecuteScalar();
                    connection.Close();
                    if (rowEffict11 > 0)
                    {
                      //  CustLedger(rowEffict11);
                        textBoxCustomerName.Text = textBoxGroupName.Text = textBoxCustomerPhone.Text = textBoxVatRegNo.Text = textBoxCustomerEmail.Text = textBoxCustPreDue.Text = string.Empty;
                        textBoxCustomerAddress.Text = string.Empty;
                        DataGrid();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CustLedger(int id)
        {
            double pre_due=0.0,n = 0.0;
            pre_due = Convert.ToDouble(textBoxCustPreDue.Text);
            string pre = "Previous due";
            DateTime dt = DateTime.Now;
            string date = dt.ToString("yyyy-MM-dd");
            string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
            SqlConnection connection = new SqlConnection(conStr);
            string query11 = "INSERT INTO [CustomerLedger](ReceiveDate,CustomerID,InvoiceNo,Debit,Credit,Remarks,NextPaymentDate,IsPreviousDue) VALUES('" + date + "','" + id + "','"+pre+"','" + pre_due + "','" + n + "','" + pre + "','" + pre + "','1')";
            SqlCommand command = new SqlCommand(query11, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        private void Clear_All()
        {
            textBoxCustomerId.Text = textBoxCustomerName.Text = textBoxCustomerPhone.Text = textBoxCustomerEmail.Text = textBoxCustomerAddress.Text = "";
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Clear_All();
            textBoxCustomerId.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBoxCustomerName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBoxGroupName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBoxVatRegNo.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBoxCustomerPhone.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBoxCustomerEmail.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBoxCustomerAddress.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textBoxCustPreDue.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            textBoxCustPreDue.Enabled = false;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxCustomerId.Text == "")
            {
                MessageBox.Show("Please Select a Customer in Datagrid to Edit And then Click Update....!!!");
            }
            else if (textBoxCustomerName.Text == "")
            {
                MessageBox.Show("Please Input Customer Name....!!!");
            }
            else if (textBoxCustomerPhone.Text == "")
            {
                MessageBox.Show("Please Input Customer Phone....!!!");
            }
            //else if (textBoxCustomerEmail.Text == "")
            //{
            //    MessageBox.Show("Please Input Customer Email....!!!");
            //}
            else if (textBoxCustomerAddress.Text == "")
            {
                MessageBox.Show("Please Input Customer Address....!!!");
            }
            else {
                try
                {
                    SqlConnection cons = new SqlConnection(ConfigurationManager.ConnectionStrings["PosConString"].ToString());

                    string querys = "UPDATE Customer SET GroupName = '"+ textBoxGroupName.Text + "', CustomerName = '" + textBoxCustomerName.Text + "', Phone = '" + textBoxCustomerPhone.Text + "', VatRegNo = '"+ textBoxVatRegNo .Text + "', Email = '" + textBoxCustomerEmail.Text + "', Address = '" + textBoxCustomerAddress.Text + "'  WHERE CustomerID = '" + textBoxCustomerId.Text + "'";
                    SqlCommand commands = new SqlCommand(querys, cons);
                    cons.Open();
                    commands.ExecuteNonQuery();
                    cons.Close();
                    DataGrid();
                    textBoxCustomerId.Text = textBoxCustomerName.Text = textBoxGroupName.Text = textBoxCustomerPhone.Text = textBoxVatRegNo.Text = textBoxCustomerEmail.Text = textBoxCustomerAddress.Text =  "";
                    MessageBox.Show("Update Successfully...!!!!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void textBoxCustPreDue_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
