using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FaceyPhotos.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {

        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "cc388dac-6edd-64c4-263f-4845196e45c21",
                    UserId = "cc371dac-6edd-48c4-862f-466300e46c21"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "cc125dac-6afd-48b4-252f-887900e46b53",
                    UserId = "d0d2aa73-1312-4ed7-b309-75b8563e8092"
                }

                );
        }
    }
}