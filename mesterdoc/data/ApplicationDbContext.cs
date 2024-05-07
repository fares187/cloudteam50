
using mesterdoc.Models;
using Microsoft.EntityFrameworkCore;

namespace mesterdoc.data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
       public DbSet<MemberModel> Members { get; set; } 
    }
}
