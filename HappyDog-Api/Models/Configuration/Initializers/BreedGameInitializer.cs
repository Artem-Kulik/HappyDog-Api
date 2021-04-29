using HappyDog_Api.Models.Configuration.Interfaces;
using HappyDog_Api.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyDog_Api.Models.Configuration.Initializers
{
    public class BreedGameInitializer : ITypeInitializer
    {
        public async Task Init(ApplicationContext context)
        {
            BreedGame[] games = new BreedGame[] {
                new BreedGame(){ 
                FirstAnswer = "Bigle",
                SecondAnswer = "English setter",
                ThirdAnswer = "Basset Hound",
                RightAnswer = "Bigle",
                BreedImage = "/Images/Gbigle.jpg"
                },
                new BreedGame(){
                FirstAnswer = "Kurzhaar",
                SecondAnswer = "French Bulldog",
                ThirdAnswer = "Boxer",
                RightAnswer = "Boxer",
                BreedImage = "/Images/Gbokser.jpg"
                },
                new BreedGame(){
                FirstAnswer = "Bigle",
                SecondAnswer = "English cocker spaniel",
                ThirdAnswer = "Shar Pei",
                RightAnswer = "English cocker spaniel",
                BreedImage = "/Images/Gcocerspaniel.jpg"
                },
                new BreedGame(){
                FirstAnswer = "Dalmatian",
                SecondAnswer = "English setter",
                ThirdAnswer = "Weimaraner",
                RightAnswer = "Dalmatian",
                BreedImage = "/Images/Gdalmatinets.jpg"
                },
                new BreedGame(){
                FirstAnswer = "Drathhaar",
                SecondAnswer = "Doberman",
                ThirdAnswer = "German dog",
                RightAnswer = "Doberman",
                BreedImage = "/Images/Gdoberman.jpg"
                },
                new BreedGame(){
                FirstAnswer = "Chihuahua",
                SecondAnswer = "Pomeranian",
                ThirdAnswer = "Welsh corgi pembroke",
                RightAnswer = "Welsh corgi pembroke",
                BreedImage = "/Images/Gkorgi.jpg"
                },
                new BreedGame(){
                FirstAnswer = "Сollie",
                SecondAnswer = "Rottweiler",
                ThirdAnswer = "Labrador retriever",
                RightAnswer = "Labrador retriever",
                BreedImage = "/Images/Glabrador.jpg"
                },
                new BreedGame(){
                FirstAnswer = "Shiba inu",
                SecondAnswer = "Akita Inu",
                ThirdAnswer = "American akita",
                RightAnswer = "Shiba inu",
                BreedImage = "/Images/Gsiba-inu.jpg"
                },
                new BreedGame(){
                FirstAnswer = "Weimaraner",
                SecondAnswer = "Alabai",
                ThirdAnswer = "Jack Russell Terrier",
                RightAnswer = "Weimaraner",
                BreedImage = "/Images/Gveimaraner.jpg"
                },
                new BreedGame(){
                FirstAnswer = "Spanish Mastiff",
                SecondAnswer = "Newfoundland",
                ThirdAnswer = "Bernese mountain dog",
                RightAnswer = "Bernese mountain dog",
                BreedImage = "/Images/Gzennenkhun.jpg"
                }
            };

            await context.Set<BreedGame>().AddRangeAsync(games);
        }
    }
}
