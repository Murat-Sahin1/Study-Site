using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Study_Site.Persistence.Configurations;
using Study_Site.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Site.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<StudySiteDbContext>
    {
        //CLI üzerinden Migration basmak adına, DbContext options, DbContext nesnesi ayağa kalkarken belirli options parametrelerini sunuyoruz.
        public StudySiteDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<StudySiteDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseNpgsql(Configuration.ConnectionString);
            return new(dbContextOptionsBuilder.Options);
        }
    }
}

