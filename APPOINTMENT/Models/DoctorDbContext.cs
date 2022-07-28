using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APPOINTMENT.Models
{
    public class DoctorDbContext : DbContext
    {
        public DbSet<AppointmentSlot> Appointments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }

        public DoctorDbContext(DbContextOptions<DoctorDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>().HasData(new Doctor { Id = 1, Name = "Doctor 1" });
            modelBuilder.Entity<Doctor>().HasData(new Doctor { Id = 2, Name = "Doctor 2" });
            modelBuilder.Entity<Doctor>().HasData(new Doctor { Id = 3, Name = "Doctor 3" });

        }
    
    }
}
