using Study_Site.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Site.Application.Interfaces.Repositories
{
    public interface ITownWriteRepository : IWriteRepositoryAsync<Town>
    {
    }
}
