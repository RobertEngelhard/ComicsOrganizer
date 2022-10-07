using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;

namespace Data.Configurations
{
    internal class ComicsAlbumsConfiguration : IEntityTypeConfiguration<ComicsAlbums>
    {
        /// <remarks>
        /// IsRequired() on properties of owned entities is ignored.
        /// According to EF Core team, "value objects would work better if implemented using value converters".
        /// https://github.com/dotnet/efcore/issues/18445
        /// https://github.com/dotnet/efcore/issues/16943
        /// </remarks>
        public virtual void Configure(EntityTypeBuilder<ComicsAlbums> builder)
        {
            // Table
            builder.ToTable("ComicsAlbums");
            // Keys
            builder.HasKey(p => p.Id);

            //// Discriminator
            //builder.HasDiscriminator<string>("PrescriptionType")
            //       .HasValue<PharmaceuticalPrescriptionState>("PHARM")

            // Fields
           
            builder.Property(p => p.Number)
                   .HasColumnName("Number");
            builder.HasOne(x => x.Series);
            
        }

       
    }
}