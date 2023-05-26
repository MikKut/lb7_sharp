using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repositories.Persistence;

internal class ApplicationDatabaseContext : DbContext
{
    public ApplicationDatabaseContext() : base()
    { }

    public DbSet<DepartmentEntity> Departments { get; set; }
    public DbSet<EmployeeEntity> Employees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("YourDatabaseName");
    }
}
