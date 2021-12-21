using System;
using Ekz_Apteka.Models;
using Microsoft.EntityFrameworkCore;

namespace EKZ.Models
{
    public class EkzDbContext : DbContext
    {
        public EkzDbContext(DbContextOptions<EkzDbContext> options) : base(options)
        {

        }

        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<MedicineType> MedicineTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MedicineType>().HasData(
                new MedicineType() {MedicineTypeId = 1, MedicineTypeName = "Spray"},
                new MedicineType() { MedicineTypeId = 2, MedicineTypeName = "Tablets" },
                new MedicineType() { MedicineTypeId = 3, MedicineTypeName = "Ointment" },
                new MedicineType() { MedicineTypeId = 4, MedicineTypeName = "Prick" }
            );

            modelBuilder.Entity<Medicine>().HasData(
                new Medicine()
                {
                    MedicineId = 1,
                    MedicineName = "Dr.DOM",
                    MedicinePrice = 100,
                    SellTime = DateTime.Today,
                    MedicineTypeId = 2
                });
        }
    }
}