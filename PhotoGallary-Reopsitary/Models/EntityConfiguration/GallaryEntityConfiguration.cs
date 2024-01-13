using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PhotoGallary_Reopsitary.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoGallary_Reopsitary.Models.EntityConfiguration
{
    internal class GallaryEntityConfiguration : IEntityTypeConfiguration<Gallary>
    {
        public void Configure(EntityTypeBuilder<Gallary> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
        }
    }
}
