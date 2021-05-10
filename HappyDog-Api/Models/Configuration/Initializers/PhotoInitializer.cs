using HappyDog_Api.Models.Configuration.Interfaces;
using HappyDog_Api.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyDog_Api.Models.Configuration.Initializers
{
    public class PhotoInitializer : ITypeInitializer
    {
        public async Task Init(ApplicationContext context)
        {
            string p = "/SaleImages/";
            Photo[] photos = new Photo[] {
                new Photo(){ 
                    Path = p + "saleDog1-1.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog1-1.jpg").FirstOrDefault()
                    
                },
                new Photo(){
                    Path = p + "saleDog1-2.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog1-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog1-3.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog1-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog2-1.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog2-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog2-2.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog2-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog2-3.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog2-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog3-1.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog3-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog3-2.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog3-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog3-3.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog3-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog4-1.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog4-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog4-2.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog4-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog5-1.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog5-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog5-2.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog5-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog5-3.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog5-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog6-1.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog6-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog6-2.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog6-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog6-3.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog6-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog7-1.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog7-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog7-2.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog7-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog7-3.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog7-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog8-1.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog8-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog8-2.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog8-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog8-3.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog8-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog9-1.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog9-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog9-2.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog9-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog9-3.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog9-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog10-1.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog10-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog10-2.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog10-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog10-3.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog10-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog11-1.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog11-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog11-2.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog11-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog12-1.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog12-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog12-2.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog12-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog12-2.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog12-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog13-1.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog13-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog13-2.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog13-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog14-1.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog14-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog14-2.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog14-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog14-3.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog14-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog15-1.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog15-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog15-2.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog15-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog15-3.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog15-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog16-1.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog16-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog16-2.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog16-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog16-3.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog16-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog17-1.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog17-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog17-2.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog17-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog17-3.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog17-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog18-1.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog18-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog18-2.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog18-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog18-3.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog18-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog19-1.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog19-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog19-2.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog19-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog19-3.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog19-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog20-1.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog20-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog20-2.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog20-1.jpg").FirstOrDefault()
                },
                new Photo(){
                    Path = p + "saleDog20-3.jpg",
                    DogForSale = context.DogForSales.Where(x=>x.MainPhoto == p + "saleDog20-1.jpg").FirstOrDefault()
                }
            };

            await context.Set<Photo>().AddRangeAsync(photos);
        }
    }
}
