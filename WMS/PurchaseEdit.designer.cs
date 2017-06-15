namespace WMS
{
    partial class PurchaseEdit
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxInvoiceNo = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataGridViewSalesEdit = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonAddMore = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPreviousCode = new System.Windows.Forms.TextBox();
            this.textBoxProductID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxPreviousQuantity = new System.Windows.Forms.TextBox();
            this.textBoxPurchaseID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxProductCode = new System.Windows.Forms.ComboBox();
            this.dateTimePickerPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxPurchasePrice = new System.Windows.Forms.TextBox();
            this.labelVAT = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxSupplierInvoice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesEdit)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxInvoiceNo);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1165, 70);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Purchase Edit";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(394, 27);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(222, 22);
            this.dateTimePicker2.TabIndex = 51;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(324, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 50;
            this.label3.Text = "End Date : ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(81, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(222, 22);
            this.dateTimePicker1.TabIndex = 49;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 48;
            this.label2.Text = "Start Date : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(656, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "Invoice No : ";
            // 
            // comboBoxInvoiceNo
            // 
            this.comboBoxInvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxInvoiceNo.FormattingEnabled = true;
            this.comboBoxInvoiceNo.Location = new System.Drawing.Point(735, 27);
            this.comboBoxInvoiceNo.Name = "comboBoxInvoiceNo";
            this.comboBoxInvoiceNo.Size = new System.Drawing.Size(194, 24);
            this.comboBoxInvoiceNo.TabIndex = 46;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonSearch.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.LavenderBlush;
            this.buttonSearch.Location = new System.Drawing.Point(960, 22);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(114, 34);
            this.buttonSearch.TabIndex = 45;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dataGridViewSalesEdit
            // 
            this.dataGridViewSalesEdit.AllowUserToAddRows = false;
            this.dataGridViewSalesEdit.AllowUserToDeleteRows = false;
            this.dataGridViewSalesEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSalesEdit.Location = new System.Drawing.Point(329, 78);
            this.dataGridViewSalesEdit.Name = "dataGridViewSalesEdit";
            this.dataGridViewSalesEdit.ReadOnly = true;
            this.dataGridViewSalesEdit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSalesEdit.Size = new System.Drawing.Size(838, 523);
            this.dataGridViewSalesEdit.TabIndex = 61;
            this.dataGridViewSalesEdit.DoubleClick += new System.EventHandler(this.dataGridViewSalesEdit_DoubleClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel4.Controls.Add(this.buttonAddMore);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.textBoxPreviousCode);
            this.panel4.Controls.Add(this.textBoxProductID);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.comboBoxProductCode);
            this.panel4.Controls.Add(this.dateTimePickerPurchaseDate);
            this.panel4.Controls.Add(this.textBoxPurchasePrice);
            this.panel4.Controls.Add(this.labelVAT);
            this.panel4.Controls.Add(this.label25);
            this.panel4.Controls.Add(this.textBoxQuantity);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.textBoxProductName);
            this.panel4.Controls.Add(this.buttonUpdate);
            this.panel4.Controls.Add(this.textBoxSupplierInvoice);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label21);
            this.panel4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(1, 78);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(332, 523);
            this.panel4.TabIndex = 62;
            // 
            // buttonAddMore
            // 
            this.buttonAddMore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonAddMore.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddMore.ForeColor = System.Drawing.Color.Magenta;
            this.buttonAddMore.Location = new System.Drawing.Point(62, 446);
            this.buttonAddMore.Name = "buttonAddMore";
            this.buttonAddMore.Size = new System.Drawing.Size(187, 42);
            this.buttonAddMore.TabIndex = 90;
            this.buttonAddMore.Text = "Add More";
            this.buttonAddMore.UseVisualStyleBackColor = false;
            this.buttonAddMore.Click += new System.EventHandler(this.buttonAddMore_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(46, 422);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(222, 20);
            this.label8.TabIndex = 89;
            this.label8.Text = "Invoice, Click The Buttom Below...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(27, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(267, 20);
            this.label7.TabIndex = 88;
            this.label7.Text = "*** If You Want To Add More Items In This";
            // 
            // textBoxPreviousCode
            // 
            this.textBoxPreviousCode.Location = new System.Drawing.Point(75, 302);
            this.textBoxPreviousCode.Name = "textBoxPreviousCode";
            this.textBoxPreviousCode.Size = new System.Drawing.Size(39, 26);
            this.textBoxPreviousCode.TabIndex = 87;
            this.textBoxPreviousCode.Visible = false;
            // 
            // textBoxProductID
            // 
            this.textBoxProductID.Location = new System.Drawing.Point(284, 445);
            this.textBoxProductID.Name = "textBoxProductID";
            this.textBoxProductID.Size = new System.Drawing.Size(39, 26);
            this.textBoxProductID.TabIndex = 86;
            this.textBoxProductID.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.Controls.Add(this.textBoxPreviousQuantity);
            this.panel1.Controls.Add(this.textBoxPurchaseID);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(11, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 48);
            this.panel1.TabIndex = 83;
            // 
            // textBoxPreviousQuantity
            // 
            this.textBoxPreviousQuantity.Location = new System.Drawing.Point(19, 10);
            this.textBoxPreviousQuantity.Name = "textBoxPreviousQuantity";
            this.textBoxPreviousQuantity.Size = new System.Drawing.Size(39, 26);
            this.textBoxPreviousQuantity.TabIndex = 85;
            this.textBoxPreviousQuantity.Visible = false;
            // 
            // textBoxPurchaseID
            // 
            this.textBoxPurchaseID.Location = new System.Drawing.Point(254, 12);
            this.textBoxPurchaseID.Name = "textBoxPurchaseID";
            this.textBoxPurchaseID.Size = new System.Drawing.Size(39, 26);
            this.textBoxPurchaseID.TabIndex = 84;
            this.textBoxPurchaseID.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(72, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "EDIT OR UPDATE";
            // 
            // comboBoxProductCode
            // 
            this.comboBoxProductCode.FormattingEnabled = true;
            this.comboBoxProductCode.Location = new System.Drawing.Point(126, 163);
            this.comboBoxProductCode.Name = "comboBoxProductCode";
            this.comboBoxProductCode.Size = new System.Drawing.Size(187, 28);
            this.comboBoxProductCode.TabIndex = 82;
            this.comboBoxProductCode.SelectedIndexChanged += new System.EventHandler(this.comboBoxProductCode_SelectedIndexChanged);
            // 
            // dateTimePickerPurchaseDate
            // 
            this.dateTimePickerPurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerPurchaseDate.Location = new System.Drawing.Point(126, 120);
            this.dateTimePickerPurchaseDate.Name = "dateTimePickerPurchaseDate";
            this.dateTimePickerPurchaseDate.Size = new System.Drawing.Size(187, 26);
            this.dateTimePickerPurchaseDate.TabIndex = 81;
            // 
            // textBoxPurchasePrice
            // 
            this.textBoxPurchasePrice.BackColor = System.Drawing.Color.Thistle;
            this.textBoxPurchasePrice.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPurchasePrice.ForeColor = System.Drawing.Color.Navy;
            this.textBoxPurchasePrice.Location = new System.Drawing.Point(126, 255);
            this.textBoxPurchasePrice.Name = "textBoxPurchasePrice";
            this.textBoxPurchasePrice.ReadOnly = true;
            this.textBoxPurchasePrice.Size = new System.Drawing.Size(187, 26);
            this.textBoxPurchasePrice.TabIndex = 80;
            // 
            // labelVAT
            // 
            this.labelVAT.AutoSize = true;
            this.labelVAT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.labelVAT.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVAT.ForeColor = System.Drawing.Color.Navy;
            this.labelVAT.Location = new System.Drawing.Point(47, 256);
            this.labelVAT.Name = "labelVAT";
            this.labelVAT.Size = new System.Drawing.Size(0, 20);
            this.labelVAT.TabIndex = 79;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label25.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Navy;
            this.label25.Location = new System.Drawing.Point(7, 211);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(97, 20);
            this.label25.TabIndex = 78;
            this.label25.Text = "Product Name";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.BackColor = System.Drawing.Color.White;
            this.textBoxQuantity.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuantity.ForeColor = System.Drawing.Color.Navy;
            this.textBoxQuantity.Location = new System.Drawing.Point(126, 302);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(187, 26);
            this.textBoxQuantity.TabIndex = 77;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(8, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 20);
            this.label10.TabIndex = 76;
            this.label10.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(6, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 66;
            this.label4.Text = "Purchase Price";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.BackColor = System.Drawing.Color.Thistle;
            this.textBoxProductName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductName.ForeColor = System.Drawing.Color.Navy;
            this.textBoxProductName.Location = new System.Drawing.Point(126, 211);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.ReadOnly = true;
            this.textBoxProductName.Size = new System.Drawing.Size(187, 26);
            this.textBoxProductName.TabIndex = 52;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonUpdate.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.LavenderBlush;
            this.buttonUpdate.Location = new System.Drawing.Point(12, 341);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(301, 42);
            this.buttonUpdate.TabIndex = 44;
            this.buttonUpdate.Text = "Edit / Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxSupplierInvoice
            // 
            this.textBoxSupplierInvoice.BackColor = System.Drawing.Color.White;
            this.textBoxSupplierInvoice.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSupplierInvoice.ForeColor = System.Drawing.Color.Navy;
            this.textBoxSupplierInvoice.Location = new System.Drawing.Point(126, 78);
            this.textBoxSupplierInvoice.Name = "textBoxSupplierInvoice";
            this.textBoxSupplierInvoice.Size = new System.Drawing.Size(187, 26);
            this.textBoxSupplierInvoice.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(6, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "Supplier Invoice ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Navy;
            this.label14.Location = new System.Drawing.Point(7, 120);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 20);
            this.label14.TabIndex = 47;
            this.label14.Text = "Purchase Date";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label21.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Navy;
            this.label21.Location = new System.Drawing.Point(7, 165);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(98, 20);
            this.label21.TabIndex = 55;
            this.label21.Text = "Product Code ";
            // 
            // PurchaseEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 602);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dataGridViewSalesEdit);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PurchaseEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaseEdit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PurchaseEdit_FormClosed);
            this.Load += new System.EventHandler(this.PurchaseEdit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesEdit)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxInvoiceNo;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridViewSalesEdit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxPurchasePrice;
        private System.Windows.Forms.Label labelVAT;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxSupplierInvoice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox comboBoxProductCode;
        private System.Windows.Forms.DateTimePicker dateTimePickerPurchaseDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPurchaseID;
        private System.Windows.Forms.TextBox textBoxPreviousQuantity;
        private System.Windows.Forms.TextBox textBoxProductID;
        private System.Windows.Forms.TextBox textBoxPreviousCode;
        private System.Windows.Forms.Button buttonAddMore;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}