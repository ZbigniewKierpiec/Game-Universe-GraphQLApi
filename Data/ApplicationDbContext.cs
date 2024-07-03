using GraphQL.Data.Entities;

using Microsoft.EntityFrameworkCore;

namespace GraphQL.Data
{
    public class ApplicationDbContext:DbContext
    {
     
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                   : base(options)
        {
        }
   
      public DbSet<Games> Games { get; set; }

    }
}
