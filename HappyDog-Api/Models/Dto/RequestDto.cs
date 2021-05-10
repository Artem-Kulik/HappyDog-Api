using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyDog_Api.Models.Entities
{
    public class RequestDto
    {
        public int Id { get; set; }
        public string Breed { get; set; }
        public string MainPhoto { get; set; }
        public string BreedType { get; set; }
        public string Age { get; set; }
        public int Price { get; set; }
        public string Info { get; set; }
    }
}
