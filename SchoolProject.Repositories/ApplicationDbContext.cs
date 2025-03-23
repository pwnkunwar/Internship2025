using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using SchoolProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Repositories
{
    public class ApplicationDBContext : IdentityDbContext<ApplicationUser>
    {
    }
}
