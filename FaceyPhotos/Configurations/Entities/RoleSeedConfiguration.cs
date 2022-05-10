using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FaceyPhotos.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "cc388dac-6edd-64c4-263f-4845196e45c21",
                    Name = "Webmaster",
                    NormalizedName = "WEBMASTER"
                },
                new IdentityRole
                {
                    Id = "cc125dac-6afd-48b4-252f-887900e46b53",
                    Name = "User",
                    NormalizedName = "USER"
                }
                );
        }
    }
}