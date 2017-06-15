namespace WMS
{
    partial class AddCustomer
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
            this.components = new System.ComponentModel.Container();
            this.panelAddCategory = new System.Windows.Forms.Panel();
            this.textBoxVatRegNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCustPreDue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCustomerId = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxCustomerAddress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxCustomerEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxCustomerPhone = new System.Windows.Forms.TextBox();
            this.textBoxGroupName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddBuyer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buyerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelAddCategory.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAddCategory
            // 
            this.panelAddCategory.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelAddCategory.Controls.Add(this.textBoxVatRegNo);
            this.panelAddCategory.Controls.Add(this.label9);
            this.panelAddCategory.Controls.Add(this.label6);
            this.panelAddCategory.Controls.Add(this.textBoxCustPreDue);
            this.panelAddCategory.Controls.Add(this.label4);
            this.panelAddCategory.Controls.Add(this.textBoxCustomerId);
            this.panelAddCategory.Controls.Add(this.buttonUpdate);
            this.panelAddCategory.Controls.Add(this.textBoxCustomerAddress);
            this.panelAddCategory.Controls.Add(this.label11);
            this.panelAddCategory.Controls.Add(this.textBoxCustomerEmail);
            this.panelAddCategory.Controls.Add(this.label10);
            this.panelAddCategory.Controls.Add(this.textBoxCustomerPhone);
            this.panelAddCategory.Controls.Add(this.textBoxGroupName);
            this.panelAddCategory.Controls.Add(this.label8);
            this.panelAddCategory.Controls.Add(this.textBoxCustomerName);
            this.panelAddCategory.Controls.Add(this.label3);
            this.panelAddCategory.Controls.Add(this.btnAddBuyer);
            this.panelAddCategory.Location = new System.Drawing.Point(1, 50);
            this.panelAddCategory.Name = "panelAddCategory";
            this.panelAddCategory.Size = new System.Drawing.Size(267, 490);
            this.panelAddCategory.TabIndex = 13;
            // 
            // textBoxVatRegNo
            // 
            this.textBoxVatRegNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVatRegNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxVatRegNo.Location = new System.Drawing.Point(16, 222);
            this.textBoxVatRegNo.Name = "textBoxVatRegNo";
            this.textBoxVatRegNo.Size = new System.Drawing.Size(238, 22);
            this.textBoxVatRegNo.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(13, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 16);
            this.label9.TabIndex = 46;
            this.label9.Text = "Customer VAT REG NO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(16, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 16);
            this.label6.TabIndex = 42;
            this.label6.Text = "Customer Group";
            // 
            // textBoxCustPreDue
            // 
            this.textBoxCustPreDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustPreDue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxCustPreDue.Location = new System.Drawing.Point(14, 413);
            this.textBoxCustPreDue.Name = "textBoxCustPreDue";
            this.textBoxCustPreDue.Size = new System.Drawing.Size(238, 22);
            this.textBoxCustPreDue.TabIndex = 26;
            this.textBoxCustPreDue.Text = "0";
            this.textBoxCustPreDue.Visible = false;
            this.textBoxCustPreDue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCustPreDue_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(11, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "Customer Previous Due";
            this.label4.Visible = false;
            // 
            // textBoxCustomerId
            // 
            this.textBoxCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomerId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxCustomerId.Location = new System.Drawing.Point(155, 16);
            this.textBoxCustomerId.Name = "textBoxCustomerId";
            this.textBoxCustomerId.Size = new System.Drawing.Size(97, 22);
            this.textBoxCustomerId.TabIndex = 37;
            this.textBoxCustomerId.Visible = false;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(136, 447);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(116, 39);
            this.buttonUpdate.TabIndex = 36;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxCustomerAddress
            // 
            this.textBoxCustomerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomerAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxCustomerAddress.Location = new System.Drawing.Point(14, 333);
            this.textBoxCustomerAddress.Multiline = true;
            this.textBoxCustomerAddress.Name = "textBoxCustomerAddress";
            this.textBoxCustomerAddress.Size = new System.Drawing.Size(238, 48);
            this.textBoxCustomerAddress.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(12, 308);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 16);
            this.label11.TabIndex = 31;
            this.label11.Text = "Customer Address";
            // 
            // textBoxCustomerEmail
            // 
            this.textBoxCustomerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomerEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxCustomerEmail.Location = new System.Drawing.Point(14, 281);
            this.textBoxCustomerEmail.Name = "textBoxCustomerEmail";
            this.textBoxCustomerEmail.Size = new System.Drawing.Size(238, 22);
            this.textBoxCustomerEmail.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(11, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "Customer Email";
            // 
            // textBoxCustomerPhone
            // 
            this.textBoxCustomerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomerPhone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxCustomerPhone.Location = new System.Drawing.Point(16, 163);
            this.textBoxCustomerPhone.Name = "textBoxCustomerPhone";
            this.textBoxCustomerPhone.Size = new System.Drawing.Size(238, 22);
            this.textBoxCustomerPhone.TabIndex = 22;
            // 
            // textBoxGroupName
            // 
            this.textBoxGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGroupName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxGroupName.Location = new System.Drawing.Point(16, 102);
            this.textBoxGroupName.Name = "textBoxGroupName";
            this.textBoxGroupName.Size = new System.Drawing.Size(238, 22);
            this.textBoxGroupName.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(15, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Customer Phone";
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomerName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxCustomerName.Location = new System.Drawing.Point(16, 43);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(238, 22);
            this.textBoxCustomerName.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Customer Name";
            // 
            // btnAddBuyer
            // 
            this.btnAddBuyer.BackColor = System.Drawing.Color.Thistle;
            this.btnAddBuyer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddBuyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBuyer.Location = new System.Drawing.Point(15, 447);
            this.btnAddBuyer.Name = "btnAddBuyer";
            this.btnAddBuyer.Size = new System.Drawing.Size(116, 39);
            this.btnAddBuyer.TabIndex = 27;
            this.btnAddBuyer.Text = "ADD";
            this.btnAddBuyer.UseVisualStyleBackColor = false;
            this.btnAddBuyer.Click += new System.EventHandler(this.btnAddBuyer_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 49);
            this.panel1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Add Customer Information";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(271, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(829, 49);
            this.panel2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(334, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "View Customer Information";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(271, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(829, 490);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // buyerBindingSource
            // 
            this.buyerBindingSource.DataMember = "buyer";
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 541);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelAddCategory);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Customer";
            this.Load += new System.EventHandler(this.AddCustomer_Load);
            this.panelAddCategory.ResumeLayout(false);
            this.panelAddCategory.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAddCategory;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxCustomerEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxCustomerPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddBuyer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        // private POSDataSet2 pOSDataSet2;
        private System.Windows.Forms.BindingSource buyerBindingSource;
        private System.Windows.Forms.TextBox textBoxCustomerAddress;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxCustomerId;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxCustPreDue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxVatRegNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxGroupName;
    }
}