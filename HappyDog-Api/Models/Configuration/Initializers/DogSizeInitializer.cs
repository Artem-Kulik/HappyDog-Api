using HappyDog_Api.Models.Configuration.Interfaces;
using HappyDog_Api.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyDog_Api.Models.Configuration.Initializers
{
    public class DogSizeInitializer : ITypeInitializer
    {
        public async Task Init(ApplicationContext context)
        {
            DogType[] sizes = new DogType[] {
                new DogType(){ 
                Type = "Watchdog"                
                },
                 new DogType(){
                Type = "Hunting"
                },
                new DogType(){
                Type = "Smart"
                },
                new DogType(){
                Type = "Kind"
                },
                new DogType(){
                Type = "Expensive"
                }
            };

            await context.Set<DogType>().AddRangeAsync(sizes);
        }
    }
}
