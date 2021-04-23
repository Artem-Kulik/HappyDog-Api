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

        public int BaseDogInfoId { get; set; }
        public int DogSizeId { get; set; }
        public int DogCharacteristicId { get; set; }

        public virtual BaseDogInfo BaseDogInfo { get; set; }
        public virtual DogSize DogSize { get; set; }
        public virtual DogCharacteristic DogCharacteristic { get; set; }
        public ICollection<Thesis> Theses { get; set; }
        public ICollection<BreedPhoto> BreedPhotos { get; set; }
    }
}
