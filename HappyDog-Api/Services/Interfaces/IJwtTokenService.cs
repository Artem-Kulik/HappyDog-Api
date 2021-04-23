﻿using HappyDog_Api.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyDog_Api.Services.Interfaces
{
    public interface IJwtTokenService
    {
        string CreateToken(User user);
    }
}
