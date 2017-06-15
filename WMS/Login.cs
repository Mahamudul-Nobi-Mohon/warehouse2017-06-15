using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Management;

namespace WMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            textBoxPassword.KeyDown += new KeyEventHandler(textBoxPassword_KeyDown);
           // textBoxUserName.KeyDown += new KeyEventHandler(textBoxUserName_KeyDown);

            textBoxUserName.KeyPress += new KeyPressEventHandler(textBoxUserName_KeyPress);
            textBoxPassword.KeyPress += new KeyPressEventHandler(textBoxPassword_KeyPress);
        }
        public static string loguser = "";
        public static int loguserRole = 0;
        public static int loguserID = 0;

        int login = 0;
        string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();

        public int CompanyID = GetUserLogInfo.Company();


        //private void InsertUserLog(string CurrentUser, int CompanyID, string ComputerName, string MacAddress, string LocalIPAddress, string RealIPAddress, string status)
        //{
        //    SqlConnection con1 = new SqlConnection(conStr);
        //    con1.Open();
        //    string sql1 = @"INSERT INTO UserLog(UserName, CompanyID, LoginTime, LogoutTime, ComputerName, MacAddress, LocalIpAddress, RealIpAddress, Status) VALUES('" + CurrentUser + "', '" + CompanyID + "', GETDATE(), GETDATE(), '" + ComputerName + "', '" + MacAddress + "', '" + LocalIPAddress + "', '" + RealIPAddress + "', '" + status + "')";
        //    SqlCommand cmd1 = new SqlCommand(sql1, con1);
        //    cmd1.ExecuteNonQuery();
        //    con1.Close();
        //}
        private void InsertUserLog(string CurrentUser, int CompanyID, string ComputerName, string MacAddress, string LocalIPAddress,  string status)
        {
            SqlConnection con1 = new SqlConnection(conStr);
            con1.Open();
            string sql1 = @"INSERT INTO UserLog(UserName, CompanyID, LoginTime, LogoutTime, ComputerName, MacAddress, LocalIpAddress, Status) VALUES('" + CurrentUser + "', '" + CompanyID + "', GETDATE(), GETDATE(), '" + ComputerName + "', '" + MacAddress + "', '" + LocalIPAddress + "', '" + status + "')";
            SqlCommand cmd1 = new SqlCommand(sql1, con1);
            cmd1.ExecuteNonQuery();
            con1.Close();
        }

        private void Log_IN()
        {

            DateTime now = DateTime.Now;
            string date = now.ToString("yyyyMMdd");
            int today = Convert.ToInt32(date);
            int start_date = 20170531;
            int last_date = 20170730;
            if (start_date > today || last_date < today)
            {
                Trial tri = new Trial();
                tri.Show();
                Hide();
            }

            else
            {
                try
                {
                    string userName = textBoxUserName.Text;
                    userName = userName.Replace("'", "Sonali");
                    userName = userName.Replace("\"", "Sonali");
                    userName = userName.Replace("or", "Sonali");
                    userName = userName.Replace("OR", "Sonali");
                    userName = userName.Replace("-", "Sonali");
                    userName = userName.Replace("--", "Sonali");
                    userName = userName.Replace("=", "Sonali");
                    userName = userName.Replace("==", "Sonali");
                    userName = userName.Replace("===", "Sonali");
                    userName = userName.Replace(" ", "Sonali");
                    userName = userName.Replace("  ", "Sonali");
                    userName = userName.Replace("   ", "Sonali");
                    userName = userName.Replace("*", "Sonali");
                    string password = textBoxPassword.Text;
                    password = password.Replace(" ", "Sonali");
                    int Role = 0;
                    int error = 0;
                    loguser = userName;
                    string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
                    SqlConnection connection = new SqlConnection(conStr);
                    string query = "SELECT * FROM [User] WHERE UserName = @userName AND Password= @Password";
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlParameter param = new SqlParameter();
                    SqlParameter param2 = new SqlParameter();

                    param.ParameterName = "@userName";
                    param.Value = userName;

                    param2.ParameterName = "@Password";
                    param2.Value = password;

                    command.Parameters.Add(param);
                    command.Parameters.Add(param2);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Role = Convert.ToInt32(reader["Role"]);
                        loguserID = Convert.ToInt32(reader["ID"]);
                        error = 1;
                    }
                    loguserRole = Role;
                    connection.Close();
                   
                   
                        if (error == 0)
                        {
                            MessageBox.Show("User Name or Password incorrect...");
                        }
                        if (error != 0)
                    {
                        // User Log Info Start

                        string CurrentUser = userName;
                        int Companyid = CompanyID;
                        string ComputerName = GetUserLogInfo.hostName;
                        string MacAddress = GetUserLogInfo.GetMacAddress();
                        string LocalIPAddress = GetUserLogInfo.GetLocalIPAddress();
                       // string RealIPAddress = GetUserLogInfo.GetRealIPAddress();
                        string status = "1";


                      //  InsertUserLog(CurrentUser, Companyid, ComputerName, MacAddress, LocalIPAddress, RealIPAddress, status);
                        InsertUserLog(CurrentUser, Companyid, ComputerName, MacAddress, LocalIPAddress, status);        // Without Real IP

                        // User Log Info End

                        if (Companyid == 420)
                        {
                            MessageBox.Show("You are not a valid user....");
                            System.Diagnostics.Process.GetCurrentProcess().Kill();
                            Application.Exit();
                            Close();
                        }
                        else
                        {
                            MainBody amainbody = new MainBody();
                            amainbody.Show();
                            Hide();
                        }
                        
                     }
               }
                catch (Exception)
                {
                    MessageBox.Show("Database Connection Failed...");
                }
            }
        }
       
        private void buttonExit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
            Close();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
            Close();

        }
       
        private void Login_Load(object sender, EventArgs e)
        {

        }
        int eventCount = 0;
        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //enter key is down
                eventCount++;
                if (eventCount == 2)
                {
                    //code for producing textbox
                    eventCount = 0;
                    Log_IN();
                    
                }
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {

            
        }

        ////////////////////////private void textBoxUserName_KeyDown(object sender, KeyEventArgs e)
        ////////////////////////{

        ////////////////////////    if (e.KeyCode == Keys.F12)
        ////////////////////////    {
        ////////////////////////        //enter key is down
        ////////////////////////        eventCount++;
        ////////////////////////        if (eventCount == 2)
        ////////////////////////        {
        ////////////////////////            //code for producing textbox
        ////////////////////////            eventCount = 0;
        ////////////////////////            LogInSuperAdmin lsa = new LogInSuperAdmin();
        ////////////////////////            lsa.Show();
        ////////////////////////            Hide();

        ////////////////////////        }

        ////////////////////////    }
           
        ////////////////////////}

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.F12) //The  character represents a backspace
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.F12) //The  character represents a backspace
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Log_IN();           
        }
    }
}
