namespace InventorySystem.Tabs.User_Control
{
    partial class StoreControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblStoreName;
        private System.Windows.Forms.TextBox txtStoreName;
        private System.Windows.Forms.Label lblStoreAddress;
        private System.Windows.Forms.TextBox txtStoreAddress;
        private System.Windows.Forms.Label lblStoreManager;
        private System.Windows.Forms.TextBox txtStoreManager;
        private System.Windows.Forms.Button btnAddStore;
        private System.Windows.Forms.DataGridView dgvStores;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblStoreName = new Label();
            txtStoreName = new TextBox();
            lblStoreAddress = new Label();
            txtStoreAddress = new TextBox();
            lblStoreManager = new Label();
            txtStoreManager = new TextBox();
            btnAddStore = new Button();
            dgvStores = new DataGridView();
            btnEditStore = new Button();
            btnDeleteStore = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStores).BeginInit();
            SuspendLayout();
            // 
            // lblStoreName
            // 
            lblStoreName.AutoSize = true;
            lblStoreName.Location = new Point(869, 111);
            lblStoreName.Name = "lblStoreName";
            lblStoreName.Size = new Size(97, 20);
            lblStoreName.TabIndex = 0;
            lblStoreName.Text = ":اسم المخزن   ";
            // 
            // txtStoreName
            // 
            txtStoreName.Location = new Point(561, 104);
            txtStoreName.Name = "txtStoreName";
            txtStoreName.Size = new Size(250, 27);
            txtStoreName.TabIndex = 1;
            // 
            // lblStoreAddress
            // 
            lblStoreAddress.AutoSize = true;
            lblStoreAddress.Location = new Point(897, 151);
            lblStoreAddress.Name = "lblStoreAddress";
            lblStoreAddress.Size = new Size(57, 20);
            lblStoreAddress.TabIndex = 2;
            lblStoreAddress.Text = ":العنوان";
            // 
            // txtStoreAddress
            // 
            txtStoreAddress.Location = new Point(561, 144);
            txtStoreAddress.Name = "txtStoreAddress";
            txtStoreAddress.Size = new Size(250, 27);
            txtStoreAddress.TabIndex = 3;
            // 
            // lblStoreManager
            // 
            lblStoreManager.AutoSize = true;
            lblStoreManager.Location = new Point(855, 191);
            lblStoreManager.Name = "lblStoreManager";
            lblStoreManager.Size = new Size(99, 20);
            lblStoreManager.TabIndex = 4;
            lblStoreManager.Text = ":اسم المسؤول";
            // 
            // txtStoreManager
            // 
            txtStoreManager.Location = new Point(561, 184);
            txtStoreManager.Name = "txtStoreManager";
            txtStoreManager.Size = new Size(250, 27);
            txtStoreManager.TabIndex = 5;
            // 
            // btnAddStore
            // 
            btnAddStore.Location = new Point(310, 235);
            btnAddStore.Name = "btnAddStore";
            btnAddStore.Size = new Size(250, 35);
            btnAddStore.TabIndex = 6;
            btnAddStore.Text = "إضافة المخزن";
            btnAddStore.UseVisualStyleBackColor = true;
            btnAddStore.Click += btnAddStore_Click;
            // 
            // dgvStores
            // 
            dgvStores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStores.BackgroundColor = SystemColors.ControlLightLight;
            dgvStores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStores.Location = new Point(234, 293);
            dgvStores.Name = "dgvStores";
            dgvStores.RowHeadersWidth = 51;
            dgvStores.Size = new Size(720, 250);
            dgvStores.TabIndex = 7;
            // 
            // btnEditStore
            // 
            btnEditStore.Location = new Point(587, 235);
            btnEditStore.Margin = new Padding(3, 4, 3, 4);
            btnEditStore.Name = "btnEditStore";
            btnEditStore.Size = new Size(199, 35);
            btnEditStore.TabIndex = 8;
            btnEditStore.Text = "تعديل";
            btnEditStore.UseVisualStyleBackColor = true;
            btnEditStore.Click += btnEditStore_Click;
            // 
            // btnDeleteStore
            // 
            btnDeleteStore.Location = new Point(814, 235);
            btnDeleteStore.Margin = new Padding(3, 4, 3, 4);
            btnDeleteStore.Name = "btnDeleteStore";
            btnDeleteStore.Size = new Size(86, 35);
            btnDeleteStore.TabIndex = 9;
            btnDeleteStore.Text = "حذف";
            btnDeleteStore.UseVisualStyleBackColor = true;
            btnDeleteStore.Click += btnDeleteStore_Click;
            // 
            // StoreControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            Controls.Add(btnDeleteStore);
            Controls.Add(btnEditStore);
            Controls.Add(lblStoreName);
            Controls.Add(txtStoreName);
            Controls.Add(lblStoreAddress);
            Controls.Add(txtStoreAddress);
            Controls.Add(lblStoreManager);
            Controls.Add(txtStoreManager);
            Controls.Add(btnAddStore);
            Controls.Add(dgvStores);
            Location = new Point(234, 293);
            Name = "StoreControl";
            Size = new Size(1320, 594);
            ((System.ComponentModel.ISupportInitialize)dgvStores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Button btnEditStore;
        private Button btnDeleteStore;
    }
}
