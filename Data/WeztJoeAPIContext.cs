using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WeztJoeAPI.Model;

namespace WeztJoeAPI.Data
{
    public class WeztJoeAPIContext : DbContext
    {
        public WeztJoeAPIContext (DbContextOptions<WeztJoeAPIContext> options)
            : base(options)
        {
        }

        public DbSet<WeztJoeAPI.Model.Library> Library { get; set; } = default!;
    }
}
