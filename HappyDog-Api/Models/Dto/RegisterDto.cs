using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyDog_Api.Models.Dto
{
    public class RegisterDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
    }
}
