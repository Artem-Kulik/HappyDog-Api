using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyDog_Api.Models.Entities
{
    public class DogType
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public virtual IEnumerable<DogInfo> DogInfos { get; set; }
    }
}
