using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyDog_Api.Models.Entities
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        public virtual DbSet<UserAdditionalInfo> UserAdditionalInfo { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasOne(ui => ui.UserAdditionalInfo)
                .WithOne(u => u.User)
                .HasForeignKey<UserAdditionalInfo>();

            builder.Entity<DogInfo>()
                .HasOne(ui => ui.BaseDogInfo)
                .WithOne(u => u.DogInfo)
                .HasForeignKey<BaseDogInfo>();

            builder.Entity<DogInfo>()
             .HasOne(ui => ui.DogCharacteristic)
             .WithOne(u => u.DogInfo)
             .HasForeignKey<DogCharacteristic>();

            builder.Entity<DogInfo>()
             .HasOne(ui => ui.DogSize)
             .WithOne(u => u.DogInfo)
             .HasForeignKey<DogSize>();

            base.OnModelCreating(builder);
        }

        public virtual DbSet<BaseDogInfo> BaseDogInfos { get; set; }
        public virtual DbSet<BreedPhoto> BreedPhotos { get; set; }
        public virtual DbSet<DogCharacteristic> DogCharacteristics { get; set; }
        public virtual DbSet<DogForSale> DogForSales { get; set; }
        public virtual DbSet<DogInfo> DogInfos { get; set; }
        public virtual DbSet<DogSize> DogSizes { get; set; }
        public virtual DbSet<Photo> Photos { get; set; }
        public virtual DbSet<Thesis> Theses { get; set; }
    }
}
