using Catalina.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalina.Repository
{
    public class CatalinaContext : DbContext
    {
        public DbSet<Booking> Booking { get; set; }
        public DbSet<OSI> OSIs { get; set; }
        public DbSet<Segment> Segments { get; set; }
        public DbSet<SSR> SSRs { get; set; }

    }
}
