using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorTestDemo.Models
{
    public class MoiveContext: DbContext
    {
        public MoiveContext(DbContextOptions<MoiveContext> options):base(options){}

        public DbSet<Moive> Moive { get; set; }
    }
}
