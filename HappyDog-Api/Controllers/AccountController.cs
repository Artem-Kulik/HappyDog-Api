using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HappyDog_Api.Models.Dto;
using HappyDog_Api.Models.Dto.ResultDto;
using HappyDog_Api.Models.Entities;
using HappyDog_Api.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HappyDog_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly ApplicationContext _context;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IJwtTokenService _jwtTokenService;
        public AccountController(
                ApplicationContext context,
                UserManager<User> userManager,
                SignInManager<User> signInManager,
                IJwtTokenService jwtTokenService)
        {
            _userManager = userManager;
            _context = context;
            _signInManager = signInManager;
            _jwtTokenService = jwtTokenService;
        }
        [HttpGet]
        public ResultDto ok()
        {
            return new ResultDto
            {
                IsSuccessful = true
            };
        }
        
        [HttpPost("register")]
        public async Task<ResultDto> Register([FromBody] RegisterDto model)
        {
            if (model.Name == null || model.Name == "") {
                return new ResultDto
                {
                    IsSuccessful = false
                };
            }
            if (model.Email == null || model.Email == "")
            {
                return new ResultDto
                {
                    IsSuccessful = false
                };
            }
            User user = new User()
            {
                Email = model.Email,
                UserName = model.Email,
                PhoneNumber = "+380000000000"
            };
            await _userManager.CreateAsync(user, model.Password);

            UserAdditionalInfo ui = new UserAdditionalInfo()
            {
                Id = user.Id,
                Name = model.Name,
                Photo = "/Images/default.jpg",
                Coins = 0,      
                City = "City"
            };

            var result = _userManager.AddToRoleAsync(user, "Guest").Result;
            await _context.UserAdditionalInfo.AddAsync(ui);
            await _context.SaveChangesAsync();

            return new ResultDto
            { 
                IsSuccessful = true
            };
        }

        [HttpPost("login")]
        public async Task<ResultDto> Login(LoginDto model)
        {
            try
            {
                var res = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);
                if (!res.Succeeded)
                {
                    return new ResultDto
                    {
                        IsSuccessful = false
                    };
                }
                var user = await _userManager.FindByEmailAsync(model.Email);
                await _signInManager.SignInAsync(user, isPersistent: false);


                var id = _context.Users.Where(el => el.Email == model.Email).FirstOrDefault().Id;

                try
                {
                    string t = _jwtTokenService.CreateToken(user);
                    return new ResultLoginDto
                    {
                        IsSuccessful = true,
                        Token = t,
                        Message = id
                    };
                }
                catch (Exception ex) {
                    return new ResultLoginDto
                    {
                        IsSuccessful = true,
                        Message = "Admin"
                    };
                }
            }
            catch (Exception ex)
            {
                return new ResultDto
                {
                    IsSuccessful = false,
                    Message = ex.Message
                };
            }
        }
    }
}
