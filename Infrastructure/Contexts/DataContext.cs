using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
      
        public DbSet<AddressEntity> Addresses { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        
        public DbSet<FeatureEntity> Features { get; set; }
        public DbSet<FeatureItemEntity> FeaturesItems { get; set; }
    }
}