using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SchoolProject.Models;
using SchoolProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Utilities
{
    public class DbInitializer : IDbInitializer
    {
        private UserManager<ApplicationUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;
        private ApplicationDBContext _db;
        public DbInitializer(UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            ApplicationDBContext db)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _db = db;
        }
        public void Initialize()
        {
            try
            {
                if (_db.Database.GetPendingMigrations().Count() > 0)
                {
                    _db.Database.Migrate();
                }
            }catch(Exception)
            {
                throw;
            }
            if(!_roleManager.RoleExistsAsync(WebsiteRole.Website_Admin).GetAwaiter().GetResult())
            {
                _roleManager.CreateAsync(new IdentityRole(WebsiteRole.Website_Admin)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(WebsiteRole.Website_Employee)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(WebsiteRole.Website_Teacher)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(WebsiteRole.Website_Student)).GetAwaiter().GetResult();
            }
            _userManager.CreateAsync(new ApplicationUser
            {
                UserName = "pwnkunwar@gmail.com",
                Email = "pwnkunwar@gmail.com"
            }, "pwnkunwar").GetAwaiter().GetResult();
            var appuser = _userManager.Users.Where(x=>x.Email == "pwnkuwnar@gmail.com").FirstOrDefault();

            if(appuser != null)
            {
                _userManager.AddToRoleAsync(appuser, WebsiteRole.Website_Admin).GetAwaiter().GetResult();
            }

        }
    }
}
