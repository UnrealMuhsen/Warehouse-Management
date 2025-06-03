namespace InventorySystem.Tabs.User_Control
{
    partial class CustomerControl
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblFax;
        private System.Windows.Forms.Label lblWebsite;

        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.TextBox txtCustPhone;
        private System.Windows.Forms.TextBox txtCustMobile;
        private System.Windows.Forms.TextBox txtCustEmail;
        private System.Windows.Forms.TextBox txtCustFax;
        private System.Windows.Forms.TextBox txtCustWebsite;

        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.DataGridView dgvCustomers;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtCustName = new TextBox();
            txtCustPhone = new TextBox();
            txtCustMobile = new TextBox();
            txtCustEmail = new TextBox();
            txtCustFax = new TextBox();
            txtCustWebsite = new TextBox();
            btnAddCustomer = new Button();
            dgvCustomers = new DataGridView();
            lblName = new Label();
            lblPhone = new Label();
            lblMobile = new Label();
            lblEmail = new Label();
            lblFax = new Label();
            lblWebsite = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnEditCustomer = new Button();
            btnDeleteCustomer = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // txtCustName
            // 
            txtCustName.Location = new Point(612, 119);
            txtCustName.Name = "txtCustName";
            txtCustName.Size = new Size(200, 27);
            txtCustName.TabIndex = 1;
            // 
            // txtCustPhone
            // 
            txtCustPhone.Location = new Point(612, 159);
            txtCustPhone.Name = "txtCustPhone";
            txtCustPhone.Size = new Size(200, 27);
            txtCustPhone.TabIndex = 3;
            // 
            // txtCustMobile
            // 
            txtCustMobile.Location = new Point(612, 199);
            txtCustMobile.Name = "txtCustMobile";
            txtCustMobile.Size = new Size(200, 27);
            txtCustMobile.TabIndex = 5;
            // 
            // txtCustEmail
            // 
            txtCustEmail.Location = new Point(234, 114);
            txtCustEmail.Name = "txtCustEmail";
            txtCustEmail.Size = new Size(200, 27);
            txtCustEmail.TabIndex = 7;
            // 
            // txtCustFax
            // 
            txtCustFax.Location = new Point(234, 154);
            txtCustFax.Name = "txtCustFax";
            txtCustFax.Size = new Size(200, 27);
            txtCustFax.TabIndex = 9;
            // 
            // txtCustWebsite
            // 
            txtCustWebsite.Location = new Point(234, 194);
            txtCustWebsite.Name = "txtCustWebsite";
            txtCustWebsite.Size = new Size(200, 27);
            txtCustWebsite.TabIndex = 11;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.BackColor = SystemColors.HighlightText;
            btnAddCustomer.Location = new Point(490, 252);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(110, 35);
            btnAddCustomer.TabIndex = 12;
            btnAddCustomer.Text = "إضافة العميل";
            btnAddCustomer.UseVisualStyleBackColor = false;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // dgvCustomers
            // 
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.BackgroundColor = SystemColors.Window;
            dgvCustomers.ColumnHeadersHeight = 29;
            dgvCustomers.Location = new Point(234, 293);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.Size = new Size(720, 250);
            dgvCustomers.TabIndex = 13;
            // 
            // lblName
            // 
            lblName.Location = new Point(0, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(100, 23);
            lblName.TabIndex = 0;
            // 
            // lblPhone
            // 
            lblPhone.Location = new Point(0, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(100, 23);
            lblPhone.TabIndex = 2;
            // 
            // lblMobile
            // 
            lblMobile.Location = new Point(0, 0);
            lblMobile.Name = "lblMobile";
            lblMobile.Size = new Size(100, 23);
            lblMobile.TabIndex = 4;
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(0, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(100, 23);
            lblEmail.TabIndex = 6;
            // 
            // lblFax
            // 
            lblFax.Location = new Point(0, 0);
            lblFax.Name = "lblFax";
            lblFax.Size = new Size(100, 23);
            lblFax.TabIndex = 8;
            // 
            // lblWebsite
            // 
            lblWebsite.Location = new Point(0, 0);
            lblWebsite.Name = "lblWebsite";
            lblWebsite.Size = new Size(100, 23);
            lblWebsite.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(874, 119);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 14;
            label1.Text = "إسم العميل";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(874, 159);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 15;
            label2.Text = "هاتف العميل";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(842, 199);
            label3.Name = "label3";
            label3.Size = new Size(122, 20);
            label3.TabIndex = 16;
            label3.Text = "رقم موبايل العميل";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(490, 119);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 17;
            label4.Text = "ايميل العميل";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(523, 159);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 18;
            label5.Text = "فاكس";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(490, 194);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 19;
            label6.Text = "موقع العميل";
            // 
            // btnEditCustomer
            // 
            btnEditCustomer.Location = new Point(400, 252);
            btnEditCustomer.Name = "btnEditCustomer";
            btnEditCustomer.Size = new Size(59, 35);
            btnEditCustomer.TabIndex = 20;
            btnEditCustomer.Text = "تعديل";
            btnEditCustomer.UseVisualStyleBackColor = true;
            btnEditCustomer.Click += btnEditCustomer_Click;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.BackColor = SystemColors.ControlLightLight;
            btnDeleteCustomer.Location = new Point(641, 252);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(75, 35);
            btnDeleteCustomer.TabIndex = 21;
            btnDeleteCustomer.Text = "حذف";
            btnDeleteCustomer.UseVisualStyleBackColor = false;
            btnDeleteCustomer.Click += btnDeleteCustomer_Click;
            // 
            // CustomerControl
            // 
            BackColor = SystemColors.GradientActiveCaption;
            Controls.Add(btnDeleteCustomer);
            Controls.Add(btnEditCustomer);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblName);
            Controls.Add(txtCustName);
            Controls.Add(lblPhone);
            Controls.Add(txtCustPhone);
            Controls.Add(lblMobile);
            Controls.Add(txtCustMobile);
            Controls.Add(lblEmail);
            Controls.Add(txtCustEmail);
            Controls.Add(lblFax);
            Controls.Add(txtCustFax);
            Controls.Add(lblWebsite);
            Controls.Add(txtCustWebsite);
            Controls.Add(btnAddCustomer);
            Controls.Add(dgvCustomers);
            Name = "CustomerControl";
            Size = new Size(1320, 594);
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnEditCustomer;
        private Button btnDeleteCustomer;
    }
}
