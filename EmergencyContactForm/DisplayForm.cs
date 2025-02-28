using System;
using System.Windows.Forms;

namespace EmergencyContactForm
{
    public partial class DisplayForm : Form
    {
        public DisplayForm(string firstName, string lastName, string email, string phoneNumber,
                           string relationship, string address, string secondAddress,
                           string city, string state, string zipCode)
        {
            InitializeComponent();

            // Set form title
            this.Text = "Emergency Contact Details";
            this.Size = new System.Drawing.Size(350, 400);

            // Create a panel to hold labels
            Panel panel = new Panel() { Dock = DockStyle.Fill };
            this.Controls.Add(panel);

            // Function to create and add labels dynamically
            void CreateLabel(string text, int yPosition)
            {
                Label label = new Label()
                {
                    Text = text,
                    AutoSize = true,
                    Location = new System.Drawing.Point(20, yPosition)
                };
                panel.Controls.Add(label);
            }

            // Add labels dynamically
            CreateLabel($"First Name: {firstName}", 20);
            CreateLabel($"Last Name: {lastName}", 50);
            CreateLabel($"Email: {email}", 80);
            CreateLabel($"Phone: {phoneNumber}", 110);
            CreateLabel($"Relationship: {relationship}", 140);
            CreateLabel($"Address: {address}", 170);
            CreateLabel($"Second Address: {secondAddress}", 200);
            CreateLabel($"City: {city}", 230);
            CreateLabel($"State: {state}", 260);
            CreateLabel($"Zip Code: {zipCode}", 290);
        }

      
    }
}
