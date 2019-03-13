using Microsoft.EntityFrameworkCore;
using TaskerSpaceX.Models;

namespace TaskerSpaceX.Data
{
    public class DataContext:DbContext
    {

        public DbSet<Value> Values { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}
