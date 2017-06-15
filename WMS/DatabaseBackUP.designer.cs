namespace WMS
{
    partial class DatabaseBackUP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonBackUP = new System.Windows.Forms.Button();
            this.buttonBackupBrowse = new System.Windows.Forms.Button();
            this.textBoxBackupPath = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.buttonRestore = new System.Windows.Forms.Button();
            this.buttonRestorePath = new System.Windows.Forms.Button();
            this.textBoxDatabaseRestorePath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.progressBar1);
            this.groupBox3.Controls.Add(this.buttonBackUP);
            this.groupBox3.Controls.Add(this.buttonBackupBrowse);
            this.groupBox3.Controls.Add(this.textBoxBackupPath);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(563, 95);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Database Backup";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 9;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(89, 66);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(363, 13);
            this.progressBar1.TabIndex = 9;
            // 
            // buttonBackUP
            // 
            this.buttonBackUP.Location = new System.Drawing.Point(463, 23);
            this.buttonBackUP.Name = "buttonBackUP";
            this.buttonBackUP.Size = new System.Drawing.Size(75, 30);
            this.buttonBackUP.TabIndex = 7;
            this.buttonBackUP.Text = "Backup";
            this.buttonBackUP.UseVisualStyleBackColor = true;
            this.buttonBackUP.Click += new System.EventHandler(this.buttonBackUP_Click);
            // 
            // buttonBackupBrowse
            // 
            this.buttonBackupBrowse.Location = new System.Drawing.Point(377, 24);
            this.buttonBackupBrowse.Name = "buttonBackupBrowse";
            this.buttonBackupBrowse.Size = new System.Drawing.Size(75, 30);
            this.buttonBackupBrowse.TabIndex = 6;
            this.buttonBackupBrowse.Text = "Browse";
            this.buttonBackupBrowse.UseVisualStyleBackColor = true;
            this.buttonBackupBrowse.Click += new System.EventHandler(this.buttonBackupBrowse_Click);
            // 
            // textBoxBackupPath
            // 
            this.textBoxBackupPath.Location = new System.Drawing.Point(89, 27);
            this.textBoxBackupPath.Name = "textBoxBackupPath";
            this.textBoxBackupPath.ReadOnly = true;
            this.textBoxBackupPath.Size = new System.Drawing.Size(264, 25);
            this.textBoxBackupPath.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Location";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.progressBar2);
            this.groupBox4.Controls.Add(this.buttonRestore);
            this.groupBox4.Controls.Add(this.buttonRestorePath);
            this.groupBox4.Controls.Add(this.textBoxDatabaseRestorePath);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 162);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(563, 95);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Database Restore";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 10;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(89, 66);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(367, 13);
            this.progressBar2.TabIndex = 11;
            // 
            // buttonRestore
            // 
            this.buttonRestore.Location = new System.Drawing.Point(467, 23);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Size = new System.Drawing.Size(75, 30);
            this.buttonRestore.TabIndex = 7;
            this.buttonRestore.Text = "Restore";
            this.buttonRestore.UseVisualStyleBackColor = true;
            this.buttonRestore.Click += new System.EventHandler(this.buttonRestore_Click);
            // 
            // buttonRestorePath
            // 
            this.buttonRestorePath.Location = new System.Drawing.Point(381, 23);
            this.buttonRestorePath.Name = "buttonRestorePath";
            this.buttonRestorePath.Size = new System.Drawing.Size(75, 30);
            this.buttonRestorePath.TabIndex = 6;
            this.buttonRestorePath.Text = "Browse";
            this.buttonRestorePath.UseVisualStyleBackColor = true;
            this.buttonRestorePath.Click += new System.EventHandler(this.buttonRestorePath_Click);
            // 
            // textBoxDatabaseRestorePath
            // 
            this.textBoxDatabaseRestorePath.Location = new System.Drawing.Point(89, 27);
            this.textBoxDatabaseRestorePath.Name = "textBoxDatabaseRestorePath";
            this.textBoxDatabaseRestorePath.ReadOnly = true;
            this.textBoxDatabaseRestorePath.Size = new System.Drawing.Size(264, 25);
            this.textBoxDatabaseRestorePath.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Backup Path";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 36);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(217, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database Backup / Restore";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_ProgressChanged);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // DatabaseBackUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 275);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(602, 314);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(602, 314);
            this.Name = "DatabaseBackUP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database BackUP";
            this.Load += new System.EventHandler(this.DatabaseBackUP_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonBackUP;
        private System.Windows.Forms.Button buttonBackupBrowse;
        private System.Windows.Forms.TextBox textBoxBackupPath;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonRestore;
        private System.Windows.Forms.Button buttonRestorePath;
        private System.Windows.Forms.TextBox textBoxDatabaseRestorePath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}