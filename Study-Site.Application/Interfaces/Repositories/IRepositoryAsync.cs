using Microsoft.EntityFrameworkCore;
using Study_Site.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Study_Site.Application.Interfaces.Repositories
{
    public interface IRepositoryAsync<TEntity>  where TEntity : BaseEntity
    {}
}
