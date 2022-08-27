using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using apirest_asp.net.Models;

namespace apirest_asp.net.Data
{
    public class apirest_aspnetContext : DbContext
    {
        public apirest_aspnetContext (DbContextOptions<apirest_aspnetContext> options)
            : base(options)
        {
        }

        public DbSet<apirest_asp.net.Models.Book> Book { get; set; } = default!;
    }
}
