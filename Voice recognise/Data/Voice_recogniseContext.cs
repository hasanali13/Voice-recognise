using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Voice_recognise.Models;

namespace Voice_recognise.Data
{
    public class Voice_recogniseContext : DbContext
    {
        public Voice_recogniseContext (DbContextOptions<Voice_recogniseContext> options)
            : base(options)
        {
        }

        public DbSet<Voice_recognise.Models.Details> Details { get; set; } = default!;
    }
}
