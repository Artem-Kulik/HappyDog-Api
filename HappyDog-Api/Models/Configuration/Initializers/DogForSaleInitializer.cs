using HappyDog_Api.Models.Configuration.Interfaces;
using HappyDog_Api.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyDog_Api.Models.Configuration.Initializers
{
    public class DogForSaleInitializer : ITypeInitializer
    {
        public async Task Init(ApplicationContext context)
        {
            DogForSale[] Sdogs = new DogForSale[] {
                new DogForSale(){
                     Name = "",
                     Age = "2,5 month",
                     Breed = "Welsh corgi pembroke",
                     DogType = context.DogTypes.Where(x=> x.Type == "Smart").FirstOrDefault(),
                     MainPhoto = "/SaleImages/saleDog1-1.jpg",
                     Price = 730,
                     Info = "Corgi is a dog ideal for a large and friendly family. Are you ready to accept such a friend into your family?",
                },
                new DogForSale(){
                     Name = "",
                     Age = "45 days",
                     Breed = "French Bulldog",
                     DogType = context.DogTypes.Where(x=> x.Type == "Kind").FirstOrDefault(),
                     MainPhoto = "/SaleImages/saleDog2-1.jpg",
                     Price = 950,
                     Info = "Lovers of perfect cleanliness, these dogs are not suitable: they drool, are prone to flatulence, molt. Are you ready to accept such a friend into your family?"
                },
                new DogForSale(){
                     Name = "",
                     Age = "1,5 month",
                     Breed = "Chihuahua",
                     DogType = context.DogTypes.Where(x=> x.Type == "Kind").FirstOrDefault(),
                     MainPhoto = "/SaleImages/saleDog3-1.jpg",
                     Price = 240,
                     Info = "They do not agree to put up with the loneliness and long absences of the owner. Are you ready to accept such a friend into your family?"
                },
                new DogForSale(){
                     Name = "",
                     Age = "3,5 month",
                     Breed = "Akita Inu",
                     DogType = context.DogTypes.Where(x=> x.Type == "Expensive").FirstOrDefault(),
                     MainPhoto = "/SaleImages/saleDog4-1.jpg",
                     Price = 1400,
                     Info = "Proper upbringing, long-term socialization, competent training are extremely important, otherwise the animal is able to grow up aggressive. Are you ready to accept such a friend into your family?"
                },
                new DogForSale(){
                     Name = "",
                     Age = "2 month",
                     Breed = "Weimaraner",
                     DogType = context.DogTypes.Where(x=> x.Type == "Hunting").FirstOrDefault(),
                     MainPhoto = "/SaleImages/saleDog5-1.jpg",
                     Price = 400,
                     Info = "They are temperamental enough, but they demonstrate a balanced, stable character. Are you ready to accept such a friend into your family?"
                },
                new DogForSale(){
                     Name = "",
                     Age = "70 days",
                     Breed = "Beagle",
                     DogType = context.DogTypes.Where(x=> x.Type == "Hunting").FirstOrDefault(),
                     MainPhoto = "/SaleImages/saleDog6-1.jpg",
                     Price = 530,
                     Info = "The main problem of beagles is their loud barking, so be prepared for possible quarrels with your neighbors. Are you ready to accept such a friend into your family?"
                },
                new DogForSale(){
                     Name = "",
                     Age = "1,5 month",
                     Breed = "Cane Corso",
                     DogType = context.DogTypes.Where(x=> x.Type == "Watchdog").FirstOrDefault(),
                     MainPhoto = "/SaleImages/saleDog7-1.jpg",
                     Price = 700,
                     Info = "Cane Corso is characterized by kindness and attentiveness, they are affectionate with the owner and require reciprocity. Are you ready to accept such a friend into your family?"
                },
                new DogForSale(){
                     Name = "",
                     Age = "4 month",
                     Breed = "Akita Inu",
                     DogType = context.DogTypes.Where(x=> x.Type == "Expensive").FirstOrDefault(),
                     MainPhoto = "/SaleImages/saleDog8-1.jpg",
                     Price = 1250,
                     Info = "Akita Inu does not like other dogs, especially his own gender. Are you ready to accept such a friend into your family?"
                },
                new DogForSale(){
                     Name = "",
                     Age = "3 month",
                     Breed = "Pug",
                     DogType = context.DogTypes.Where(x=> x.Type == "Kind").FirstOrDefault(),
                     MainPhoto = "/SaleImages/saleDog9-1.jpg",
                     Price = 350,
                     Info = "Pugs are friendly towards family members, strangers, and other animals. Are you ready to accept such a friend into your family?"
                },
                new DogForSale(){
                     Name = "",
                     Age = "3 month",
                     Breed = "American akita",
                     DogType = context.DogTypes.Where(x=> x.Type == "Expensive").FirstOrDefault(),
                     MainPhoto = "/SaleImages/saleDog10-1.jpg",
                     Price = 1600,
                     Info = "The American Akita has a very stable psyche. She shows aggression only in the presence of danger. Are you ready to accept such a friend into your family?"
                },
                new DogForSale(){
                     Name = "",
                     Age = "3,5 month",
                     Breed = "Dogo argentino",
                     DogType = context.DogTypes.Where(x=> x.Type == "Watchdog").FirstOrDefault(),
                     MainPhoto = "/SaleImages/saleDog11-1.jpg",
                     Price = 380,
                     Info = "From the first day of its existence, the breed was used for hunting large game. Are you ready to accept such a friend into your family?"
                },
                new DogForSale(){
                     Name = "",
                     Age = "2 month",
                     Breed = "Pug",
                     DogType = context.DogTypes.Where(x=> x.Type == "Kind").FirstOrDefault(),
                     MainPhoto = "/SaleImages/saleDog12-1.jpg",
                     Price = 300,
                     Info = "The owner needs to closely monitor their health. Are you ready to accept such a friend into your family?"
                },
                new DogForSale(){
                     Name = "",
                     Age = "45 days",
                     Breed = "Jack Russell Terrier",
                     DogType = context.DogTypes.Where(x=> x.Type == "Smart").FirstOrDefault(),
                     MainPhoto = "/SaleImages/saleDog13-1.jpg",
                     Price = 600,
                     Info = "Jack Russell Terrier is suitable only for people who lead an active lifestyle and can provide the pet with regular physical activity. Are you ready to accept such a friend into your family?"
                },
                new DogForSale(){
                     Name = "",
                     Age = "3 month",
                     Breed = "Labrador retriever",
                     DogType = context.DogTypes.Where(x=> x.Type == "Kind").FirstOrDefault(),
                     MainPhoto = "/SaleImages/saleDog14-1.jpg",
                     Price = 300,
                     Info = "A Labrador retriever can be kept in an apartment, but long daily walks and sufficient physical activity are required. Are you ready to accept such a friend into your family?"
                },
                new DogForSale(){
                     Name = "",
                     Age = "1 month",
                     Breed = "Siberian Husky",
                     DogType = context.DogTypes.Where(x=> x.Type == "Watchdog").FirstOrDefault(),
                     MainPhoto = "/SaleImages/saleDog15-1.jpg",
                     Price = 500,
                     Info = "Husky has a cheerful, good-natured and welcoming perception of people of all ages, a calm attitude towards strangers. Are you ready to accept such a friend into your family?"
                },
                new DogForSale(){
                     Name = "",
                     Age = "1,5 month",
                     Breed = "Boxer",
                     DogType = context.DogTypes.Where(x=> x.Type == "Watchdog").FirstOrDefault(),
                     MainPhoto = "/SaleImages/saleDog16-1.jpg",
                     Price = 500,
                     Info = "The Boxer is an excellent watchman, and all thanks to his courage and fearlessness. Are you ready to accept such a friend into your family?"
                },
                new DogForSale(){
                     Name = "",
                     Age = "2 month",
                     Breed = "English cocker spaniel",
                     DogType = context.DogTypes.Where(x=> x.Type == "Smart").FirstOrDefault(),
                     MainPhoto = "/SaleImages/saleDog17-1.jpg",
                     Price = 250,
                     Info = "Barking loudly with or without reason is one of the favorite pastimes of cocker spaniels, so get some earplugs or train your own patience and endurance. Are you ready to accept such a friend into your family?"
                },
                new DogForSale(){
                     Name = "",
                     Age = "4 month",
                     Breed = "Jack Russell Terrier",
                     DogType = context.DogTypes.Where(x=> x.Type == "Smart").FirstOrDefault(),
                     MainPhoto = "/SaleImages/saleDog19-1.jpg",
                     Price = 550,
                     Info = "Dogs are firmly attached to the owner and other family members, they yearn alone. Are you ready to accept such a friend into your family?"
                },
                new DogForSale(){
                     Name = "",
                     Age = "2 month",
                     Breed = "Shar Pei",
                     DogType = context.DogTypes.Where(x=> x.Type == "Watchdog").FirstOrDefault(),
                     MainPhoto = "/SaleImages/saleDog20-1.jpg",
                     Price = 450,
                     Info = "Sharpey needs an experienced and strong owner who can maintain his authority in the eyes of the pet. Are you ready to accept such a friend into your family?"
                }
            };

            await context.Set<DogForSale>().AddRangeAsync(Sdogs);
        }
    }
}
