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
            DogSize[] sizes = new DogSize[] {
                new DogSize(){ 
                Size = "X-small"                
                },
                 new DogSize(){
                Size = "Mini"
                },
                new DogSize(){
                Size = "Medium"
                }, 
                new DogSize(){
                Size = "Maxi"
                },
                new DogSize(){
                Size = "Giant"
                }
            };

            await context.Set<DogSize>().AddRangeAsync(sizes);
        }
    }
}
