using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyDog_Api.Models.Dto.ResultDto
{
    public class SingleResultDto<T> : ResultDto
    {
        public T Data { get; set; }
    }
}
