namespace DataGridView
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
			dataGridView1 = new System.Windows.Forms.DataGridView();
			btnShowData = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(42, 114);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new Size(690, 296);
			dataGridView1.TabIndex = 0;
			// 
			// btnShowData
			// 
			btnShowData.Location = new Point(328, 42);
			btnShowData.Name = "btnShowData";
			btnShowData.Size = new Size(87, 40);
			btnShowData.TabIndex = 1;
			btnShowData.Text = "Show Data";
			btnShowData.UseVisualStyleBackColor = true;
			btnShowData.Click += btnShowData_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnShowData);
			Controls.Add(dataGridView1);
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private Button btnShowData;
	}
}
