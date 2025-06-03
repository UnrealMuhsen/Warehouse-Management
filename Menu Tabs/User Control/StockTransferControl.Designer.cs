namespace InventorySystem.Tabs.User_Control
{
    partial class StockTransferControl
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ComboBox cmbFromStore;
        private System.Windows.Forms.ComboBox cmbToStore;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.DateTimePicker dtpProductionDate;
        private System.Windows.Forms.TextBox txtExpiryMonths;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.DataGridView dgvTransfers;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            cmbFromStore = new ComboBox();
            cmbToStore = new ComboBox();
            cmbItem = new ComboBox();
            txtQuantity = new TextBox();
            cmbSupplier = new ComboBox();
            dtpProductionDate = new DateTimePicker();
            txtExpiryMonths = new TextBox();
            btnTransfer = new Button();
            dgvTransfers = new DataGridView();
            lblFrom = new Label();
            lblTo = new Label();
            lblItem = new Label();
            lblQty = new Label();
            lblSupplier = new Label();
            lblProdDate = new Label();
            lblExpiry = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnDeleteTransfer = new Button();
            btnEditTransfer = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTransfers).BeginInit();
            SuspendLayout();
            // 
            // cmbFromStore
            // 
            cmbFromStore.Location = new Point(251, 91);
            cmbFromStore.Name = "cmbFromStore";
            cmbFromStore.Size = new Size(195, 28);
            cmbFromStore.TabIndex = 1;
            // 
            // cmbToStore
            // 
            cmbToStore.Location = new Point(251, 131);
            cmbToStore.Name = "cmbToStore";
            cmbToStore.Size = new Size(195, 28);
            cmbToStore.TabIndex = 3;
            // 
            // cmbItem
            // 
            cmbItem.Location = new Point(616, 91);
            cmbItem.Name = "cmbItem";
            cmbItem.Size = new Size(200, 28);
            cmbItem.TabIndex = 5;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(616, 125);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(200, 27);
            txtQuantity.TabIndex = 7;
            // 
            // cmbSupplier
            // 
            cmbSupplier.Location = new Point(251, 171);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(195, 28);
            cmbSupplier.TabIndex = 9;
            // 
            // dtpProductionDate
            // 
            dtpProductionDate.Location = new Point(616, 158);
            dtpProductionDate.Name = "dtpProductionDate";
            dtpProductionDate.Size = new Size(200, 27);
            dtpProductionDate.TabIndex = 11;
            // 
            // txtExpiryMonths
            // 
            txtExpiryMonths.Location = new Point(621, 191);
            txtExpiryMonths.Name = "txtExpiryMonths";
            txtExpiryMonths.Size = new Size(195, 27);
            txtExpiryMonths.TabIndex = 13;
            // 
            // btnTransfer
            // 
            btnTransfer.BackColor = SystemColors.ButtonHighlight;
            btnTransfer.Location = new Point(391, 248);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(86, 39);
            btnTransfer.TabIndex = 14;
            btnTransfer.Text = "تحويل الصنف";
            btnTransfer.UseVisualStyleBackColor = false;
            btnTransfer.Click += btnTransfer_Click;
            // 
            // dgvTransfers
            // 
            dgvTransfers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransfers.BackgroundColor = SystemColors.ControlLightLight;
            dgvTransfers.ColumnHeadersHeight = 29;
            dgvTransfers.Location = new Point(234, 293);
            dgvTransfers.Name = "dgvTransfers";
            dgvTransfers.RowHeadersWidth = 51;
            dgvTransfers.Size = new Size(720, 250);
            dgvTransfers.TabIndex = 15;
            // 
            // lblFrom
            // 
            lblFrom.Location = new Point(0, 0);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(100, 23);
            lblFrom.TabIndex = 0;
            // 
            // lblTo
            // 
            lblTo.Location = new Point(0, 0);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(100, 23);
            lblTo.TabIndex = 2;
            // 
            // lblItem
            // 
            lblItem.Location = new Point(0, 0);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(100, 23);
            lblItem.TabIndex = 4;
            // 
            // lblQty
            // 
            lblQty.Location = new Point(0, 0);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(100, 23);
            lblQty.TabIndex = 6;
            // 
            // lblSupplier
            // 
            lblSupplier.Location = new Point(0, 0);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(100, 23);
            lblSupplier.TabIndex = 8;
            // 
            // lblProdDate
            // 
            lblProdDate.Location = new Point(0, 0);
            lblProdDate.Name = "lblProdDate";
            lblProdDate.Size = new Size(100, 23);
            lblProdDate.TabIndex = 10;
            // 
            // lblExpiry
            // 
            lblExpiry.Location = new Point(0, 0);
            lblExpiry.Name = "lblExpiry";
            lblExpiry.Size = new Size(100, 23);
            lblExpiry.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(474, 91);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 16;
            label1.Text = "من مخزن :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(472, 131);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 17;
            label2.Text = "الى مخزن :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(470, 171);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 18;
            label3.Text = "اسم المورد";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(839, 191);
            label4.Name = "label4";
            label4.Size = new Size(183, 20);
            label4.TabIndex = 19;
            label4.Text = "صلاحية الانتهاء (عدد الاشهر)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(856, 91);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 20;
            label5.Text = "اسم الصنف";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(891, 125);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 21;
            label6.Text = "الكمية";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(860, 158);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 22;
            label7.Text = "تاريخ الانتاج";
            // 
            // btnDeleteTransfer
            // 
            btnDeleteTransfer.Location = new Point(677, 248);
            btnDeleteTransfer.Name = "btnDeleteTransfer";
            btnDeleteTransfer.Size = new Size(75, 35);
            btnDeleteTransfer.TabIndex = 23;
            btnDeleteTransfer.Text = "حذف";
            btnDeleteTransfer.UseVisualStyleBackColor = true;
            btnDeleteTransfer.Click += btnDeleteTransfer_Click;
            // 
            // btnEditTransfer
            // 
            btnEditTransfer.Location = new Point(552, 248);
            btnEditTransfer.Name = "btnEditTransfer";
            btnEditTransfer.Size = new Size(77, 35);
            btnEditTransfer.TabIndex = 24;
            btnEditTransfer.Text = "تعديل";
            btnEditTransfer.UseVisualStyleBackColor = true;
            btnEditTransfer.Click += btnEditTransfer_Click;
            // 
            // StockTransferControl
            // 
            BackColor = SystemColors.GradientActiveCaption;
            Controls.Add(btnEditTransfer);
            Controls.Add(btnDeleteTransfer);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblFrom);
            Controls.Add(cmbFromStore);
            Controls.Add(lblTo);
            Controls.Add(cmbToStore);
            Controls.Add(lblItem);
            Controls.Add(cmbItem);
            Controls.Add(lblQty);
            Controls.Add(txtQuantity);
            Controls.Add(lblSupplier);
            Controls.Add(cmbSupplier);
            Controls.Add(lblProdDate);
            Controls.Add(dtpProductionDate);
            Controls.Add(lblExpiry);
            Controls.Add(txtExpiryMonths);
            Controls.Add(btnTransfer);
            Controls.Add(dgvTransfers);
            Name = "StockTransferControl";
            Size = new Size(1320, 594);
            ((System.ComponentModel.ISupportInitialize)dgvTransfers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Label lblFrom;
        private Label lblTo;
        private Label lblItem;
        private Label lblQty;
        private Label lblSupplier;
        private Label lblProdDate;
        private Label lblExpiry;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnDeleteTransfer;
        private Button btnEditTransfer;
    }
}
