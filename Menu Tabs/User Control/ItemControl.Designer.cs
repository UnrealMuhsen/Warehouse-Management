namespace InventorySystem.Tabs.User_Control
{
    partial class ItemControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.DataGridView dgvItems;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblCode = new Label();
            txtCode = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            lblUnit = new Label();
            txtUnit = new TextBox();
            btnAddItem = new Button();
            dgvItems = new DataGridView();
            btnEditItem = new Button();
            btnDeleteItem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Location = new Point(1145, 175);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(80, 20);
            lblCode.TabIndex = 0;
            lblCode.Text = ":كودالصنف";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(911, 175);
            txtCode.Margin = new Padding(3, 4, 3, 4);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(228, 27);
            txtCode.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(796, 175);
            lblName.Name = "lblName";
            lblName.Size = new Size(86, 20);
            lblName.TabIndex = 2;
            lblName.Text = ":اسم الصنف";
            // 
            // txtName
            // 
            txtName.Location = new Point(562, 175);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(228, 27);
            txtName.TabIndex = 3;
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Location = new Point(449, 182);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(93, 20);
            lblUnit.TabIndex = 4;
            lblUnit.Text = ":وحدة القياس";
            // 
            // txtUnit
            // 
            txtUnit.Location = new Point(215, 182);
            txtUnit.Margin = new Padding(3, 4, 3, 4);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(228, 27);
            txtUnit.TabIndex = 5;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(576, 246);
            btnAddItem.Margin = new Padding(3, 4, 3, 4);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(118, 39);
            btnAddItem.TabIndex = 6;
            btnAddItem.Text = "إضافة الصنف";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AllowUserToDeleteRows = false;
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItems.BackgroundColor = SystemColors.ControlLightLight;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Location = new Point(234, 293);
            dgvItems.Margin = new Padding(3, 4, 3, 4);
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowHeadersWidth = 51;
            dgvItems.Size = new Size(720, 250);
            dgvItems.TabIndex = 7;
            // 
            // btnEditItem
            // 
            btnEditItem.Location = new Point(466, 246);
            btnEditItem.Margin = new Padding(3, 4, 3, 4);
            btnEditItem.Name = "btnEditItem";
            btnEditItem.Size = new Size(76, 39);
            btnEditItem.TabIndex = 8;
            btnEditItem.Text = "تعديل";
            btnEditItem.UseVisualStyleBackColor = true;
            btnEditItem.Click += btnEditItem_Click;
            // 
            // btnDeleteItem
            // 
            btnDeleteItem.Location = new Point(737, 247);
            btnDeleteItem.Margin = new Padding(3, 4, 3, 4);
            btnDeleteItem.Name = "btnDeleteItem";
            btnDeleteItem.Size = new Size(66, 38);
            btnDeleteItem.TabIndex = 9;
            btnDeleteItem.Text = "حذف";
            btnDeleteItem.UseVisualStyleBackColor = true;
            btnDeleteItem.Click += btnDeleteItem_Click;
            // 
            // ItemControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            Controls.Add(btnDeleteItem);
            Controls.Add(btnEditItem);
            Controls.Add(lblCode);
            Controls.Add(txtCode);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblUnit);
            Controls.Add(txtUnit);
            Controls.Add(btnAddItem);
            Controls.Add(dgvItems);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ItemControl";
            Size = new Size(1320, 594);
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Button btnEditItem;
        private Button btnDeleteItem;
    }
}
