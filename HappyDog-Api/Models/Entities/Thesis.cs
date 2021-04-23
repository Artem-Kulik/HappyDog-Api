using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyDog_Api.Models.Entities
{
    public class Thesis
    {
        public int Id { get; set; }
        public string Info { get; set; }
        public int DogInfoId { get; set; }

        public virtual DogInfo DogInfo { get; set; }
    }
}
