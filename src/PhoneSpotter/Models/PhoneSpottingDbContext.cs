using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneSpotter.Models
{
    public class PhoneSpottingDbContext : DbContext
    {
        public DbSet<PhoneSpotting> Spottings { get; set; }
    }
}
