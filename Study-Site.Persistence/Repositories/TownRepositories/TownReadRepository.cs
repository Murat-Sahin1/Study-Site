using Study_Site.Application.Interfaces.Repositories;
using Study_Site.Domain.Entities;
using Study_Site.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Site.Persistence.Repositories
{
    public class TownReadRepository : ReadRepositoryAsync<Town>, ITownReadRepository
    {
        public TownReadRepository(StudySiteDbContext context) : base(context)
        {
        }
    }
}
