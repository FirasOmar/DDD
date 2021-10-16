using Domain.Departments;
using Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class EFContext : DbContext
    {
       
        public EFContext(DbContextOptions<EFContext> options) : base(options)
        {
           
        }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Department>();
            builder.Entity<User>();
            base.OnModelCreating(builder);
      
        }
    }
    
}