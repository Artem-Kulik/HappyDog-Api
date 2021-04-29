using HappyDog_Api.Models.Dto;
using HappyDog_Api.Models.Dto.ResultDto;
using HappyDog_Api.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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

        [HttpGet ("{id}")]
        public ResultDto getInfo([FromRoute]string id)
        {
            UserInfoDto user = new UserInfoDto();

            var u = _context.Users.Find(id);
            var ua = _context.UserAdditionalInfo.Find(id);

            user.PhoneNumber = u.PhoneNumber;
            user.Email = u.Email;
            user.Photo = ua.Photo;
            user.Name = ua.Name;
            user.City = ua.City;

            Thread.Sleep(100);
            user.Coins = ua.Coins;
            return new SingleResultDto<UserInfoDto>()
            {
                IsSuccessful = true,
                Data = user
            };
        }


    }
}
