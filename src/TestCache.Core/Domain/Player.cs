using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCache.Domain
{
    public class Player: Entity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
