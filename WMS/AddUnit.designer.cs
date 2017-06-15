namespace WMS
{
    partial class AddUnit
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxUnitID = new System.Windows.Forms.TextBox();
            this.textBoxUnitName = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.Label();
            this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchasedetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewViewUnit = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasedetailsBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViewUnit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.buttonUpdate);
            this.panel2.Controls.Add(this.buttonAdd);
            this.panel2.Controls.Add(this.textBoxUnitID);
            this.panel2.Controls.Add(this.textBoxUnitName);
            this.panel2.Controls.Add(this.Address);
            this.panel2.Location = new System.Drawing.Point(2, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 290);
            this.panel2.TabIndex = 35;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(168, 139);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 29);
            this.buttonUpdate.TabIndex = 41;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Thistle;
            this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(97, 139);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(65, 29);
            this.buttonAdd.TabIndex = 40;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxUnitID
            // 
            this.textBoxUnitID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnitID.Location = new System.Drawing.Point(28, 62);
            this.textBoxUnitID.Name = "textBoxUnitID";
            this.textBoxUnitID.Size = new System.Drawing.Size(68, 26);
            this.textBoxUnitID.TabIndex = 11;
            this.textBoxUnitID.Visible = false;
            // 
            // textBoxUnitName
            // 
            this.textBoxUnitName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnitName.Location = new System.Drawing.Point(101, 103);
            this.textBoxUnitName.Name = "textBoxUnitName";
            this.textBoxUnitName.Size = new System.Drawing.Size(142, 26);
            this.textBoxUnitName.TabIndex = 3;
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Address.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Address.Location = new System.Drawing.Point(28, 104);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(68, 20);
            this.Address.TabIndex = 2;
            this.Address.Text = "Unit Name";
            // 
            // unitBindingSource
            // 
            this.unitBindingSource.DataMember = "unit";
            // 
            // purchasedetailsBindingSource
            // 
            this.purchasedetailsBindingSource.DataMember = "purchase_details";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CadetBlue;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(2, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(268, 37);
            this.panel4.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(81, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Add / Update Unit";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.CadetBlue;
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(276, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(253, 36);
            this.panel6.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(79, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "View Unit";
            // 
            // dataGridViewViewUnit
            // 
            this.dataGridViewViewUnit.AllowUserToAddRows = false;
            this.dataGridViewViewUnit.AllowUserToDeleteRows = false;
            this.dataGridViewViewUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewViewUnit.Location = new System.Drawing.Point(276, 36);
            this.dataGridViewViewUnit.Name = "dataGridViewViewUnit";
            this.dataGridViewViewUnit.ReadOnly = true;
            this.dataGridViewViewUnit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewViewUnit.Size = new System.Drawing.Size(253, 290);
            this.dataGridViewViewUnit.TabIndex = 40;
            this.dataGridViewViewUnit.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewViewUnit_CellMouseDoubleClick);
            // 
            // UnitType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(529, 327);
            this.Controls.Add(this.dataGridViewViewUnit);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UnitType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unit Type";
            this.Load += new System.EventHandler(this.UnitType_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasedetailsBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViewUnit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxUnitName;
        private System.Windows.Forms.Label Address;

        private System.Windows.Forms.BindingSource purchasedetailsBindingSource;


        private System.Windows.Forms.BindingSource unitBindingSource;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewViewUnit;
        private System.Windows.Forms.TextBox textBoxUnitID;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
    }
}