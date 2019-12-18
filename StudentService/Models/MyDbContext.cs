using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentService.Models
{
    public partial class MyDbContext : DbContext
    {
        public MyDbContext()
            : base("name=MyDbContext")
        {
        }

        public DbSet<Student> Students { set; get; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}