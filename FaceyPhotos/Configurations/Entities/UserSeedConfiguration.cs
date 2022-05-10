using FaceyPhotos.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FaceyPhotos.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            var hasher = new PasswordHasher<Customer>();
            builder.HasData(
                new Customer
                {
                    Id = "cc371dac-6edd-48c4-862f-466300e46c21",
                    Email = "webmaster@localhost.com",
                    NormalizedEmail = "WEBMASTER@LOCALHOST.COM",
                    NormalizedUserName = "WEBMASTER@LOCALHOST.COM",
                    UserName = "webmaster@localhost.com",
                    Firstname = "Web",
                    Lastname = "Master",
                    PasswordHash = hasher.HashPassword(null, "W3b@dm!n2022"),
                    EmailConfirmed = true
                },
                new Customer
                {
                    Id = "d0d2aa73-1312-4ed7-b309-75b8563e8092",
                    Email = "client@localhost.com.com",
                    NormalizedEmail = "CLIENT@LOCALHOST.COM",
                    NormalizedUserName = "CLIENT@LOCALHOST.COM",
                    UserName = "client@localhost.com",
                    Firstname = "local",
                    Lastname = "client",
                    PasswordHash = hasher.HashPassword(null, "P@ssw0rd1"),
                    EmailConfirmed = true
                }

            );
        }

    }
}