using DotNetApiRepositoryPatternEntities.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetApiRepositoryPatternRepository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {
        }
        
        public DbSet<Company>? Companies { get; set; }
        public DbSet<Employee>? Employees { get; set; }
    }
}