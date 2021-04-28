using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyDog_Api.Models.Entities
{
    public class BreedGame
    {
        public int Id { get; set; }

        public string BreedImage { get; set; }

        public string FirstAnswer { get; set; }
        public string SecondAnswer { get; set; }
        public string ThirdAnswer { get; set; }
        public string RightAnswer { get; set; }
    }
}
