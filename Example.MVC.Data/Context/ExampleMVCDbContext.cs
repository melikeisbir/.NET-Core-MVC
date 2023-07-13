using Example.MVC.Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.MVC.Data.Context
{
    public class ExampleMVCDbContext: IdentityDbContext<AppUser,AppRole,int>
    {
        public ExampleMVCDbContext(DbContextOptions option):base(option)
        {

        }
        public DbSet<Bolumler> Bolumlers { get; set; }
        public DbSet<Dersler> Derslers { get; set; }
        public DbSet<Notlar> Notlars { get; set; }
        public DbSet<Ogrenciler> Ogrencilers { get; set; }
        public DbSet<Fakulteler> Fakultelers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
