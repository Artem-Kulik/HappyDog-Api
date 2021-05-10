using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyDog_Api.Models.Entities
{
    public class Photo
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public int? DogForSaleId { get; set; }

        public virtual DogForSale DogForSale { get; set; }
    }
}
