using EduHome1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Context = Microsoft.EntityFrameworkCore.DbContext;

namespace EduHome1.DataAccessLayer
{
    public class AppDbContext : Context
    {
        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options)
        {
        }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Professional> Professionals { get; set; }
        public DbSet<TeacherContact> TeacherContacts { get; set; }
        public DbSet<TeacherDetails> TeacherDetail { get; set; }
        public DbSet<TeacherProfessional> TeacherProfessionals { get; set; }
        public DbSet<TeacherSkills> TeacherSkill { get; set; }
    }
}
