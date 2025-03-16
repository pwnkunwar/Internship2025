namespace DataDashboardApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dtpStartDate = new DateTimePicker();
            btnEndDate = new DateTimePicker();
            btnThisMonth = new Button();
            btnToday = new Button();
            last7Days = new Button();
            this30Days = new Button();
            btnCustom = new Button();
            btnOK = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1 = new Panel();
            label1 = new Label();
            lblNumberOfOrders = new Label();
            panel2 = new Panel();
            lblTotalRevenue = new Label();
            label3 = new Label();
            panel3 = new Panel();
            lblTotalProfit = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dtpStartDate
            // 
            dtpStartDate.CustomFormat = "MMM dd, yyyy";
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.Location = new Point(261, 17);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(200, 23);
            dtpStartDate.TabIndex = 0;
            // 
            // btnEndDate
            // 
            btnEndDate.CustomFormat = "MMM dd, yyyy";
            btnEndDate.Format = DateTimePickerFormat.Custom;
            btnEndDate.Location = new Point(476, 17);
            btnEndDate.Name = "btnEndDate";
            btnEndDate.Size = new Size(200, 23);
            btnEndDate.TabIndex = 1;
            // 
            // btnThisMonth
            // 
            btnThisMonth.Location = new Point(1269, 10);
            btnThisMonth.Name = "btnThisMonth";
            btnThisMonth.Size = new Size(120, 30);
            btnThisMonth.TabIndex = 2;
            btnThisMonth.Text = "This Month";
            btnThisMonth.UseVisualStyleBackColor = true;
            // 
            // btnToday
            // 
            btnToday.Location = new Point(891, 10);
            btnToday.Name = "btnToday";
            btnToday.Size = new Size(120, 30);
            btnToday.TabIndex = 3;
            btnToday.Text = "Today";
            btnToday.UseVisualStyleBackColor = true;
            // 
            // last7Days
            // 
            last7Days.Location = new Point(1017, 10);
            last7Days.Name = "last7Days";
            last7Days.Size = new Size(120, 30);
            last7Days.TabIndex = 4;
            last7Days.Text = "Last 7 Days";
            last7Days.UseVisualStyleBackColor = true;
            // 
            // this30Days
            // 
            this30Days.Location = new Point(1143, 10);
            this30Days.Name = "this30Days";
            this30Days.Size = new Size(120, 30);
            this30Days.TabIndex = 5;
            this30Days.Text = "This 30 Days";
            this30Days.UseVisualStyleBackColor = true;
            // 
            // btnCustom
            // 
            btnCustom.Location = new Point(765, 10);
            btnCustom.Name = "btnCustom";
            btnCustom.Size = new Size(120, 30);
            btnCustom.TabIndex = 6;
            btnCustom.Text = "Custom";
            btnCustom.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(719, 12);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(40, 30);
            btnOK.TabIndex = 7;
            btnOK.Text = "Ok";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblNumberOfOrders);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 55);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 0;
            label1.Text = "Number Of Orders";
            label1.Click += label1_Click;
            // 
            // lblNumberOfOrders
            // 
            lblNumberOfOrders.AutoSize = true;
            lblNumberOfOrders.Font = new Font("Segoe UI", 15F);
            lblNumberOfOrders.Location = new Point(60, 15);
            lblNumberOfOrders.Name = "lblNumberOfOrders";
            lblNumberOfOrders.Size = new Size(67, 28);
            lblNumberOfOrders.TabIndex = 1;
            lblNumberOfOrders.Text = "10000";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblTotalRevenue);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(261, 72);
            panel2.Name = "panel2";
            panel2.Size = new Size(603, 55);
            panel2.TabIndex = 10;
            // 
            // lblTotalRevenue
            // 
            lblTotalRevenue.AutoSize = true;
            lblTotalRevenue.Font = new Font("Segoe UI", 15F);
            lblTotalRevenue.Location = new Point(54, 15);
            lblTotalRevenue.Name = "lblTotalRevenue";
            lblTotalRevenue.Size = new Size(67, 28);
            lblTotalRevenue.TabIndex = 1;
            lblTotalRevenue.Text = "10000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 0;
            label3.Text = "TotalRevenue";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(lblTotalProfit);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(902, 72);
            panel3.Name = "panel3";
            panel3.Size = new Size(487, 55);
            panel3.TabIndex = 11;
            // 
            // lblTotalProfit
            // 
            lblTotalProfit.AutoSize = true;
            lblTotalProfit.Font = new Font("Segoe UI", 15F);
            lblTotalProfit.Location = new Point(60, 15);
            lblTotalProfit.Name = "lblTotalProfit";
            lblTotalProfit.Size = new Size(67, 28);
            lblTotalProfit.TabIndex = 1;
            lblTotalProfit.Text = "10000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 0);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 2;
            label5.Text = "TotalProfit";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1401, 505);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnOK);
            Controls.Add(btnCustom);
            Controls.Add(this30Days);
            Controls.Add(last7Days);
            Controls.Add(btnToday);
            Controls.Add(btnThisMonth);
            Controls.Add(btnEndDate);
            Controls.Add(dtpStartDate);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpStartDate;
        private DateTimePicker btnEndDate;
        private Button btnThisMonth;
        private Button btnToday;
        private Button last7Days;
        private Button this30Days;
        private Button btnCustom;
        private Button btnOK;
        private ContextMenuStrip contextMenuStrip1;
        private Panel panel1;
        private Label lblNumberOfOrders;
        private Label label1;
        private Panel panel2;
        private Label lblTotalRevenue;
        private Label label3;
        private Panel panel3;
        private Label lblTotalProfit;
        private Label label4;
        private Label label5;
    }
}
