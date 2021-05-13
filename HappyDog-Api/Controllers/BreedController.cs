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
    public class BreedController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public BreedController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ResultDto getBreeds()
        {
            var breeds = _context.DogInfos.Select(x => new DogInfoDto
            {
                Id = x.Id,
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

                DogType = _context.DogTypes.Where(y => y.Id == x.DogTypeId).FirstOrDefault().Type
            }).ToList();

            return new CollectionResultDto<DogInfoDto>()
            {
                IsSuccessful = true,
                Data = breeds
            };

        }

        [HttpGet]
        [Route("getBreedsSBBreed")]
        public ResultDto getBreedsSBBreed()
        {
            var breeds = _context.DogInfos.Select(x => new DogInfoDto
            {
                Id = x.Id,
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

                DogType = _context.DogTypes.Where(y => y.Id == x.DogTypeId).FirstOrDefault().Type
            }).ToList();

            return new CollectionResultDto<DogInfoDto>()
            {
                IsSuccessful = true,
                Data = breeds.OrderBy(x => x.Breed).ToList()
            };

        }
        [HttpGet]
        [Route("getBreedsSBType")]
        public ResultDto getBreedsSBType()
        {
            var breeds = _context.DogInfos.Select(x => new DogInfoDto
            {
                Id = x.Id,
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

                DogType = _context.DogTypes.Where(y => y.Id == x.DogTypeId).FirstOrDefault().Type
            }).ToList();

            return new CollectionResultDto<DogInfoDto>()
            {
                IsSuccessful = true,
                Data = breeds.OrderBy(x => x.DogType).ToList()
            };

        }
        [HttpGet]
        [Route("getBreedsSBHeight")]
        public ResultDto getBreedsSBHeight()
        {
            var breeds = _context.DogInfos.Select(x => new DogInfoDto
            {
                Id = x.Id,
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

                DogType = _context.DogTypes.Where(y => y.Id == x.DogTypeId).FirstOrDefault().Type
            }).ToList();

            return new CollectionResultDto<DogInfoDto>()
            {
                IsSuccessful = true,
                Data = breeds.OrderBy(x => x.Height).ToList()
            };

        }
        [HttpGet]
        [Route("getBreedsSBWeidht")]
        public ResultDto getBreedsSBWeidht()
        {
            var breeds = _context.DogInfos.Select(x => new DogInfoDto
            {
                Id = x.Id,
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

                DogType = _context.DogTypes.Where(y => y.Id == x.DogTypeId).FirstOrDefault().Type
            }).ToList();

            return new CollectionResultDto<DogInfoDto>()
            {
                IsSuccessful = true,
                Data = breeds.OrderBy(x => x.Weight).ToList()
            };

        }
        [HttpGet]
        [Route("getBreedsSBCountry")]
        public ResultDto getBreedsSBCountry()
        {
            var breeds = _context.DogInfos.Select(x => new DogInfoDto
            {
                Id = x.Id,
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

                DogType = _context.DogTypes.Where(y => y.Id == x.DogTypeId).FirstOrDefault().Type
            }).ToList();

            return new CollectionResultDto<DogInfoDto>()
            {
                IsSuccessful = true,
                Data = breeds.OrderBy(x => x.Country).ToList()
            };

        }


        [HttpGet("{type}")]
        public ResultDto getInfo([FromRoute]string type)
        {
            var breeds = _context.DogInfos.Select(x => new DogInfoDto
            {
                Id = x.Id,
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

                DogType = _context.DogTypes.Where(y=> y.Id == x.DogTypeId).FirstOrDefault().Type
            }).ToList();
            if (type != "All")
            {
                return new CollectionResultDto<DogInfoDto>()
                {
                    IsSuccessful = true,
                    Data = breeds.Where(x => x.DogType == type).ToList()
                };
            }
            else {
                return new CollectionResultDto<DogInfoDto>()
                {
                    IsSuccessful = true,
                    Data = breeds
                };
            }
        }

        [HttpGet]
        [Route("getBreed/{id}")]
        public ResultDto getBreed([FromRoute]int id)
        {
            var x = _context.DogInfos.Find(id);

            DogInfoDto breed = new DogInfoDto()
            {
                Id = x.Id,
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

                DogType = _context.DogTypes.Where(y => y.Id == x.DogTypeId).FirstOrDefault().Type
            };

            return new SingleResultDto<DogInfoDto>()
            {
                IsSuccessful = true,
                Data = breed
            };
        }

        [HttpGet]
        [Route("getTheses/{id}")]
        public ResultDto getTheses([FromRoute]int id)
        {
            var theses = _context.Theses.Where(x => x.DogInfoId == id).Select(x => new ThesisDto
            {
                Id = x.Id,
                BreedId = id,
                Thesis = x.Info
            }).ToList();

            return new CollectionResultDto<ThesisDto>()
            {
                IsSuccessful = true,
                Data = theses
            };
        }
    }
}