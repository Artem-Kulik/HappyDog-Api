using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyDog_Api.Models.Entities
{
    public class BreedPhoto
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public int DogInfoId { get; set; }

        public virtual DogInfo DogInfo { get; set; }
    }
}
