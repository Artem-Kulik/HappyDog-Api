using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyDog_Api.Models.Dto
{
    public class ThesisDto
    {
        public int Id { get; set; }
        public int BreedId { get; set; }
        public string Thesis { get; set; }
    }
}
