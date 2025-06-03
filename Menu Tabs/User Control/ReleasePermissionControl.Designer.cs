namespace InventorySystem.Tabs.User_Control
{
    partial class ReleasePermissionControl
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ComboBox cmbStore;
        private System.Windows.Forms.TextBox txtPermissionNumber;
        private System.Windows.Forms.DateTimePicker dtpPermissionDate;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Button btnAddRelease;
        private System.Windows.Forms.DataGridView dgvReleaseItems;

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
            cmbSupplier = new ComboBox();
            btnAddRelease = new Button();
            dgvReleaseItems = new DataGridView();
            lblStore = new Label();
            lblPermNo = new Label();
            lblPermDate = new Label();
            lblItem = new Label();
            lblQty = new Label();
            lblSupplier = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnEditRelease = new Button();
            btnDeleteRelease = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReleaseItems).BeginInit();
            SuspendLayout();
            // 
            // cmbStore
            // 
            cmbStore.Location = new Point(332, 138);
            cmbStore.Name = "cmbStore";
            cmbStore.Size = new Size(121, 28);
            cmbStore.TabIndex = 1;
            // 
            // txtPermissionNumber
            // 
            txtPermissionNumber.Location = new Point(332, 172);
            txtPermissionNumber.Name = "txtPermissionNumber";
            txtPermissionNumber.Size = new Size(121, 27);
            txtPermissionNumber.TabIndex = 3;
            // 
            // dtpPermissionDate
            // 
            dtpPermissionDate.Location = new Point(253, 208);
            dtpPermissionDate.Name = "dtpPermissionDate";
            dtpPermissionDate.Size = new Size(200, 27);
            dtpPermissionDate.TabIndex = 5;
            // 
            // cmbItem
            // 
            cmbItem.Location = new Point(694, 138);
            cmbItem.Name = "cmbItem";
            cmbItem.Size = new Size(121, 28);
            cmbItem.TabIndex = 7;
            cmbItem.SelectedIndexChanged += cmbItem_SelectedIndexChanged;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(694, 178);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(121, 27);
            txtQuantity.TabIndex = 9;
            // 
            // cmbSupplier
            // 
            cmbSupplier.Location = new Point(694, 218);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(121, 28);
            cmbSupplier.TabIndex = 11;
            // 
            // btnAddRelease
            // 
            btnAddRelease.BackColor = SystemColors.ButtonHighlight;
            btnAddRelease.Location = new Point(517, 255);
            btnAddRelease.Name = "btnAddRelease";
            btnAddRelease.Size = new Size(101, 32);
            btnAddRelease.TabIndex = 12;
            btnAddRelease.Text = "إضافة إذن صرف";
            btnAddRelease.UseVisualStyleBackColor = false;
            btnAddRelease.Click += btnAddRelease_Click;
            // 
            // dgvReleaseItems
            // 
            dgvReleaseItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReleaseItems.BackgroundColor = SystemColors.ControlLightLight;
            dgvReleaseItems.ColumnHeadersHeight = 29;
            dgvReleaseItems.Location = new Point(234, 293);
            dgvReleaseItems.Name = "dgvReleaseItems";
            dgvReleaseItems.RowHeadersWidth = 51;
            dgvReleaseItems.Size = new Size(720, 250);
            dgvReleaseItems.TabIndex = 13;
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
            // lblQty
            // 
            lblQty.Location = new Point(0, 0);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(100, 23);
            lblQty.TabIndex = 8;
            // 
            // lblSupplier
            // 
            lblSupplier.Location = new Point(0, 0);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(100, 23);
            lblSupplier.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(886, 185);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 14;
            label1.Text = "الكمية";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(466, 172);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 15;
            label2.Text = "رقم الاذن";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(851, 141);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 16;
            label3.Text = "اسم الصنف";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(453, 132);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 17;
            label4.Text = "اسم المخزن";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(856, 224);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 18;
            label5.Text = "اسم المورد";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(459, 215);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 19;
            label6.Text = "تاريخ الاذن";
            // 
            // btnEditRelease
            // 
            btnEditRelease.Location = new Point(651, 255);
            btnEditRelease.Name = "btnEditRelease";
            btnEditRelease.Size = new Size(106, 32);
            btnEditRelease.TabIndex = 20;
            btnEditRelease.Text = "تعديل";
            btnEditRelease.UseVisualStyleBackColor = true;
            btnEditRelease.Click += btnEditRelease_Click;
            // 
            // btnDeleteRelease
            // 
            btnDeleteRelease.Location = new Point(385, 255);
            btnDeleteRelease.Name = "btnDeleteRelease";
            btnDeleteRelease.Size = new Size(107, 32);
            btnDeleteRelease.TabIndex = 21;
            btnDeleteRelease.Text = "حذف";
            btnDeleteRelease.UseVisualStyleBackColor = true;
            btnDeleteRelease.Click += btnDeleteRelease_Click;
            // 
            // ReleasePermissionControl
            // 
            BackColor = SystemColors.GradientActiveCaption;
            Controls.Add(btnDeleteRelease);
            Controls.Add(btnEditRelease);
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
            Controls.Add(lblQty);
            Controls.Add(txtQuantity);
            Controls.Add(lblSupplier);
            Controls.Add(cmbSupplier);
            Controls.Add(btnAddRelease);
            Controls.Add(dgvReleaseItems);
            Name = "ReleasePermissionControl";
            Size = new Size(1320, 594);
            ((System.ComponentModel.ISupportInitialize)dgvReleaseItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Label lblStore;
        private Label lblPermNo;
        private Label lblPermDate;
        private Label lblItem;
        private Label lblQty;
        private Label lblSupplier;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnEditRelease;
        private Button btnDeleteRelease;
    }
}
