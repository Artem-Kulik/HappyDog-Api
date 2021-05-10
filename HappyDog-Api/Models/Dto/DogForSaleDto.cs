using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyDog_Api.Models.Dto
{
    public class DogForSaleDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public string MainPhoto { get; set; }
        public string Age { get; set; }
        public int Price { get; set; }
        public string Info { get; set; }
        public string MyDescription { get; set; }
        public string DogType { get; set; }
        public List<string> Photos { get; set; }
    }
}
