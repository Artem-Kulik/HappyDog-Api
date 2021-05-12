using HappyDog_Api.Models.Dto;
using HappyDog_Api.Models.Dto.ResultDto;
using HappyDog_Api.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

namespace HappyDog_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public UserController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public ResultDto getInfo([FromRoute]string id)
        {
            UserInfoDto user = new UserInfoDto();

            var u = _context.Users.Find(id);
            var ua = _context.UserAdditionalInfo.Find(id);

            if (u != null)
            {
                user.PhoneNumber = u.PhoneNumber;
                user.Email = u.Email;
                user.Photo = ua.Photo;
                user.Name = ua.Name;
                user.City = ua.City;
                user.Id = u.Id;
                user.Coins = ua.Coins;
                return new SingleResultDto<UserInfoDto>()
                {
                    IsSuccessful = true,
                    Data = user
                };
            }
            else return new SingleResultDto<UserInfoDto>()
            {
                IsSuccessful = false,
                Data = new UserInfoDto()
            };
        }

        [HttpPost]
        public ResultDto editInfo(UserInfoDto newUser)
        {
            var user = _context.Users.Where(x => x.Id == newUser.Id).FirstOrDefault();
            var userAd = _context.UserAdditionalInfo.Where(x => x.Id == newUser.Id).FirstOrDefault();

            user.Email = newUser.Email;
            user.UserName = newUser.Email;
            user.NormalizedUserName = newUser.Email.Normalize();
            user.NormalizedEmail = newUser.Email.Normalize();
            userAd.Name = newUser.Name;
            userAd.Photo = newUser.Photo;
            user.PhoneNumber = newUser.PhoneNumber;
            userAd.City = newUser.City;

            _context.SaveChanges();
            return new ResultDto()
            {
                IsSuccessful = true,
            };
        }
                

        [HttpPost("sendRequest")]
        public ResultDto sendRequest(DogForSaleDto d)
        {
            var r = _context.Requests.Find(d.Id);

            r.Info = d.Info;
            r.Breed = d.Breed;
            r.BreedType = d.DogType;
            r.Age = d.Age;
            r.Price = d.Price;
            
            _context.SaveChanges();
            return new ResultDto()
            {
                IsSuccessful = true,
            };
        }
    }
}
