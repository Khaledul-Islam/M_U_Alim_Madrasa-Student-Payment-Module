using System;
using System.Collections.Generic;
using System.Text;
using M_U_Alim_Madrasa.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace M_U_Alim_Madrasa.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Students> Student { get; set; }
        public DbSet<Payment> payment { get; set; }
        public DbSet<Login> login { get; set; }
    }
}
