using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;



namespace FaceyPhotos.Data
{
    public class ApplicationDbContext : IdentityDbContext<Customer>

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


       //public System.Data.Entity.DbSet<AppointmentCalendar.Models.Appointment> Appointments { get; set; }
        public DbSet<Contact>Contacts { get; set; }
        public DbSet<Service>Services { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }

    }
}