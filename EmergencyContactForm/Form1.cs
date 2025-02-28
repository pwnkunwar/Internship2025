using EmergencyContactForm.Database;
using EmergencyContactForm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactUsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string relationShip = radioButton1.Checked ? radioButton1.Text :
                radioButton2.Checked ? radioButton2.Text :
                radioButton3.Checked ? radioButton3.Text :
                radioButton4.Checked ? radioButton4.Text :
                radioButton5.Checked ? radioButton5.Text : "Not Specicifed";
            using (var db = new ApplicationDbContext())
            {
                var emergencyContact = new EmergencyContact
                {
                    Id = Guid.NewGuid(),
                    FirstName = textBox1.Text,
                    LastName = textBox2.Text,
                    Email = textBox3.Text,
                    PhoneNumber = textBox4.Text,
                    Relationship = relationShip,
                    Address = textBox5.Text,
                    SecondAddress = textBox6.Text,
                    City = textBox7.Text,
                    State = textBox8.Text,
                    ZipCode = textBox9.Text
                };

                db.EmergencyContacts.Add(emergencyContact);
                db.SaveChanges();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
