using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using HappyDog_Api.Models.Dto;
using HappyDog_Api.Models.Dto.ResultDto;
using HappyDog_Api.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HappyDog_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public AdminController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpPost("editBreed")]
        public ResultDto editBreed(DogInfoDto x)
        {
            var p = _context.DogInfos.Find(x.Id);

            //p.MainPhoto = x.MainPhoto;
            p.MainDescription = x.MainDescription;

            //p.BigPhoto = x.BigPhoto;
            p.BigDescription = x.BigDescription;

            p.Breed = x.Breed;
            p.Country = x.Country;
            p.Weight = x.Weight;
            p.Height = x.Height;
            p.LifeExpectancy = x.LifeExpectancy;

            p.Aggressiveness = x.Aggressiveness;
            p.Activity = x.Activity;
            p.Health = x.Health;
            p.Intelligence = x.Intelligence;
            p.Training = x.Training;
            p.MaintenanceCost = x.MaintenanceCost;
            p.Molting = x.Molting;
            p.SecurityQualities = x.SecurityQualities;
            p.Noise = x.Noise;

            p.Price = x.Price;

            p.DogTypeId = _context.DogTypes.Where(y => y.Type == x.DogType).FirstOrDefault().Id;

            _context.SaveChanges();

            return new ResultDto
            {
                IsSuccessful = true,
                Message = ""
            };

        }

        [HttpPost("addBreed")]
        public ResultDto addBreed(DogInfoDto x)
        {
            DogInfo d = new DogInfo()
            {
                MainPhoto = x.MainPhoto,
                MainDescription = x.MainDescription,

                BigPhoto = x.BigPhoto,
                BigDescription = x.BigDescription,

                Breed = x.Breed,
                Country = x.Country,
                Weight = x.Weight,
                Height = x.Height,
                LifeExpectancy = x.LifeExpectancy,

                Aggressiveness = x.Aggressiveness,
                Activity = x.Activity,
                Health = x.Health,
                Intelligence = x.Intelligence,
                Training = x.Training,
                MaintenanceCost = x.MaintenanceCost,
                Molting = x.Molting,
                SecurityQualities = x.SecurityQualities,
                Price = x.Price,
                Noise = x.Noise,

                DogTypeId = _context.DogTypes.Where(y => y.Type == x.DogType).FirstOrDefault().Id
            };

            _context.DogInfos.Add(d);
            _context.SaveChanges();

            return new ResultDto
            {
                IsSuccessful = true,
                Message = ""
            };

        }

        [HttpGet("deleteBreed/{breed}")]
        public ResultDto deleteBreed([FromRoute]string breed)
        {
            _context.DogInfos.Remove(_context.DogInfos.Where(x=>x.Breed == breed).FirstOrDefault());
            _context.SaveChanges();

            return new ResultDto
            {
                IsSuccessful = true,
                Message = ""
            };
        }

        [HttpPost("editSaleDog")]
        public ResultDto EditSaleDog(DogForSaleDto x)
        {
            var p = _context.DogForSales.Find(x.Id);

            p.Age = x.Age;
            p.Breed = x.Breed;
            p.Price = x.Price;
            p.Info = x.Info;

            p.DogTypeId = _context.DogTypes.Where(y => y.Type == x.DogType).FirstOrDefault().Id;

            _context.SaveChanges();

            return new ResultDto
            {
                IsSuccessful = true,
                Message = ""
            };
        }
        [HttpGet("deleteSaleDog/{id}")]
        public ResultDto deleteSaleDog([FromRoute]int id)
        {
            var dfs = _context.DogForSales.Find(id);
            var photos = _context.Photos.Where(x => x.DogForSaleId == id);
            _context.Photos.RemoveRange(photos);
            _context.DogForSales.Remove(dfs);
            _context.SaveChanges();

            return new ResultDto
            {
                IsSuccessful = true,
                Message = ""
            };
        }


        [HttpPost("addSaleDog")]
        public ResultDto AddSaleDog(DogForSaleDto x)
        {
            DogForSale d = new DogForSale()
            {
                MainPhoto = x.MainPhoto,
                Age = x.Age,
                Breed = x.Breed,
                Price = x.Price,
                Info = x.Info,
                //  DogTypeId = _context.DogTypes.Where(y => y.Type == x.DogType).FirstOrDefault().Id
            };

            _context.DogForSales.Add(d);
            _context.SaveChanges();

            return new ResultDto
            {
                IsSuccessful = true,
                Message = ""
            };

        }


        [HttpGet("getUsers")]
        public ResultDto getUsers()
        {
            var users = _context.UserAdditionalInfo.Select(u => new UserInfoDto
            {
                PhoneNumber = _context.Users.Where(x=>x.Id == u.Id).FirstOrDefault().PhoneNumber,
                Email = _context.Users.Where(x => x.Id == u.Id).FirstOrDefault().Email,
                Photo = u.Photo,
                Name = u.Name,
                City = u.City,
                Id = u.Id,
                Coins = u.Coins,
            }).ToList();

            return new CollectionResultDto<UserInfoDto>()
            {
                IsSuccessful = true,
                Data = users
            };
        }


        [HttpGet("getRequests")]
        public ResultDto getRequests()
        {
            var requests = _context.Requests.Select(d => new RequestDto
            {
                Id = d.Id,
                Age = d.Age,
                Breed = d.Breed,
                BreedType = d.BreedType,
                Info = d.Info,
                MainPhoto = d.MainPhoto,
                Price = d.Price
            }).ToList();

            return new CollectionResultDto<RequestDto>()
            {
                IsSuccessful = true,
                Data = requests
            };
        }
                
        [HttpPost("sendRequest")]
        public ResultDto sendRequest(AnswerResultDto res)
        {
            if (res.res == true)
            {
                var x = _context.Requests.Find(Convert.ToInt32(res.id));
                DogForSale d = new DogForSale()
                {
                    MainPhoto = x.MainPhoto,
                    Age = x.Age,
                    Breed = x.Breed,
                    Price = x.Price,
                    Info = x.Info + ". Are you ready to accept such a friend into your family?",                    
                    DogTypeId = _context.DogTypes.Where(y => y.Type == x.BreedType).FirstOrDefault().Id
                };
                _context.DogForSales.Add(d);
                _context.SaveChanges();

                Photo p = new Photo
                {
                    Path = d.MainPhoto,
                    DogForSaleId = d.Id
                };
                _context.Photos.Add(p);
            }
            else {
                _context.Requests.Remove(_context.Requests.Find(Convert.ToInt32(res.id)));
            }

            _context.SaveChanges();
            return new ResultDto
            {
                IsSuccessful = true              
            };
        }


    }
}