using bestoTech.Server.Configurations.Entities;
using bestoTech.Server.Models;
using bestoTech.Shared.Domain;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bestoTech.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<AStore> AStores { get; set; }
        public DbSet<ALink> ALinks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //builder.ApplyConfiguration(new ALinkSeedConfig());
            builder.ApplyConfiguration(new AStoreSeedConfig());
            builder.ApplyConfiguration(new BrandSeedConfig());
            builder.ApplyConfiguration(new CategorySeedConfig());
            builder.ApplyConfiguration(new RoleSeedConfig());
            builder.ApplyConfiguration(new UserRoleSeedConfig());
            builder.ApplyConfiguration(new UserSeedConfig());
        }

        
    }
}
