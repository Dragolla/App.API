using Microsoft.EntityFrameworkCore;
using TeachingApp.API.Models;

namespace TeachingApp.API.Data.cs
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options){}
        public DbSet<Values> Value { get; set; }
        
    }
}