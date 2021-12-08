using Microsoft.EntityFrameworkCore;

namespace ExportExcel_in_ASPNetCore.Models
{
    public class myDataContext : DbContext
    {
        public myDataContext(DbContextOptions<myDataContext> options) : base(options)
        {
        }

        public DbSet<Customer> customers { get; set; }
    }
}