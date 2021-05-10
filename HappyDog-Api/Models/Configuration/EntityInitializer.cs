using HappyDog_Api.Models.Configuration.Initializers;
using HappyDog_Api.Models.Configuration.Interfaces;
using HappyDog_Api.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyDog_Api.Models.Configuration
{
    public class EntityInitializer: IEntityInitializer
    {
        private readonly List<ITypeInitializer> typeInitializers;
        private readonly UserManager<User> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly ApplicationContext context;

        public EntityInitializer(UserManager<User> _userManager,
                                 RoleManager<IdentityRole> _roleManager,
                                 ApplicationContext _context)
        {
            typeInitializers = new List<ITypeInitializer>();
            userManager = _userManager;
            roleManager = _roleManager;
            context = _context;

            //add concrete initializers
            //order is IMPORTANT (for example, you first need to add categories and only then products that are category-dependent)

            this.AddConfig(new DogSizeInitializer());
            this.AddConfig(new BreedGameInitializer());
            this.AddConfig(new DogInfoInitializer());
            this.AddConfig(new ThesisInitializer());

            this.AddConfig(new DogForSaleInitializer());
            this.AddConfig(new PhotoInitializer());
        }
         
        public void AddConfig(ITypeInitializer typeInitializer)
        {
            typeInitializers.Add(typeInitializer);
        }

        public async Task SeedData()
        {
            //always delete and recreate database with seeded data
            bool deleted = await context.Database.EnsureDeletedAsync();
            bool created = await context.Database.EnsureCreatedAsync();
            await InitializeIdetity();
            //create test users and admins
            //go through all the initializers and seed them all
            foreach (var initializer in typeInitializers)
            {
                await initializer.Init(context);
                await context.SaveChangesAsync();
            }
        }

        private async Task InitializeIdetity()
        {
            //Create roles
            await roleManager.CreateAsync(new IdentityRole { Name = "Admin" });
            await roleManager.CreateAsync(new IdentityRole { Name = "User" });
            await roleManager.CreateAsync(new IdentityRole { Name = "Guest" });

            await userManager.CreateAsync(new User
            {
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com"
            }, "Qwerty1-");

            var admin = await userManager.FindByEmailAsync("admin@gmail.com");
            await userManager.AddToRoleAsync(admin, "Admin");
        }
    }
}
