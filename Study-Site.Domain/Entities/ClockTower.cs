using Study_Site.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Site.Domain.Entities
{
    public class ClockTower : BaseEntity
    {
        public string Name { get; set; }
        public float Time { get; set; }
        public string Color { get; set; }
    }
}
