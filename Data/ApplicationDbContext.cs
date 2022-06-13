using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ReversiMVC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReversiMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Speler> Spelers { get; set; }
        public DbSet<Spel> Spellen { get; set; }

        public DbSet<Board> Boards { get; set; }


    }
}
