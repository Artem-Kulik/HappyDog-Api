using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyDog_Api.Models.Entities
{
    public class DogForSale
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public string MainPhoto { get; set; }
        public string Age { get; set; }
        public int Price { get; set; }
        public string Info { get; set; }
        public string MyDescription { get; set; }
        public string UserAdditionalInfoId { get; set; }
        public int? DogTypeId { get; set; }

        public virtual DogType DogType { get; set; }
        public virtual UserAdditionalInfo User { get; set; }
        public ICollection<Photo> Photos { get; set; }
    }
}
