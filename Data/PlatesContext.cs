using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PLATES.Models;

namespace PLATES.Data
{
    
    
        public class PlatesContext : DbContext
        {
            public PlatesContext(DbContextOptions<PlatesContext> options)
                : base(options)
            {

            }
            public DbSet<Plates> Plates { get; set; }
        }
    
}
