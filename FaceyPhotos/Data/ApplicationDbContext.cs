using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FaceyPhotos.Data
{
    public class ApplicationDbContext : IdentityDbContext<Customer>       
      
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }

    public class CalenderContext : DbContext
    {
        public CalendarContext() : base()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<CalendarContext>());
        }
        public System.Data.Entity.DbSet<AppointmentCalendar.Models.Appointment> Appointments { get; set; }
    }
}