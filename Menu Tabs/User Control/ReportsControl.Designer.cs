namespace InventorySystem.Tabs.User_Control
{
    partial class ReportsControl
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnStoreReport;
        private System.Windows.Forms.Button btnItemReport;
        private System.Windows.Forms.Button btnMovementReport;
        private System.Windows.Forms.Button btnAgedItemsReport;
        private System.Windows.Forms.Button btnExpiryReport;
        private System.Windows.Forms.RichTextBox txtReportOutput;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            btnStoreReport = new Button();
            btnItemReport = new Button();
            btnMovementReport = new Button();
            btnAgedItemsReport = new Button();
            btnExpiryReport = new Button();
            txtReportOutput = new RichTextBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(479, 17);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(200, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "التقارير";
            // 
            // btnStoreReport
            // 
            btnStoreReport.BackColor = SystemColors.InactiveCaption;
            btnStoreReport.Location = new Point(275, 197);
            btnStoreReport.Name = "btnStoreReport";
            btnStoreReport.Size = new Size(120, 70);
            btnStoreReport.TabIndex = 1;
            btnStoreReport.Text = "تقرير المخازن";
            btnStoreReport.UseVisualStyleBackColor = false;
            btnStoreReport.Click += btnStoreReport_Click;
            // 
            // btnItemReport
            // 
            btnItemReport.BackColor = SystemColors.InactiveCaption;
            btnItemReport.Location = new Point(405, 197);
            btnItemReport.Name = "btnItemReport";
            btnItemReport.Size = new Size(120, 70);
            btnItemReport.TabIndex = 2;
            btnItemReport.Text = "تقرير الأصناف";
            btnItemReport.UseVisualStyleBackColor = false;
            btnItemReport.Click += btnItemReport_Click;
            // 
            // btnMovementReport
            // 
            btnMovementReport.BackColor = SystemColors.InactiveCaption;
            btnMovementReport.Location = new Point(535, 197);
            btnMovementReport.Name = "btnMovementReport";
            btnMovementReport.Size = new Size(120, 70);
            btnMovementReport.TabIndex = 3;
            btnMovementReport.Text = "تقرير حركة الصنف";
            btnMovementReport.UseVisualStyleBackColor = false;
            btnMovementReport.Click += btnMovementReport_Click;
            // 
            // btnAgedItemsReport
            // 
            btnAgedItemsReport.BackColor = SystemColors.InactiveCaption;
            btnAgedItemsReport.Location = new Point(665, 197);
            btnAgedItemsReport.Name = "btnAgedItemsReport";
            btnAgedItemsReport.Size = new Size(120, 70);
            btnAgedItemsReport.TabIndex = 4;
            btnAgedItemsReport.Text = "الأصناف المخزنة طويلاً";
            btnAgedItemsReport.UseVisualStyleBackColor = false;
            btnAgedItemsReport.Click += btnAgedItemsReport_Click;
            // 
            // btnExpiryReport
            // 
            btnExpiryReport.BackColor = SystemColors.InactiveCaption;
            btnExpiryReport.Location = new Point(799, 197);
            btnExpiryReport.Name = "btnExpiryReport";
            btnExpiryReport.Size = new Size(120, 70);
            btnExpiryReport.TabIndex = 5;
            btnExpiryReport.Text = "الأصناف القريبة للانتهاء";
            btnExpiryReport.UseVisualStyleBackColor = false;
            btnExpiryReport.Click += btnExpiryReport_Click;
            // 
            // txtReportOutput
            // 
            txtReportOutput.BackColor = SystemColors.ControlLightLight;
            txtReportOutput.Location = new Point(234, 293);
            txtReportOutput.Name = "txtReportOutput";
            txtReportOutput.ReadOnly = true;
            txtReportOutput.Size = new Size(720, 250);
            txtReportOutput.TabIndex = 6;
            txtReportOutput.Text = "";
            // 
            // ReportsControl
            // 
            BackColor = SystemColors.GradientActiveCaption;
            Controls.Add(lblTitle);
            Controls.Add(btnStoreReport);
            Controls.Add(btnItemReport);
            Controls.Add(btnMovementReport);
            Controls.Add(btnAgedItemsReport);
            Controls.Add(btnExpiryReport);
            Controls.Add(txtReportOutput);
            Name = "ReportsControl";
            Size = new Size(1320, 594);
            ResumeLayout(false);
        }
    }
}
