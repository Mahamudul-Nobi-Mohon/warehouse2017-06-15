using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMS
{
    public partial class MainBody : Form
    {
        public MainBody()
        {
            InitializeComponent();
        }

        private void addUnitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUnit aunittype = new AddUnit();
            aunittype.ShowDialog();
        }

        private void addWarehouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddWarehouse addwarehouse = new AddWarehouse();
            addwarehouse.ShowDialog();
        }

        private void addRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRoom addroom = new AddRoom();
            addroom.ShowDialog();
        }

        private void addCellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCell addcell = new AddCell();
            addcell.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login DPRR = new Login();
            Hide();
            DPRR.Show();
        }

        private void itemsSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemSetting itmset = new ItemSetting();
            itmset.ShowDialog();
        }

        private void itemSettingsEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemSettingEdit itmsetedit = new ItemSettingEdit();
            itmsetedit.ShowDialog();
        }

        private void addSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSupplier addsupplier = new AddSupplier();
            addsupplier.ShowDialog();
        }

        private void databaseBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatabaseBackUP databasebackup = new DatabaseBackUP();
            databasebackup.ShowDialog();
        }

        private void damageProductReceiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DamageProductReceive dpr = new DamageProductReceive();
            dpr.ShowDialog();
        }

        private void damageProductReceiveReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DamageProductReceiveReport dprr = new DamageProductReceiveReport();
            dprr.ShowDialog();
        }

        private void purchaseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Purchase purchase = new Purchase();
            purchase.ShowDialog();
        }

        private void purchaseReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseReturn pr = new PurchaseReturn();
            pr.ShowDialog();
        }

        private void puechaseEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseEdit puredit = new PurchaseEdit();
            puredit.ShowDialog();
        }

        private void purchaseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseReport purreport = new PurchaseReport();
            purreport.ShowDialog();
        }

        private void salesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Sales sale = new Sales();
            sale.ShowDialog();
        }

        private void salesReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesReturn salereturn = new SalesReturn();
            salereturn.ShowDialog();
        }

        private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesReport salesre = new SalesReport();
            salesre.ShowDialog();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer addcustomer = new AddCustomer();
            addcustomer.ShowDialog();
        }

        private void stockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockReport astockreport = new StockReport();
            astockreport.ShowDialog();
        }

        private void salesReport2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesReport2 sreport2 = new SalesReport2();
            sreport2.ShowDialog();
        }
    }
}
