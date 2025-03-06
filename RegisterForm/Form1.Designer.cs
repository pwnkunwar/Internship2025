namespace RegisterForm
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up resources
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Form Properties
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 400);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Register Form";
            this.ResumeLayout(false);
            this.PerformLayout();

            // Label1 - Title
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(100, 20);
            this.label1.Text = "Register";

            // Label2 - Username
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F);
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Text = "Username:";

            // Label3 - Password
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F);
            this.label3.Location = new System.Drawing.Point(30, 140);
            this.label3.Text = "Password:";

            // TextBox - Username
            this.txtUsername.Location = new System.Drawing.Point(30, 100);
            this.txtUsername.Size = new System.Drawing.Size(250, 22);

            // TextBox - Password
            this.txtPassword.Location = new System.Drawing.Point(30, 170);
            this.txtPassword.Size = new System.Drawing.Size(250, 22);
            this.txtPassword.PasswordChar = '*';

            // TextBox - Confirm Password
            this.txtConfirmPassword.Location = new System.Drawing.Point(30, 240);
            this.txtConfirmPassword.Size = new System.Drawing.Size(250, 22);
            this.txtConfirmPassword.PasswordChar = '*';

            // Button - Register
            this.btnRegister.Location = new System.Drawing.Point(30, 300);
            this.btnRegister.Size = new System.Drawing.Size(250, 30);
            this.btnRegister.Text = "Register";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnRegister;
    }
}
