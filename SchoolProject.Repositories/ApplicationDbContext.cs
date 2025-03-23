using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
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
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options)
        {
            
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Session> YearlySessions { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Enroll> Enroll     { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AssignGrade>().HasOne(x=>x.Grade).
                WithMany(z=>z.AssignGrade).HasForeignKey(x=>x.GradeId).OnDelete(DeleteBehavior.SetNull);

            builder.Entity<AssignGrade>().HasOne(x=>x.Teacher).
                WithMany(z=>z.AssignGrades).HasForeignKey(x=>x.TeacherId).OnDelete(DeleteBehavior.SetNull);

            builder.Entity<Enroll>().HasOne(x=>x.Student).
                WithMany(z => z.YearlySession).HasForeignKey(x => x.StudentId).OnDelete(DeleteBehavior.SetNull);

            builder.Entity<Enroll>().HasOne(x=>x.Session).
                WithMany(z=>z.Enrollment).HasForeignKey(x=>x.GradeId).OnDelete(DeleteBehavior.SetNull);

            builder.Entity<Enroll>().HasOne(x=>x.Grade).
                WithMany(z=>z.Enrolls).HasForeignKey(x=>x.GradeId).OnDelete(DeleteBehavior.SetNull);

            builder.Entity<TeacherSession>().HasOne(x=>x.Teacher).
                WithMany(z=>z.TeacherSessions).HasForeignKey(x=>x.TeacherId).OnDelete(DeleteBehavior.SetNull);

            builder.Entity<TeacherSession>().HasOne(x=>x.Session).
                WithMany(z=>z.TeacherSessions).HasForeignKey(x=>x.SessionId).OnDelete(DeleteBehavior.SetNull);

            base.OnModelCreating(builder);

        }
    }
}
