using app1.API.Models;
using Microsoft.EntityFrameworkCore;

namespace app1.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
        public DbSet<Value> Values { get; set; }
    }
}