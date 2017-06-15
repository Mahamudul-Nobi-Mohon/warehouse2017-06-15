namespace WMS
{
    partial class AddWarehouse
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewViewFloor = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAddCategory = new System.Windows.Forms.Panel();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxFloorId = new System.Windows.Forms.TextBox();
            this.textBoxWarehouseName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViewFloor)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelAddCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.dataGridViewViewFloor);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panelAddCategory);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 222);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewViewFloor
            // 
            this.dataGridViewViewFloor.AllowUserToAddRows = false;
            this.dataGridViewViewFloor.AllowUserToDeleteRows = false;
            this.dataGridViewViewFloor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewViewFloor.Location = new System.Drawing.Point(300, 39);
            this.dataGridViewViewFloor.Name = "dataGridViewViewFloor";
            this.dataGridViewViewFloor.ReadOnly = true;
            this.dataGridViewViewFloor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewViewFloor.Size = new System.Drawing.Size(275, 180);
            this.dataGridViewViewFloor.TabIndex = 25;
            this.dataGridViewViewFloor.DoubleClick += new System.EventHandler(this.dataGridViewViewFloor_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 36);
            this.panel2.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(77, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Add Warehouse";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CadetBlue;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(300, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(275, 36);
            this.panel3.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(70, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "View Warehouse";
            // 
            // panelAddCategory
            // 
            this.panelAddCategory.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelAddCategory.Controls.Add(this.buttonUpdate);
            this.panelAddCategory.Controls.Add(this.buttonAdd);
            this.panelAddCategory.Controls.Add(this.textBoxFloorId);
            this.panelAddCategory.Controls.Add(this.textBoxWarehouseName);
            this.panelAddCategory.Controls.Add(this.label3);
            this.panelAddCategory.Location = new System.Drawing.Point(4, 39);
            this.panelAddCategory.Name = "panelAddCategory";
            this.panelAddCategory.Size = new System.Drawing.Size(291, 180);
            this.panelAddCategory.TabIndex = 22;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(208, 71);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 29);
            this.buttonUpdate.TabIndex = 37;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Thistle;
            this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(124, 71);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(74, 29);
            this.buttonAdd.TabIndex = 36;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxFloorId
            // 
            this.textBoxFloorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFloorId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxFloorId.Location = new System.Drawing.Point(25, 74);
            this.textBoxFloorId.Name = "textBoxFloorId";
            this.textBoxFloorId.ReadOnly = true;
            this.textBoxFloorId.Size = new System.Drawing.Size(48, 22);
            this.textBoxFloorId.TabIndex = 32;
            this.textBoxFloorId.Visible = false;
            // 
            // textBoxWarehouseName
            // 
            this.textBoxWarehouseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWarehouseName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxWarehouseName.Location = new System.Drawing.Point(126, 43);
            this.textBoxWarehouseName.Name = "textBoxWarehouseName";
            this.textBoxWarehouseName.Size = new System.Drawing.Size(156, 22);
            this.textBoxWarehouseName.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(5, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Warehouse Name";
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "supplier";
            // 
            // AddWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 221);
            this.Controls.Add(this.panel1);
            this.Name = "AddWarehouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Warehouse";
            this.Load += new System.EventHandler(this.AddFloor_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViewFloor)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelAddCategory.ResumeLayout(false);
            this.panelAddCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewViewFloor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelAddCategory;
        private System.Windows.Forms.TextBox textBoxWarehouseName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxFloorId;
    }
}