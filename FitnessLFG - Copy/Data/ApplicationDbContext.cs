using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FitnessLFG.Models;

namespace FitnessLFG.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Crud> Cruds { get; set; }
        public DbSet<ContactTrace> Traces { get; set; }
        public DbSet<FitnessLFG.Models.ContactUs> ContactUs { get; set; }
    }
}