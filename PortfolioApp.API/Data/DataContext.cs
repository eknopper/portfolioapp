using Microsoft.EntityFrameworkCore;
using PortfolioApp.API.Models;

namespace PortfolioApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        // Values = table name
        public DbSet<Value> Values { get; set; }
    }
}