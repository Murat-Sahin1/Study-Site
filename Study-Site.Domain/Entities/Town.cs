using Study_Site.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Site.Domain.Entities
{
    public class Town : BaseEntity
    {
        public string Name { get; set; }
        public ClockTower ClockTower { get; set; }
        public string Description { get; set; }
        public List<string> Buildings { get; set; }
        public int Workers { get; set; }
        public int WoodResource { get; set; }
        public int StoneResource { get; set; }
    }
}