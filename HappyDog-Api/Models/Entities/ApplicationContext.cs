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


            base.OnModelCreating(builder);
        }

        public virtual DbSet<BreedPhoto> BreedPhotos { get; set; }
        public virtual DbSet<DogForSale> DogForSales { get; set; }
        public virtual DbSet<DogInfo> DogInfos { get; set; }
        public virtual DbSet<DogType> DogTypes { get; set; }
        public virtual DbSet<Photo> Photos { get; set; }
        public virtual DbSet<Thesis> Theses { get; set; }
        public virtual DbSet<BreedGame> BreedGames { get; set; }
        public virtual DbSet<Request> Requests { get; set; }
    }
}
