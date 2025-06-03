namespace InventorySystem.Tabs.User_Control
{
    partial class SupplyPermissionControl
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ComboBox cmbStore;
        private System.Windows.Forms.TextBox txtPermissionNumber;
        private System.Windows.Forms.DateTimePicker dtpPermissionDate;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.DateTimePicker dtpProductionDate;
        private System.Windows.Forms.Button btnAddSupply;
        private System.Windows.Forms.DataGridView dgvSupplyItems;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            cmbStore = new ComboBox();
            txtPermissionNumber = new TextBox();
            dtpPermissionDate = new DateTimePicker();
            cmbItem = new ComboBox();
            txtQuantity = new TextBox();
            txtItemCode = new TextBox();
            cmbSupplier = new ComboBox();
            dtpProductionDate = new DateTimePicker();
            btnAddSupply = new Button();
            dgvSupplyItems = new DataGridView();
            lblStore = new Label();
            lblPermNo = new Label();
            lblPermDate = new Label();
            lblItem = new Label();
            lblCode = new Label();
            lblQty = new Label();
            lblSupplier = new Label();
            lblProdDate = new Label();
            lblExp = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnDeleteSupply = new Button();
            btnEditSupply = new Button();
            txtExpiryMonths = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvSupplyItems).BeginInit();
            SuspendLayout();
            // 
            // cmbStore
            // 
            cmbStore.Location = new Point(647, 40);
            cmbStore.Name = "cmbStore";
            cmbStore.Size = new Size(200, 28);
            cmbStore.TabIndex = 1;
            // 
            // txtPermissionNumber
            // 
            txtPermissionNumber.Location = new Point(647, 80);
            txtPermissionNumber.Name = "txtPermissionNumber";
            txtPermissionNumber.Size = new Size(200, 27);
            txtPermissionNumber.TabIndex = 3;
            // 
            // dtpPermissionDate
            // 
            dtpPermissionDate.Location = new Point(647, 120);
            dtpPermissionDate.Name = "dtpPermissionDate";
            dtpPermissionDate.Size = new Size(200, 27);
            dtpPermissionDate.TabIndex = 5;
            // 
            // cmbItem
            // 
            cmbItem.Location = new Point(234, 40);
            cmbItem.Name = "cmbItem";
            cmbItem.Size = new Size(200, 28);
            cmbItem.TabIndex = 7;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(234, 120);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(200, 27);
            txtQuantity.TabIndex = 11;
            // 
            // txtItemCode
            // 
            txtItemCode.Location = new Point(234, 80);
            txtItemCode.Name = "txtItemCode";
            txtItemCode.Size = new Size(200, 27);
            txtItemCode.TabIndex = 9;
            // 
            // cmbSupplier
            // 
            cmbSupplier.Location = new Point(647, 160);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(200, 28);
            cmbSupplier.TabIndex = 13;
            // 
            // dtpProductionDate
            // 
            dtpProductionDate.Location = new Point(234, 160);
            dtpProductionDate.Name = "dtpProductionDate";
            dtpProductionDate.Size = new Size(200, 27);
            dtpProductionDate.TabIndex = 15;
            // 
            // btnAddSupply
            // 
            btnAddSupply.BackColor = SystemColors.ButtonHighlight;
            btnAddSupply.Location = new Point(705, 255);
            btnAddSupply.Name = "btnAddSupply";
            btnAddSupply.Size = new Size(88, 32);
            btnAddSupply.TabIndex = 18;
            btnAddSupply.Text = "إضافة إذن توريد";
            btnAddSupply.UseVisualStyleBackColor = false;
            btnAddSupply.Click += btnAddSupply_Click;
            // 
            // dgvSupplyItems
            // 
            dgvSupplyItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSupplyItems.BackgroundColor = SystemColors.ControlLightLight;
            dgvSupplyItems.ColumnHeadersHeight = 29;
            dgvSupplyItems.Location = new Point(234, 293);
            dgvSupplyItems.Name = "dgvSupplyItems";
            dgvSupplyItems.RowHeadersWidth = 51;
            dgvSupplyItems.Size = new Size(720, 250);
            dgvSupplyItems.TabIndex = 19;
            // 
            // lblStore
            // 
            lblStore.Location = new Point(0, 0);
            lblStore.Name = "lblStore";
            lblStore.Size = new Size(100, 23);
            lblStore.TabIndex = 0;
            // 
            // lblPermNo
            // 
            lblPermNo.Location = new Point(0, 0);
            lblPermNo.Name = "lblPermNo";
            lblPermNo.Size = new Size(100, 23);
            lblPermNo.TabIndex = 2;
            // 
            // lblPermDate
            // 
            lblPermDate.Location = new Point(0, 0);
            lblPermDate.Name = "lblPermDate";
            lblPermDate.Size = new Size(100, 23);
            lblPermDate.TabIndex = 4;
            // 
            // lblItem
            // 
            lblItem.Location = new Point(0, 0);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(100, 23);
            lblItem.TabIndex = 6;
            // 
            // lblCode
            // 
            lblCode.Location = new Point(0, 0);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(100, 23);
            lblCode.TabIndex = 8;
            // 
            // lblQty
            // 
            lblQty.Location = new Point(0, 0);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(100, 23);
            lblQty.TabIndex = 10;
            // 
            // lblSupplier
            // 
            lblSupplier.Location = new Point(0, 0);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(100, 23);
            lblSupplier.TabIndex = 12;
            // 
            // lblProdDate
            // 
            lblProdDate.Location = new Point(0, 0);
            lblProdDate.Name = "lblProdDate";
            lblProdDate.Size = new Size(100, 23);
            lblProdDate.TabIndex = 14;
            // 
            // lblExp
            // 
            lblExp.Location = new Point(0, 0);
            lblExp.Name = "lblExp";
            lblExp.Size = new Size(100, 23);
            lblExp.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(871, 40);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 20;
            label1.Text = "اسم المخزن";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(884, 80);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 21;
            label2.Text = "رقم الاذن";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(877, 120);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 22;
            label3.Text = "تاريخ الاذن";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(875, 160);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 23;
            label4.Text = "اسم المورد";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(857, 210);
            label5.Name = "label5";
            label5.Size = new Size(183, 20);
            label5.TabIndex = 24;
            label5.Text = "صلاحية الانتهاء (عدد الاشهر)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(448, 48);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 25;
            label6.Text = "اسم الصنف";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(451, 93);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 26;
            label7.Text = "رقم الصنف";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(476, 133);
            label8.Name = "label8";
            label8.Size = new Size(48, 20);
            label8.TabIndex = 27;
            label8.Text = "الكمية";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(451, 168);
            label9.Name = "label9";
            label9.Size = new Size(79, 20);
            label9.TabIndex = 28;
            label9.Text = "تاريخ الانتاج";
            // 
            // btnDeleteSupply
            // 
            btnDeleteSupply.Location = new Point(340, 255);
            btnDeleteSupply.Name = "btnDeleteSupply";
            btnDeleteSupply.Size = new Size(94, 32);
            btnDeleteSupply.TabIndex = 29;
            btnDeleteSupply.Text = "حذف";
            btnDeleteSupply.UseVisualStyleBackColor = true;
            btnDeleteSupply.Click += btnDeleteSupply_Click;
            // 
            // btnEditSupply
            // 
            btnEditSupply.Location = new Point(512, 255);
            btnEditSupply.Name = "btnEditSupply";
            btnEditSupply.Size = new Size(93, 32);
            btnEditSupply.TabIndex = 30;
            btnEditSupply.Text = "تعديل";
            btnEditSupply.UseVisualStyleBackColor = true;
            btnEditSupply.Click += btnEditSupply_Click;
            // 
            // txtExpiryMonths
            // 
            txtExpiryMonths.Location = new Point(647, 205);
            txtExpiryMonths.Name = "txtExpiryMonths";
            txtExpiryMonths.Size = new Size(200, 27);
            txtExpiryMonths.TabIndex = 17;
            txtExpiryMonths.TextChanged += txtExpiryMonths_TextChanged;
            // 
            // SupplyPermissionControl
            // 
            BackColor = SystemColors.GradientActiveCaption;
            Controls.Add(btnEditSupply);
            Controls.Add(btnDeleteSupply);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblStore);
            Controls.Add(cmbStore);
            Controls.Add(lblPermNo);
            Controls.Add(txtPermissionNumber);
            Controls.Add(lblPermDate);
            Controls.Add(dtpPermissionDate);
            Controls.Add(lblItem);
            Controls.Add(cmbItem);
            Controls.Add(lblCode);
            Controls.Add(txtItemCode);
            Controls.Add(lblQty);
            Controls.Add(txtQuantity);
            Controls.Add(lblSupplier);
            Controls.Add(cmbSupplier);
            Controls.Add(lblProdDate);
            Controls.Add(dtpProductionDate);
            Controls.Add(lblExp);
            Controls.Add(txtExpiryMonths);
            Controls.Add(btnAddSupply);
            Controls.Add(dgvSupplyItems);
            Name = "SupplyPermissionControl";
            Size = new Size(1320, 693);
            ((System.ComponentModel.ISupportInitialize)dgvSupplyItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Label lblStore;
        private Label lblPermNo;
        private Label lblPermDate;
        private Label lblItem;
        private Label lblCode;
        private Label lblQty;
        private Label lblSupplier;
        private Label lblProdDate;
        private Label lblExp;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnDeleteSupply;
        private Button btnEditSupply;
        private TextBox txtExpiryMonths;
    }
}
