using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmergencyContactForm.Models;
using Microsoft.EntityFrameworkCore;

namespace EmergencyContactForm.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<EmergencyContact> EmergencyContacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-3SS2B66;Initial Catalog=EmergencyContactForms;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }

    }
}
