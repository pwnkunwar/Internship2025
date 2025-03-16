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
            dtpStartDate = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            btnThisMonth = new Button();
            btnToday = new Button();
            last7Days = new Button();
            this30Days = new Button();
            btnCustom = new Button();
            btnOK = new Button();
            SuspendLayout();
            // 
            // dtpStartDate
            // 
            dtpStartDate.CustomFormat = "MMM dd, yyyy";
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.Location = new Point(158, 12);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(200, 23);
            dtpStartDate.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "MMM dd, yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(387, 12);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 1;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1401, 505);
            Controls.Add(btnOK);
            Controls.Add(btnCustom);
            Controls.Add(this30Days);
            Controls.Add(last7Days);
            Controls.Add(btnToday);
            Controls.Add(btnThisMonth);
            Controls.Add(dateTimePicker2);
            Controls.Add(dtpStartDate);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpStartDate;
        private DateTimePicker dateTimePicker2;
        private Button btnThisMonth;
        private Button btnToday;
        private Button last7Days;
        private Button this30Days;
        private Button btnCustom;
        private Button btnOK;
    }
}
