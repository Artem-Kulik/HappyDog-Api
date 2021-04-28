using System;
using System.Linq;
using HappyDog_Api.Models.Dto.ResultDto;
using HappyDog_Api.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using HappyDog_Api.Helpers;

namespace HappyDog_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private readonly IWebHostEnvironment _appEnvironment;
        private readonly ApplicationContext _context;

        public ImageController(IWebHostEnvironment appEnvironment,
            ApplicationContext context)
        {
            _appEnvironment = appEnvironment;
            _context = context;
        }

        [HttpPost("UploadThingImage/(id)")]
        public ResultDto UploadThingImage([FromRoute] string id, [FromForm(Name = "file")] IFormFile uploadedImage)
        {
            string fileName = Guid.NewGuid().ToString() + ".jpg";
            string path = _appEnvironment.WebRootPath + @"\Images";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            path = path + @"\" + fileName;
            if (uploadedImage == null)
                return new ResultDto
                {
                    IsSuccessful = false,
                    Message = "Error"
                };
            if (uploadedImage.Length == 0)
                return new ResultDto
                {
                    IsSuccessful = false,
                    Message = "Empty"
                };
            try
            {
                using (Bitmap bmp = new Bitmap(uploadedImage.OpenReadStream()))
                {
                    var saveImage = ImageWorker.CreateImage(bmp, 200, 125);
                    if (saveImage != null)
                    {
                        saveImage.Save(path, ImageFormat.Jpeg);
                       // var thing = _context.Things.Where(x => x.Id.ToString() == id).FirstOrDefault();

                        //if (thing.Image != null && thing.Image != "default.jpg")
                        //{
                        //    System.IO.File.Delete(_appEnvironment.WebRootPath + @"\Image\" + thing.Image);
                        //}

                        //_context.Things.Find(id).Image = fileName;
                        _context.SaveChanges();
                    }
                }
                return new ResultDto
                {
                    IsSuccessful = true,
                    Message = "Ok"
                };
            }
            catch (Exception ex)
            {
                return new ResultDto
                {
                    IsSuccessful = false,
                    Message = ex.Message
                };
            }

        }
    }
}