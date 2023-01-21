using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Study_Site.Persistence.Configurations;
using Study_Site.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Site.Persistence
{
    public static class RepositoryRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<StudySiteDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));
        }
    }
}
