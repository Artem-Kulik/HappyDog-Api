using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HappyDog_Api.Models.Dto;
using HappyDog_Api.Models.Dto.ResultDto;
using HappyDog_Api.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HappyDog_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BreedGameController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public BreedGameController(ApplicationContext context)
        {
            _context = context;
        }

        static List<int> exept = new List<int>();
        static int WonInARow = 1;
        static int Prise = 100;

        [HttpGet]
        public ResultDto RandomBreed()
        {
            var arr = _context.BreedGames.Select(x => new BreedGameDto()
            {
                Id = x.Id,
                FirstAnswer = x.FirstAnswer,
                SecondAnswer = x.SecondAnswer,
                ThirdAnswer = x.ThirdAnswer,
                RightAnswer = x.RightAnswer,
                BreedImage = x.BreedImage,
                Prise = Prise,
                Win = WonInARow
            }).ToArray();

        start:
            Random rnd = new Random();
            int random = rnd.Next(0, arr.Length);

            BreedGameDto send = new BreedGameDto();

            if (!exept.Contains(random))
            {
                exept.Add(random);
                send = arr[random];
            }
            else goto start;

            if (exept.Count == arr.Length)
            {
                exept.Clear();
            }

            return new SingleResultDto<BreedGameDto>
            {
                IsSuccessful = true,
                Data = send
            };
        }

        [HttpPost]
        public ResultDto AnswerResult(AnswerResultDto result)
        {
            if (result.res == true) {
                WonInARow++;
                Prise += 100;
            }
            if (result.res == false)
            {
                WonInARow = 1;
                //var c = _context.UserAdditionalInfo.Find(result.id).Coins;
                //if (c - m >= 0) c -= Prise;
                //else c = 0;
                Prise = 100;
            }

            return new ResultDto
            {
                IsSuccessful = true
            };

        }
    }
}