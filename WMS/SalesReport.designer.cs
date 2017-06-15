namespace WMS
{
    partial class SalesReport
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.buttonInvoiceSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxInvoice = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewSalesReport = new System.Windows.Forms.DataGridView();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonInvoice = new System.Windows.Forms.RadioButton();
            this.radioButtonDataSales = new System.Windows.Forms.RadioButton();
            this.dataGridViewInvoice = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesReport)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.comboBoxType);
            this.panel2.Controls.Add(this.buttonInvoiceSearch);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBoxInvoice);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttonSearch);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1229, 47);
            this.panel2.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(919, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 52;
            this.label4.Text = "Type : ";
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(976, 15);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 24);
            this.comboBoxType.TabIndex = 51;
            // 
            // buttonInvoiceSearch
            // 
            this.buttonInvoiceSearch.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonInvoiceSearch.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInvoiceSearch.ForeColor = System.Drawing.Color.LavenderBlush;
            this.buttonInvoiceSearch.Location = new System.Drawing.Point(1113, 8);
            this.buttonInvoiceSearch.Name = "buttonInvoiceSearch";
            this.buttonInvoiceSearch.Size = new System.Drawing.Size(98, 34);
            this.buttonInvoiceSearch.TabIndex = 50;
            this.buttonInvoiceSearch.Text = "Search";
            this.buttonInvoiceSearch.UseVisualStyleBackColor = false;
            this.buttonInvoiceSearch.Click += new System.EventHandler(this.buttonInvoiceSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(619, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Invoice No : ";
            // 
            // textBoxInvoice
            // 
            this.textBoxInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInvoice.Location = new System.Drawing.Point(714, 15);
            this.textBoxInvoice.Name = "textBoxInvoice";
            this.textBoxInvoice.Size = new System.Drawing.Size(193, 22);
            this.textBoxInvoice.TabIndex = 48;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(307, 13);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(132, 22);
            this.dateTimePicker2.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(223, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Last Date : ";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonSearch.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.LavenderBlush;
            this.buttonSearch.Location = new System.Drawing.Point(535, 8);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(78, 34);
            this.buttonSearch.TabIndex = 45;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(88, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(132, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(4, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Date : ";
            // 
            // dataGridViewSalesReport
            // 
            this.dataGridViewSalesReport.AllowUserToAddRows = false;
            this.dataGridViewSalesReport.AllowUserToDeleteRows = false;
            this.dataGridViewSalesReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSalesReport.Location = new System.Drawing.Point(622, 125);
            this.dataGridViewSalesReport.Name = "dataGridViewSalesReport";
            this.dataGridViewSalesReport.ReadOnly = true;
            this.dataGridViewSalesReport.Size = new System.Drawing.Size(248, 10);
            this.dataGridViewSalesReport.TabIndex = 57;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 96);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowCloseButton = false;
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.ShowLogo = false;
            this.crystalReportViewer1.ShowParameterPanelButton = false;
            this.crystalReportViewer1.ShowRefreshButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1229, 669);
            this.crystalReportViewer1.TabIndex = 58;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.radioButtonInvoice);
            this.groupBox1.Controls.Add(this.radioButtonDataSales);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1229, 50);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sales Report";
            // 
            // radioButtonInvoice
            // 
            this.radioButtonInvoice.AutoSize = true;
            this.radioButtonInvoice.Location = new System.Drawing.Point(622, 20);
            this.radioButtonInvoice.Name = "radioButtonInvoice";
            this.radioButtonInvoice.Size = new System.Drawing.Size(150, 22);
            this.radioButtonInvoice.TabIndex = 1;
            this.radioButtonInvoice.TabStop = true;
            this.radioButtonInvoice.Text = "By Invoice Number";
            this.radioButtonInvoice.UseVisualStyleBackColor = true;
            this.radioButtonInvoice.CheckedChanged += new System.EventHandler(this.radioButtonInvoice_CheckedChanged);
            // 
            // radioButtonDataSales
            // 
            this.radioButtonDataSales.AutoSize = true;
            this.radioButtonDataSales.Location = new System.Drawing.Point(11, 21);
            this.radioButtonDataSales.Name = "radioButtonDataSales";
            this.radioButtonDataSales.Size = new System.Drawing.Size(125, 22);
            this.radioButtonDataSales.TabIndex = 0;
            this.radioButtonDataSales.TabStop = true;
            this.radioButtonDataSales.Text = "By Date Range";
            this.radioButtonDataSales.UseVisualStyleBackColor = true;
            this.radioButtonDataSales.CheckedChanged += new System.EventHandler(this.radioButtonDataSales_CheckedChanged);
            // 
            // dataGridViewInvoice
            // 
            this.dataGridViewInvoice.AllowUserToAddRows = false;
            this.dataGridViewInvoice.AllowUserToDeleteRows = false;
            this.dataGridViewInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvoice.Location = new System.Drawing.Point(622, 224);
            this.dataGridViewInvoice.Name = "dataGridViewInvoice";
            this.dataGridViewInvoice.ReadOnly = true;
            this.dataGridViewInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInvoice.Size = new System.Drawing.Size(422, 150);
            this.dataGridViewInvoice.TabIndex = 60;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All",
            "Cash",
            "Due",
            "Cheque"});
            this.comboBox1.SelectedIndex = 0;
            this.comboBox1.Location = new System.Drawing.Point(446, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(83, 21);
            this.comboBox1.TabIndex = 53;

            // 
            // SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 763);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.dataGridViewSalesReport);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridViewInvoice);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1245, 802);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1245, 802);
            this.Name = "SalesReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Report";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SalesReport_FormClosed);
            this.Load += new System.EventHandler(this.SalesReport_Load_1);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesReport)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridViewSalesReport;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button buttonInvoiceSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxInvoice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonInvoice;
        private System.Windows.Forms.RadioButton radioButtonDataSales;
        private System.Windows.Forms.DataGridView dataGridViewInvoice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}