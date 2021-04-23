using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyDog_Api.Models.Entities
{
    public class BaseDogInfo
    {
        public int Id { get; set; }
        public string Breed { get; set; }
        public string Country { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public string LifeSpan { get; set; }
        public int DogInfoId { get; set; }

        public virtual DogInfo DogInfo { get; set; }
    }
}
