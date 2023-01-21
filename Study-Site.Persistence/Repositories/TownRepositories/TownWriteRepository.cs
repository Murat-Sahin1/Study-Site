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
    public class TownWriteRepository : WriteRepositoryAsync<Town>, ITownWriteRepository
    {
        public TownWriteRepository(StudySiteDbContext context) : base(context)
        {
        }
    }
}
