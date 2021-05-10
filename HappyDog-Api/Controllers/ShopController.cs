using System;
using System.Collections.Generic;
using System.Linq;
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
    public class ShopController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public ShopController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ResultDto getDogs()
        {
            var dogs = _context.DogForSales.Where(x => x.UserAdditionalInfoId == null).Select(x => new DogForSaleDto
            {
                Id = x.Id,
                MainPhoto = x.MainPhoto,
                Age = x.Age,
                Breed = x.Breed,
                MyDescription = x.MyDescription,
                Info = x.Info,
                Name = x.Name,
                Price = x.Price,
                Photos = _context.Photos.Where(s => s.DogForSaleId == x.Id).Select(r => r.Path).ToList(),
                DogType = _context.DogTypes.Where(y => y.Id == x.DogTypeId).FirstOrDefault().Type
            }).ToList();

            return new CollectionResultDto<DogForSaleDto>()
            {
                IsSuccessful = true,
                Data = dogs
            };
        }

        [HttpGet("getDogsByBreed/{breed}")]
        public ResultDto getDogsByBreed([FromRoute]string breed)
        {
            if (breed == "") return getDogs();
            else
            {
                var dogs = _context.DogForSales.Where(x => x.UserAdditionalInfoId == null).Where(x => x.Breed.Contains(breed)).Select(x => new DogForSaleDto
                {
                    Id = x.Id,
                    MainPhoto = x.MainPhoto,
                        MyDescription = x.MyDescription,
                    Age = x.Age,
                    Breed = x.Breed,
                    Info = x.Info,
                    Name = x.Name,
                    Price = x.Price,
                    Photos = _context.Photos.Where(s => s.DogForSaleId == x.Id).Select(r => r.Path).ToList(),
                    DogType = _context.DogTypes.Where(y => y.Id == x.DogTypeId).FirstOrDefault().Type
                }).ToList();

                return new CollectionResultDto<DogForSaleDto>()
                {
                    IsSuccessful = true,
                    Data = dogs
                };
            }
        }

        [HttpPost("getFiltredDods")]
        public ResultDto getFiltredDods(FilterDto f)
        {
            var p = new List<DogForSaleDto>();

            if (f.type != "" && f.type != null)
            {
                if (f.max != 0)
                {
                    p = _context.DogForSales.Where(x => x.UserAdditionalInfoId == null).Where(x => x.DogType.Type == f.type).Where(x => x.Price >= f.min).Where(x => x.Price <= f.max).Select(x => new DogForSaleDto
                    {
                        Id = x.Id,
                        MainPhoto = x.MainPhoto,
                        Age = x.Age,
                        Breed = x.Breed,
                        Info = x.Info,
                        Name = x.Name,
                        Price = x.Price,
                        Photos = _context.Photos.Where(s => s.DogForSaleId == x.Id).Select(r => r.Path).ToList(),
                        DogType = _context.DogTypes.Where(y => y.Id == x.DogTypeId).FirstOrDefault().Type
                    }).ToList();
                }

                else
                {
                    p = _context.DogForSales.Where(x => x.UserAdditionalInfoId == null).Where(x => x.DogType.Type == f.type).Where(x => x.Price >= f.min).Select(x => new DogForSaleDto
                    {
                        Id = x.Id,
                        MainPhoto = x.MainPhoto,
                        Age = x.Age,
                        Breed = x.Breed,
                        Info = x.Info,
                        Name = x.Name,
                        MyDescription = x.MyDescription,
                        Price = x.Price,
                        Photos = _context.Photos.Where(s => s.DogForSaleId == x.Id).Select(r => r.Path).ToList(),
                        DogType = _context.DogTypes.Where(y => y.Id == x.DogTypeId).FirstOrDefault().Type
                    }).ToList();
                }
            }
            else if (f.max != 0)
            {
                p = _context.DogForSales.Where(x => x.UserAdditionalInfoId == null).Where(x => x.Price >= f.min).Where(x => x.Price <= f.max).Select(x => new DogForSaleDto
                {
                    Id = x.Id,
                    MainPhoto = x.MainPhoto,
                    Age = x.Age,
                    Breed = x.Breed,
                    Info = x.Info,
                    Name = x.Name,
                    Price = x.Price,
                    Photos = _context.Photos.Where(s => s.DogForSaleId == x.Id).Select(r => r.Path).ToList(),
                    DogType = _context.DogTypes.Where(y => y.Id == x.DogTypeId).FirstOrDefault().Type
                }).ToList();
            }

            return new CollectionResultDto<DogForSaleDto>()
            {
                IsSuccessful = true,
                Data = p
            };
        }

        [HttpPost("buy")]
        public ResultDto buy(BuyDto sd)
        {
            var p = _context.UserAdditionalInfo.Find(sd.id);
            p.Coins -= sd.price;
            var d = _context.DogForSales.Find(sd.idD);

            d.UserAdditionalInfoId = p.Id;

            string str = d.Info;
            string info = str.Split('.')[0];

            d.Info = info + ".";

            _context.SaveChanges();

            return new ResultDto
            {
                IsSuccessful = true,
                Message = ""
            };

        }

        [HttpPost("edit")]
        public ResultDto Edit(DogForSaleDto x)
        {
            var p = _context.DogForSales.Find(x.Id);

            p.Name = x.Name;
            p.Age = x.Age;
            p.Breed = x.Breed;
            //p.DogTypeId = _context.DogTypes.Where(y => y.Type == x.DogType).FirstOrDefault().Id;
            p.MyDescription = x.MyDescription;           

            _context.SaveChanges();

            return new ResultDto
            {
                IsSuccessful = true,
                Message = ""
            };

        }

        [HttpGet("getDogsById/{id}")]
        public ResultDto getDogsById([FromRoute]string id)
        {
            var dogs = _context.DogForSales.Where(x => x.UserAdditionalInfoId == id).Select(x => new DogForSaleDto
            {
                Id = x.Id,
                MainPhoto = x.MainPhoto,
                Age = x.Age,
                Breed = x.Breed,
                Info = x.Info,
                Name = x.Name,
                MyDescription = x.MyDescription,
                Price = x.Price,
                Photos = _context.Photos.Where(s => s.DogForSaleId == x.Id).Select(r => r.Path).ToList(),
                DogType = _context.DogTypes.Where(y => y.Id == x.DogTypeId).FirstOrDefault().Type
            }).ToList();

            return new CollectionResultDto<DogForSaleDto>()
            {
                IsSuccessful = true,
                Data = dogs
            };

        }

        [HttpGet("getDogById/{id}")]
        public ResultDto getDogById([FromRoute]int id)
        {
            var dog = _context.DogForSales.Where(x => x.Id == id).Select(x => new DogForSaleDto
            {
                Id = x.Id,
                MainPhoto = x.MainPhoto,
                Age = x.Age,
                Breed = x.Breed,
                Info = x.Info,
                Name = x.Name,
                MyDescription = x.MyDescription,
                Price = x.Price,
                Photos = _context.Photos.Where(s => s.DogForSaleId == x.Id).Select(r => r.Path).ToList(),
                DogType = _context.DogTypes.Where(y => y.Id == x.DogTypeId).FirstOrDefault().Type
            }).FirstOrDefault();

            return new SingleResultDto<DogForSaleDto>()
            {
                IsSuccessful = true,
                Data = dog
            };

        }
    }
}