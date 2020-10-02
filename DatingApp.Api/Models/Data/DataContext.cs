using Microsoft.EntityFrameworkCore;
using DatingApp.Api.Models;


namespace DatingApp.Api.Models.Data
{

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<Value> Values { get; set; }
    }

}