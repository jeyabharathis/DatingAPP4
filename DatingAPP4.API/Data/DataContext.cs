using DatingAPP4.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingAPP4.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}
        public DbSet<Value> Values { get; set; }
       
    }
}