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
    public partial class DatabaseBackUP : Form
    {
        public DatabaseBackUP()
        {
            InitializeComponent();
        }
        string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
        string sql = "";
        private void buttonBackUP_Click(object sender, EventArgs e)
        {
            

            try
            {
                progressBar1.Visible = true;
                label2.Visible = true;
                SqlConnection conn = new SqlConnection(conStr);
                conn.Open();
                sql = "BACKUP DATABASE WAREHOUSE TO DISK = '" + textBoxBackupPath.Text+ "\\"+ "WAREHOUSE" + "-"+DateTime.Now.ToString("yyyyMMddhhmmss") +".bak'";
                SqlCommand command = new SqlCommand(sql,conn);
                command.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
                backgroundWorker1.RunWorkerAsync();
                // MessageBox.Show("Database Backup Successfully....!!!");

            }
            catch (Exception sat)
            {
                MessageBox.Show(sat.Message);
            }
        }

        private void buttonBackupBrowse_Click(object sender, EventArgs e)
        {
            proHidden();
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBoxBackupPath.Text = fbd.SelectedPath;
                buttonBackUP.Enabled = true;
            }
                 
        }

        private void buttonRestorePath_Click(object sender, EventArgs e)
        {
            proHidden();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Backup Files(*.bak)|*.bak|All Files(*.*)|*.*";
            ofd.FilterIndex = 0;
            if (ofd.ShowDialog()==DialogResult.OK)
            {
                textBoxDatabaseRestorePath.Text = ofd.FileName;
                buttonRestore.Enabled = true;
            }

        }

        private void buttonRestore_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar2.Visible = true;
                label3.Visible = true;
                SqlConnection conn = new SqlConnection(conStr);
                conn.Open();
                sql = "USE master;";
                sql += "ALTER DATABASE WAREHOUSE SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                sql += "RESTORE DATABASE WAREHOUSE FROM DISK = '" + textBoxDatabaseRestorePath.Text +"' WITH REPLACE;";
                sql += "ALTER DATABASE WAREHOUSE SET Multi_User;";
                SqlCommand command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
                backgroundWorker2.RunWorkerAsync();
                MessageBox.Show("Restore Database Successfully....!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void proHidden()
        {
            progressBar1.Visible = false;
            progressBar2.Visible = false;

            label2.Visible = false;
            label3.Visible = false;
        }
        private void DatabaseBackUP_Load(object sender, EventArgs e)
        {
            buttonBackUP.Enabled = false;
            buttonRestore.Enabled = false;
            proHidden();


        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int i;
            for (i=1; i <= 100; i++)
            {
                backgroundWorker1.ReportProgress(i);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            label2.Text = e.ProgressPercentage.ToString() + " %";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //MessageBox.Show("BackUp completed...!!!!");
            MessageBox.Show("Database Backup Successfully....!!!");
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            int i;
            for (i = 1; i <= 100; i++)
            {
                backgroundWorker2.ReportProgress(i);
            }
        }

        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar2.Value = e.ProgressPercentage;
            label3.Text = e.ProgressPercentage.ToString() + " %";
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Restore Database Successfully....!!!");
        }
    }
}
