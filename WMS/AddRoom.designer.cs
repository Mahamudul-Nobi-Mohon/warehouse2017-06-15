namespace WMS
{
    partial class AddRoom
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAddCategory = new System.Windows.Forms.Panel();
            this.comboBoxFloorName = new System.Windows.Forms.ComboBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSupplierUpdate = new System.Windows.Forms.Button();
            this.textBoxFloorId = new System.Windows.Forms.TextBox();
            this.textBoxSectionName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelAddCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 36);
            this.panel2.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(77, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Add Room";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CadetBlue;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(297, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(365, 36);
            this.panel3.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(118, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "View Room";
            // 
            // panelAddCategory
            // 
            this.panelAddCategory.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelAddCategory.Controls.Add(this.comboBoxFloorName);
            this.panelAddCategory.Controls.Add(this.buttonUpdate);
            this.panelAddCategory.Controls.Add(this.buttonAdd);
            this.panelAddCategory.Controls.Add(this.buttonSupplierUpdate);
            this.panelAddCategory.Controls.Add(this.textBoxFloorId);
            this.panelAddCategory.Controls.Add(this.textBoxSectionName);
            this.panelAddCategory.Controls.Add(this.label4);
            this.panelAddCategory.Controls.Add(this.label3);
            this.panelAddCategory.Controls.Add(this.btnAddSupplier);
            this.panelAddCategory.Location = new System.Drawing.Point(1, 37);
            this.panelAddCategory.Name = "panelAddCategory";
            this.panelAddCategory.Size = new System.Drawing.Size(291, 266);
            this.panelAddCategory.TabIndex = 25;
            // 
            // comboBoxFloorName
            // 
            this.comboBoxFloorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxFloorName.FormattingEnabled = true;
            this.comboBoxFloorName.Location = new System.Drawing.Point(126, 67);
            this.comboBoxFloorName.Name = "comboBoxFloorName";
            this.comboBoxFloorName.Size = new System.Drawing.Size(156, 24);
            this.comboBoxFloorName.TabIndex = 38;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(207, 131);
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
            this.buttonAdd.Location = new System.Drawing.Point(126, 131);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(74, 29);
            this.buttonAdd.TabIndex = 36;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSupplierUpdate
            // 
            this.buttonSupplierUpdate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonSupplierUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSupplierUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupplierUpdate.Location = new System.Drawing.Point(159, 446);
            this.buttonSupplierUpdate.Name = "buttonSupplierUpdate";
            this.buttonSupplierUpdate.Size = new System.Drawing.Size(102, 29);
            this.buttonSupplierUpdate.TabIndex = 33;
            this.buttonSupplierUpdate.Text = "UPDATE";
            this.buttonSupplierUpdate.UseVisualStyleBackColor = false;
            // 
            // textBoxFloorId
            // 
            this.textBoxFloorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFloorId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxFloorId.Location = new System.Drawing.Point(25, 134);
            this.textBoxFloorId.Name = "textBoxFloorId";
            this.textBoxFloorId.ReadOnly = true;
            this.textBoxFloorId.Size = new System.Drawing.Size(48, 22);
            this.textBoxFloorId.TabIndex = 32;
            this.textBoxFloorId.Visible = false;
            // 
            // textBoxSectionName
            // 
            this.textBoxSectionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxSectionName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxSectionName.Location = new System.Drawing.Point(126, 98);
            this.textBoxSectionName.Name = "textBoxSectionName";
            this.textBoxSectionName.Size = new System.Drawing.Size(156, 24);
            this.textBoxSectionName.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(9, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Select Warehouse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(9, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Room Name";
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.BackColor = System.Drawing.Color.Thistle;
            this.btnAddSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSupplier.Location = new System.Drawing.Point(24, 446);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(102, 29);
            this.btnAddSupplier.TabIndex = 7;
            this.btnAddSupplier.Text = "ADD";
            this.btnAddSupplier.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(298, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(365, 266);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 303);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelAddCategory);
            this.Name = "AddRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Room";
            this.Load += new System.EventHandler(this.AddSection_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelAddCategory.ResumeLayout(false);
            this.panelAddCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelAddCategory;
        private System.Windows.Forms.ComboBox comboBoxFloorName;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSupplierUpdate;
        private System.Windows.Forms.TextBox textBoxFloorId;
        private System.Windows.Forms.TextBox textBoxSectionName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}