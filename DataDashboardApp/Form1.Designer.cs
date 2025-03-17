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
            btnlast7Days = new Button();
            this30Days = new Button();
            btnCustom = new Button();
            btnOK = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1 = new Panel();
            lblNumberOfOrders = new Label();
            label1 = new Label();
            panel2 = new Panel();
            lblTotalRevenue = new Label();
            label3 = new Label();
            panel3 = new Panel();
            label5 = new Label();
            lblTotalProfit = new Label();
            label4 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            sqlCommand2 = new Microsoft.Data.SqlClient.SqlCommand();
            sqlCommand3 = new Microsoft.Data.SqlClient.SqlCommand();
            panel4 = new Panel();
            lblNumSuppliers = new Label();
            lblNumProducts = new Label();
            lblNumCustomers = new Label();
            label10 = new Label();
            label9 = new Label();
            label2 = new Label();
            label6 = new Label();
            panel5 = new Panel();
            productUnderStock = new DataGridView();
            label8 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productUnderStock).BeginInit();
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
            btnThisMonth.Click += btnThisMonth_Click;
            // 
            // btnToday
            // 
            btnToday.Location = new Point(891, 10);
            btnToday.Name = "btnToday";
            btnToday.Size = new Size(120, 30);
            btnToday.TabIndex = 3;
            btnToday.Text = "Today";
            btnToday.UseVisualStyleBackColor = true;
            btnToday.Click += btnToday_Click;
            // 
            // btnlast7Days
            // 
            btnlast7Days.Location = new Point(1017, 10);
            btnlast7Days.Name = "btnlast7Days";
            btnlast7Days.Size = new Size(120, 30);
            btnlast7Days.TabIndex = 4;
            btnlast7Days.Text = "Last 7 Days";
            btnlast7Days.UseVisualStyleBackColor = true;
            btnlast7Days.Click += btnlast7Days_Click;
            // 
            // this30Days
            // 
            this30Days.Location = new Point(1143, 10);
            this30Days.Name = "this30Days";
            this30Days.Size = new Size(120, 30);
            this30Days.TabIndex = 5;
            this30Days.Text = "This 30 Days";
            this30Days.UseVisualStyleBackColor = true;
            this30Days.Click += this30Days_Click;
            // 
            // btnCustom
            // 
            btnCustom.Location = new Point(765, 10);
            btnCustom.Name = "btnCustom";
            btnCustom.Size = new Size(120, 30);
            btnCustom.TabIndex = 6;
            btnCustom.Text = "Custom";
            btnCustom.UseVisualStyleBackColor = true;
            btnCustom.Click += btnCustom_Click;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(719, 12);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(40, 30);
            btnOK.TabIndex = 7;
            btnOK.Text = "Ok";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 0);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 2;
            label5.Text = "TotalProfit";
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
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // sqlCommand2
            // 
            sqlCommand2.CommandTimeout = 30;
            sqlCommand2.EnableOptimizedParameterBinding = false;
            // 
            // sqlCommand3
            // 
            sqlCommand3.CommandTimeout = 30;
            sqlCommand3.EnableOptimizedParameterBinding = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(lblNumSuppliers);
            panel4.Controls.Add(lblNumProducts);
            panel4.Controls.Add(lblNumCustomers);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(12, 313);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 180);
            panel4.TabIndex = 12;
            // 
            // lblNumSuppliers
            // 
            lblNumSuppliers.AutoSize = true;
            lblNumSuppliers.Font = new Font("Segoe UI", 15F);
            lblNumSuppliers.Location = new Point(60, 98);
            lblNumSuppliers.Name = "lblNumSuppliers";
            lblNumSuppliers.Size = new Size(67, 28);
            lblNumSuppliers.TabIndex = 6;
            lblNumSuppliers.Text = "10000";
            // 
            // lblNumProducts
            // 
            lblNumProducts.AutoSize = true;
            lblNumProducts.Font = new Font("Segoe UI", 15F);
            lblNumProducts.Location = new Point(60, 145);
            lblNumProducts.Name = "lblNumProducts";
            lblNumProducts.Size = new Size(67, 28);
            lblNumProducts.TabIndex = 5;
            lblNumProducts.Text = "10000";
            // 
            // lblNumCustomers
            // 
            lblNumCustomers.AutoSize = true;
            lblNumCustomers.Font = new Font("Segoe UI", 15F);
            lblNumCustomers.Location = new Point(60, 52);
            lblNumCustomers.Name = "lblNumCustomers";
            lblNumCustomers.Size = new Size(67, 28);
            lblNumCustomers.TabIndex = 4;
            lblNumCustomers.Text = "10000";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(44, 37);
            label10.Name = "label10";
            label10.Size = new Size(127, 15);
            label10.TabIndex = 3;
            label10.Text = "Number Of Customers";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(44, 130);
            label9.Name = "label9";
            label9.Size = new Size(117, 15);
            label9.TabIndex = 2;
            label9.Text = "Number Of Products";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 83);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 1;
            label2.Text = "Number Of Suppliers";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(32, 0);
            label6.Name = "label6";
            label6.Size = new Size(137, 28);
            label6.TabIndex = 0;
            label6.Text = "Total Counters";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(productUnderStock);
            panel5.Controls.Add(label8);
            panel5.Location = new Point(261, 313);
            panel5.Name = "panel5";
            panel5.Size = new Size(624, 180);
            panel5.TabIndex = 13;
            // 
            // productUnderStock
            // 
            productUnderStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productUnderStock.Location = new Point(6, 31);
            productUnderStock.Name = "productUnderStock";
            productUnderStock.Size = new Size(605, 142);
            productUnderStock.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(6, 0);
            label8.Name = "label8";
            label8.Size = new Size(194, 28);
            label8.TabIndex = 0;
            label8.Text = "Products Understock";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20F);
            label7.Location = new Point(31, 14);
            label7.Name = "label7";
            label7.Size = new Size(147, 37);
            label7.TabIndex = 14;
            label7.Text = "Dashboard";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1401, 505);
            Controls.Add(label7);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnOK);
            Controls.Add(btnCustom);
            Controls.Add(this30Days);
            Controls.Add(btnlast7Days);
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
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)productUnderStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpStartDate;
        private DateTimePicker btnEndDate;
        private Button btnThisMonth;
        private Button btnToday;
        private Button btnlast7Days;
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
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand2;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand3;
        private Panel panel4;
        private Label lblNumProducts;
        private Label lblNumCustomers;
        private Label label10;
        private Label label9;
        private Label label2;
        private Label label6;
        private Panel panel5;
        private Label label8;
        private Label lblNumSuppliers;
        private DataGridView productUnderStock;
        private Label label7;
    }
}
