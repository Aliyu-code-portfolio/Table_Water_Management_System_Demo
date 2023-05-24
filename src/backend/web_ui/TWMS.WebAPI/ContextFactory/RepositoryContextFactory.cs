using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using TWMS.Infrastructure.Persistence.DBContext;

namespace TWMS.WebAPI.ContextFactory
{
    public class RepositoryContextFactory: IDesignTimeDbContextFactory<RepositoryContext>
    {
        public RepositoryContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
            var builder = new DbContextOptionsBuilder<RepositoryContext>()
            .UseSqlServer(configuration.GetConnectionString("DefaultConnectionString"),b=>b.MigrationsAssembly("TWMS.Infrastructure"));
            return new RepositoryContext(builder.Options);
        }
    }
}
