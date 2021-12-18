using bestoTech.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bestoTech.Server.Configurations.Entities
{
    public class AffiliateLinkSeedConfig : IEntityTypeConfiguration<AffiliateLink>
    {
        public void Configure(EntityTypeBuilder<AffiliateLink> builder)
        {
            builder.HasData(

                new AffiliateLink
                {
                    Id = 1,
                    ProductId = 1,
                    Link = "",
                    Price = 0,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new AffiliateLink
                {
                    Id = 2,


                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new AffiliateLink
                {
                    Id = 3,


                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
                ); ; ;
        }
    }
}
