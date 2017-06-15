namespace WMS
{
    partial class Purchase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.treeViewPurchaseItem = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxFloor = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.comboBoxWarehouse = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxSupplierInvoiceNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.textBoxCurrentStock = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxUnitType = new System.Windows.Forms.TextBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPdoductId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPurchaseNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxSupplierName = new System.Windows.Forms.ComboBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxItemTotal = new System.Windows.Forms.TextBox();
            this.textBoxProductTotal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonAddSupplier = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridViewSales = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonPurchase = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxRemarks = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).BeginInit();
            this.SuspendLayout();
            // 
            // treeViewPurchaseItem
            // 
            this.treeViewPurchaseItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewPurchaseItem.Location = new System.Drawing.Point(3, 42);
            this.treeViewPurchaseItem.Name = "treeViewPurchaseItem";
            this.treeViewPurchaseItem.Size = new System.Drawing.Size(245, 475);
            this.treeViewPurchaseItem.TabIndex = 0;
            this.treeViewPurchaseItem.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewPurchaseItem_AfterSelect);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 42);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Purchase";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.comboBoxFloor);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.comboBoxWarehouse);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.textBoxSupplierInvoiceNo);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBoxTime);
            this.panel2.Controls.Add(this.textBoxCurrentStock);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.textBoxDate);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.textBoxQuantity);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.textBoxUnitType);
            this.panel2.Controls.Add(this.textBoxProductName);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBoxPdoductId);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBoxPurchaseNo);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(250, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(823, 171);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // comboBoxFloor
            // 
            this.comboBoxFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.comboBoxFloor.FormattingEnabled = true;
            this.comboBoxFloor.Location = new System.Drawing.Point(431, 92);
            this.comboBoxFloor.Name = "comboBoxFloor";
            this.comboBoxFloor.Size = new System.Drawing.Size(146, 26);
            this.comboBoxFloor.TabIndex = 56;
            this.comboBoxFloor.SelectedIndexChanged += new System.EventHandler(this.comboBoxFloor_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label18.Location = new System.Drawing.Point(324, 95);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(101, 20);
            this.label18.TabIndex = 55;
            this.label18.Text = "Floor Name";
            // 
            // comboBoxWarehouse
            // 
            this.comboBoxWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.comboBoxWarehouse.FormattingEnabled = true;
            this.comboBoxWarehouse.Location = new System.Drawing.Point(170, 92);
            this.comboBoxWarehouse.Name = "comboBoxWarehouse";
            this.comboBoxWarehouse.Size = new System.Drawing.Size(147, 26);
            this.comboBoxWarehouse.TabIndex = 56;
            this.comboBoxWarehouse.SelectedIndexChanged += new System.EventHandler(this.comboBoxWarehouse_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(16, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(151, 20);
            this.label15.TabIndex = 55;
            this.label15.Text = "Warehouse Name";
            // 
            // textBoxSupplierInvoiceNo
            // 
            this.textBoxSupplierInvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSupplierInvoiceNo.Location = new System.Drawing.Point(170, 16);
            this.textBoxSupplierInvoiceNo.Name = "textBoxSupplierInvoiceNo";
            this.textBoxSupplierInvoiceNo.Size = new System.Drawing.Size(146, 24);
            this.textBoxSupplierInvoiceNo.TabIndex = 34;
            this.textBoxSupplierInvoiceNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSupplierInvoiceNo_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(0, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Supplier Invoice No";
            // 
            // textBoxTime
            // 
            this.textBoxTime.BackColor = System.Drawing.Color.Thistle;
            this.textBoxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTime.Location = new System.Drawing.Point(669, 54);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(146, 24);
            this.textBoxTime.TabIndex = 25;
            // 
            // textBoxCurrentStock
            // 
            this.textBoxCurrentStock.BackColor = System.Drawing.Color.Thistle;
            this.textBoxCurrentStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCurrentStock.ForeColor = System.Drawing.Color.Red;
            this.textBoxCurrentStock.Location = new System.Drawing.Point(170, 130);
            this.textBoxCurrentStock.Name = "textBoxCurrentStock";
            this.textBoxCurrentStock.ReadOnly = true;
            this.textBoxCurrentStock.Size = new System.Drawing.Size(146, 26);
            this.textBoxCurrentStock.TabIndex = 31;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label17.Location = new System.Drawing.Point(27, 133);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(132, 20);
            this.label17.TabIndex = 32;
            this.label17.Text = "Currently Stock";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // textBoxDate
            // 
            this.textBoxDate.BackColor = System.Drawing.Color.Thistle;
            this.textBoxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDate.Location = new System.Drawing.Point(669, 16);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(146, 24);
            this.textBoxDate.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label13.Location = new System.Drawing.Point(618, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 18);
            this.label13.TabIndex = 22;
            this.label13.Text = "Time";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label12.Location = new System.Drawing.Point(622, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 18);
            this.label12.TabIndex = 20;
            this.label12.Text = "Date";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuantity.Location = new System.Drawing.Point(431, 132);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(146, 24);
            this.textBoxQuantity.TabIndex = 19;
            this.textBoxQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxQuantity_KeyDown);
            this.textBoxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Quantity_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label11.Location = new System.Drawing.Point(351, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 18);
            this.label11.TabIndex = 18;
            this.label11.Text = "Quantity";
            // 
            // textBoxUnitType
            // 
            this.textBoxUnitType.BackColor = System.Drawing.Color.Thistle;
            this.textBoxUnitType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnitType.Location = new System.Drawing.Point(431, 54);
            this.textBoxUnitType.Name = "textBoxUnitType";
            this.textBoxUnitType.ReadOnly = true;
            this.textBoxUnitType.Size = new System.Drawing.Size(146, 24);
            this.textBoxUnitType.TabIndex = 17;
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.BackColor = System.Drawing.Color.Thistle;
            this.textBoxProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductName.Location = new System.Drawing.Point(170, 54);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.ReadOnly = true;
            this.textBoxProductName.Size = new System.Drawing.Size(146, 24);
            this.textBoxProductName.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(43, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "Product Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(343, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Unit Type";
            // 
            // textBoxPdoductId
            // 
            this.textBoxPdoductId.BackColor = System.Drawing.Color.Thistle;
            this.textBoxPdoductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPdoductId.Location = new System.Drawing.Point(669, 92);
            this.textBoxPdoductId.Name = "textBoxPdoductId";
            this.textBoxPdoductId.ReadOnly = true;
            this.textBoxPdoductId.Size = new System.Drawing.Size(146, 24);
            this.textBoxPdoductId.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(592, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Product Id";
            // 
            // textBoxPurchaseNo
            // 
            this.textBoxPurchaseNo.BackColor = System.Drawing.Color.Thistle;
            this.textBoxPurchaseNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPurchaseNo.Location = new System.Drawing.Point(431, 16);
            this.textBoxPurchaseNo.Name = "textBoxPurchaseNo";
            this.textBoxPurchaseNo.ReadOnly = true;
            this.textBoxPurchaseNo.Size = new System.Drawing.Size(146, 24);
            this.textBoxPurchaseNo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(344, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Track No";
            // 
            // comboBoxSupplierName
            // 
            this.comboBoxSupplierName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSupplierName.FormattingEnabled = true;
            this.comboBoxSupplierName.Location = new System.Drawing.Point(137, 8);
            this.comboBoxSupplierName.Name = "comboBoxSupplierName";
            this.comboBoxSupplierName.Size = new System.Drawing.Size(157, 28);
            this.comboBoxSupplierName.TabIndex = 1;
            this.comboBoxSupplierName.SelectedIndexChanged += new System.EventHandler(this.comboBoxSupplierName_SelectedIndexChanged);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.Location = new System.Drawing.Point(467, 8);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(344, 24);
            this.textBoxAddress.TabIndex = 3;
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.BackColor = System.Drawing.Color.CadetBlue;
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.ForeColor = System.Drawing.Color.Yellow;
            this.Address.Location = new System.Drawing.Point(378, 11);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(75, 20);
            this.Address.TabIndex = 2;
            this.Address.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.CadetBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(9, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Supplier Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(254, 494);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Item Total";
            // 
            // textBoxItemTotal
            // 
            this.textBoxItemTotal.BackColor = System.Drawing.Color.Thistle;
            this.textBoxItemTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxItemTotal.Location = new System.Drawing.Point(332, 492);
            this.textBoxItemTotal.Name = "textBoxItemTotal";
            this.textBoxItemTotal.ReadOnly = true;
            this.textBoxItemTotal.Size = new System.Drawing.Size(84, 24);
            this.textBoxItemTotal.TabIndex = 25;
            // 
            // textBoxProductTotal
            // 
            this.textBoxProductTotal.BackColor = System.Drawing.Color.Thistle;
            this.textBoxProductTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductTotal.Location = new System.Drawing.Point(538, 492);
            this.textBoxProductTotal.Name = "textBoxProductTotal";
            this.textBoxProductTotal.ReadOnly = true;
            this.textBoxProductTotal.Size = new System.Drawing.Size(71, 24);
            this.textBoxProductTotal.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label14.Location = new System.Drawing.Point(435, 495);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 18);
            this.label14.TabIndex = 26;
            this.label14.Text = "Product Total";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CadetBlue;
            this.panel3.Controls.Add(this.buttonAddSupplier);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.comboBoxSupplierName);
            this.panel3.Controls.Add(this.Address);
            this.panel3.Controls.Add(this.textBoxAddress);
            this.panel3.Location = new System.Drawing.Point(250, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(823, 42);
            this.panel3.TabIndex = 33;
            // 
            // buttonAddSupplier
            // 
            this.buttonAddSupplier.BackColor = System.Drawing.Color.Red;
            this.buttonAddSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonAddSupplier.Location = new System.Drawing.Point(300, 8);
            this.buttonAddSupplier.Name = "buttonAddSupplier";
            this.buttonAddSupplier.Size = new System.Drawing.Size(47, 29);
            this.buttonAddSupplier.TabIndex = 59;
            this.buttonAddSupplier.Text = "New";
            this.buttonAddSupplier.UseVisualStyleBackColor = false;
            this.buttonAddSupplier.Click += new System.EventHandler(this.buttonAddSupplier_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.panel4.Controls.Add(this.dataGridViewSales);
            this.panel4.Location = new System.Drawing.Point(250, 218);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(824, 222);
            this.panel4.TabIndex = 34;
            // 
            // dataGridViewSales
            // 
            this.dataGridViewSales.AllowUserToAddRows = false;
            this.dataGridViewSales.AllowUserToDeleteRows = false;
            this.dataGridViewSales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSales.Location = new System.Drawing.Point(2, 2);
            this.dataGridViewSales.Name = "dataGridViewSales";
            this.dataGridViewSales.ReadOnly = true;
            this.dataGridViewSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSales.Size = new System.Drawing.Size(819, 213);
            this.dataGridViewSales.TabIndex = 0;
            this.dataGridViewSales.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewSales_CellMouseDoubleClick);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.Thistle;
            this.buttonAdd.Location = new System.Drawing.Point(626, 450);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(95, 34);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.LavenderBlush;
            this.buttonUpdate.Location = new System.Drawing.Point(976, 450);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(95, 34);
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.DarkMagenta;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.Thistle;
            this.buttonDelete.Location = new System.Drawing.Point(862, 450);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(96, 34);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonPurchase
            // 
            this.buttonPurchase.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPurchase.ForeColor = System.Drawing.Color.LavenderBlush;
            this.buttonPurchase.Location = new System.Drawing.Point(739, 450);
            this.buttonPurchase.Name = "buttonPurchase";
            this.buttonPurchase.Size = new System.Drawing.Size(106, 34);
            this.buttonPurchase.TabIndex = 9;
            this.buttonPurchase.Text = "Purchase";
            this.buttonPurchase.UseVisualStyleBackColor = false;
            this.buttonPurchase.Click += new System.EventHandler(this.buttonPurchase_Click);
            this.buttonPurchase.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonPurchase_KeyDown);
            this.buttonPurchase.MouseEnter += new System.EventHandler(this.buttonPurchase_MouseEnter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(254, 455);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Remarks";
            // 
            // textBoxRemarks
            // 
            this.textBoxRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRemarks.Location = new System.Drawing.Point(325, 453);
            this.textBoxRemarks.Name = "textBoxRemarks";
            this.textBoxRemarks.Size = new System.Drawing.Size(286, 24);
            this.textBoxRemarks.TabIndex = 35;
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 531);
            this.Controls.Add(this.textBoxRemarks);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textBoxProductTotal);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBoxItemTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonPurchase);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeViewPurchaseItem);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1094, 570);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1094, 570);
            this.Name = "Purchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Item";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FromPurchaseClosed);
            this.Load += new System.EventHandler(this.FormPurchaseItemBody_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewPurchaseItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxUnitType;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPdoductId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPurchaseNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSupplierName;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxItemTotal;
        private System.Windows.Forms.TextBox textBoxProductTotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel3;

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridViewSales;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonPurchase;
        private System.Windows.Forms.TextBox textBoxCurrentStock;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxSupplierInvoiceNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAddSupplier;
        private System.Windows.Forms.ComboBox comboBoxFloor;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox comboBoxWarehouse;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxRemarks;
    }
}