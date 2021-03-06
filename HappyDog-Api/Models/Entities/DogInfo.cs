using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyDog_Api.Models.Entities
{
    public class DogInfo
    {
        public int Id { get; set; }

        public string MainPhoto { get; set; }
        public string MainDescription { get; set; }

        public string BigPhoto { get; set; }
        public string BigDescription { get; set; }

        public string Breed { get; set; }
        public string Country { get; set; }
        public string Weight { get; set; }
        public string Height { get; set; }
        public string Price { get; set; }
        public string LifeExpectancy { get; set; }

        public int Aggressiveness { get; set; }
        public int Molting { get; set; }
        public int Intelligence { get; set; }
        public int Activity { get; set; }
        public int MaintenanceCost { get; set; }
        public int Noise { get; set; }
        public int Training { get; set; }
        public int Health { get; set; }
        public int SecurityQualities { get; set; }

        public int? DogTypeId { get; set; }

        public virtual DogType DogType { get; set; }
        public ICollection<Thesis> Theses { get; set; }
        public ICollection<BreedPhoto> BreedPhotos { get; set; }
    }
}
