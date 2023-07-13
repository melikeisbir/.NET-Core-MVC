using Example.MVC.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.MVC.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ExampleMVCDbContext>
    {
        public ExampleMVCDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<ExampleMVCDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseSqlServer(Configuration.ConnectionString);
            return new ExampleMVCDbContext(dbContextOptionsBuilder.Options);
        }
    }
}
