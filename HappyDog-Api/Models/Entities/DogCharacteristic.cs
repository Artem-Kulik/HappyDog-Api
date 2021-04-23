using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyDog_Api.Models.Entities
{
    public class DogCharacteristic
    {
        public int Id { get; set; }
        public int Aggressiveness { get; set; }
        public int Molting { get; set; }
        public int Intelligence { get; set; }
        public int Activity { get; set; }
        public int MaintenanceCost { get; set; }
        public int Noise { get; set; }
        public int Training { get; set; }
        public int Health { get; set; }
        public int ExcellentQuality { get; set; }
        public int DogInfoId { get; set; }

        public virtual DogInfo DogInfo { get; set; }
    }
}




