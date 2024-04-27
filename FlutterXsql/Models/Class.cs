using Microsoft.EntityFrameworkCore;

namespace FlutterXsql.Models
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
        }

        public DbSet<Users> Class { get; set; }

    }
}
