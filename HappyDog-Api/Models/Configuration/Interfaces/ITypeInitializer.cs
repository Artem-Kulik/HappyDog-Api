using HappyDog_Api.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyDog_Api.Models.Configuration.Interfaces
{
    public interface ITypeInitializer
    {
        Task Init(ApplicationContext context);
    }
}
