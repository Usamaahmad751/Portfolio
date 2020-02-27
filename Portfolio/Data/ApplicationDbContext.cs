using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Portfolio.Models;

namespace Portfolio.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Portfolio.Models.Project> Project { get; set; }
        public DbSet<Portfolio.Models.Blog> Blog { get; set; }
        public DbSet<Portfolio.Models.OpenSourceProjects> OpenSourceProjects { get; set; }
    }
}
