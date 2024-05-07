using mesterdoc.data;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace mesterdoc.ExtensionMethods
{
    public static class MigrationExtension
    {
        public static void ApplyMigrations(this IApplicationBuilder app)
        {
            using IServiceScope scope= app.ApplicationServices.CreateScope();
            using ApplicationDbContext dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            dbContext.Database.Migrate();
        }
    }
}
