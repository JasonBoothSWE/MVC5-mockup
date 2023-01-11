using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC5_mockup.Models;

namespace MVC5_mockup.Data
{
    public class MvcDeviceContext : DbContext
    {
        public MvcDeviceContext (DbContextOptions<MvcDeviceContext> options)
            : base(options)
        {
        }

        public DbSet<MVC5_mockup.Models.Device> Device { get; set; } = default!;
    }
}
