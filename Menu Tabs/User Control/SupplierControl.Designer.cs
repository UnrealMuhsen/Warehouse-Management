namespace InventorySystem.Tabs.User_Control
{
    partial class SupplierControl
    {
        private System.ComponentModel.IContainer components = null;

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
            txtSupName = new TextBox();
            txtSupPhone = new TextBox();
            txtSupMobile = new TextBox();
            txtSupEmail = new TextBox();
            txtSupFax = new TextBox();
            txtSupWebsite = new TextBox();
            btnAddSupplier = new Button();
            dgvSuppliers = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnEditSupplier = new Button();
            btnDeleteSupplier = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
            SuspendLayout();
            // 
            // txtSupName
            // 
            txtSupName.Location = new Point(629, 122);
            txtSupName.Name = "txtSupName";
            txtSupName.Size = new Size(200, 27);
            txtSupName.TabIndex = 0;
            // 
            // txtSupPhone
            // 
            txtSupPhone.Location = new Point(629, 162);
            txtSupPhone.Name = "txtSupPhone";
            txtSupPhone.Size = new Size(200, 27);
            txtSupPhone.TabIndex = 1;
            // 
            // txtSupMobile
            // 
            txtSupMobile.Location = new Point(629, 202);
            txtSupMobile.Name = "txtSupMobile";
            txtSupMobile.Size = new Size(200, 27);
            txtSupMobile.TabIndex = 2;
            // 
            // txtSupEmail
            // 
            txtSupEmail.Location = new Point(234, 122);
            txtSupEmail.Name = "txtSupEmail";
            txtSupEmail.Size = new Size(200, 27);
            txtSupEmail.TabIndex = 3;
            // 
            // txtSupFax
            // 
            txtSupFax.Location = new Point(234, 162);
            txtSupFax.Name = "txtSupFax";
            txtSupFax.Size = new Size(200, 27);
            txtSupFax.TabIndex = 4;
            // 
            // txtSupWebsite
            // 
            txtSupWebsite.Location = new Point(234, 202);
            txtSupWebsite.Name = "txtSupWebsite";
            txtSupWebsite.Size = new Size(200, 27);
            txtSupWebsite.TabIndex = 5;
            // 
            // btnAddSupplier
            // 
            btnAddSupplier.BackColor = SystemColors.HighlightText;
            btnAddSupplier.Location = new Point(302, 257);
            btnAddSupplier.Name = "btnAddSupplier";
            btnAddSupplier.Size = new Size(200, 30);
            btnAddSupplier.TabIndex = 6;
            btnAddSupplier.Text = "إضافة المورد";
            btnAddSupplier.UseVisualStyleBackColor = false;
            btnAddSupplier.Click += btnAddSupplier_Click;
            // 
            // dgvSuppliers
            // 
            dgvSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSuppliers.BackgroundColor = SystemColors.ControlLightLight;
            dgvSuppliers.ColumnHeadersHeight = 29;
            dgvSuppliers.Location = new Point(234, 293);
            dgvSuppliers.Name = "dgvSuppliers";
            dgvSuppliers.RowHeadersWidth = 51;
            dgvSuppliers.Size = new Size(720, 250);
            dgvSuppliers.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(868, 122);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 8;
            label1.Text = "اسم المورد";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(861, 162);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 9;
            label2.Text = "هاتف المورد";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(833, 202);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 10;
            label3.Text = "رقم موبايل المورد";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(440, 125);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 11;
            label4.Text = "ايميل المورد ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(471, 160);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 12;
            label5.Text = "فاكس";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(440, 200);
            label6.Name = "label6";
            label6.Size = new Size(86, 20);
            label6.TabIndex = 13;
            label6.Text = "موقع المورد";
            // 
            // btnEditSupplier
            // 
            btnEditSupplier.Location = new Point(555, 257);
            btnEditSupplier.Name = "btnEditSupplier";
            btnEditSupplier.Size = new Size(184, 30);
            btnEditSupplier.TabIndex = 14;
            btnEditSupplier.Text = "تعديل";
            btnEditSupplier.UseVisualStyleBackColor = true;
            btnEditSupplier.Click += btnEditSupplier_Click;
            // 
            // btnDeleteSupplier
            // 
            btnDeleteSupplier.Location = new Point(800, 257);
            btnDeleteSupplier.Name = "btnDeleteSupplier";
            btnDeleteSupplier.Size = new Size(75, 30);
            btnDeleteSupplier.TabIndex = 15;
            btnDeleteSupplier.Text = "حذف";
            btnDeleteSupplier.UseVisualStyleBackColor = true;
            btnDeleteSupplier.Click += btnDeleteSupplier_Click;
            // 
            // SupplierControl
            // 
            BackColor = SystemColors.GradientActiveCaption;
            Controls.Add(btnDeleteSupplier);
            Controls.Add(btnEditSupplier);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSupName);
            Controls.Add(txtSupPhone);
            Controls.Add(txtSupMobile);
            Controls.Add(txtSupEmail);
            Controls.Add(txtSupFax);
            Controls.Add(txtSupWebsite);
            Controls.Add(btnAddSupplier);
            Controls.Add(dgvSuppliers);
            Name = "SupplierControl";
            Size = new Size(1320, 594);
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtSupName;
        private System.Windows.Forms.TextBox txtSupPhone;
        private System.Windows.Forms.TextBox txtSupMobile;
        private System.Windows.Forms.TextBox txtSupEmail;
        private System.Windows.Forms.TextBox txtSupFax;
        private System.Windows.Forms.TextBox txtSupWebsite;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.DataGridView dgvSuppliers;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnEditSupplier;
        private Button btnDeleteSupplier;
    }
}
