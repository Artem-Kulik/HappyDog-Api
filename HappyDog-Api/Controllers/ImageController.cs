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

        [HttpPost("AddMyDogImage/{id}")]
        public ResultDto AddMyDogImage([FromRoute] string id, [FromForm(Name = "file")] IFormFile uploadedImage)
        {
            string fileName = Guid.NewGuid().ToString() + ".jpg";
            string path = _appEnvironment.WebRootPath + @"\SaleImages";

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
                    var saveImage = ImageWorker.CreateImage(bmp, 500, 850);
                    if (saveImage != null)
                    {
                        saveImage.Save(path, ImageFormat.Jpeg);

                        Photo p = new Photo()
                        {
                            DogForSaleId = Convert.ToInt32(id),
                            Path = "/SaleImages/" + fileName
                        };

                        // var thing = _context.Things.Where(x => x.Id.ToString() == id).FirstOrDefault();
                        //if (thing.Image != null && thing.Image != "default.jpg")
                        //{
                        //    System.IO.File.Delete(_appEnvironment.WebRootPath + @"\Image\" + thing.Image);
                        //}

                        _context.Photos.Add(p);
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
                
        [HttpPost("EditBreedMainPhoto/{id}")]
        public ResultDto EditBreedMainPhoto([FromRoute] string id, [FromForm(Name = "file")] IFormFile uploadedImage)
        {
            string fileName = Guid.NewGuid().ToString() + ".jpg";
            string path = _appEnvironment.WebRootPath + @"\BreedImages";

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
                    var saveImage = ImageWorker.CreateImage(bmp, 310, 310);
                    if (saveImage != null)
                    {
                        saveImage.Save(path, ImageFormat.Jpeg);

                        var breed = _context.DogInfos.Find(Convert.ToInt32(id));

                        // var thing = _context.Things.Where(x => x.Id.ToString() == id).FirstOrDefault();
                        //if (breed.MainPhoto != null && breed.MainPhoto != "default.jpg")
                        //{
                        //    System.IO.File.Delete(_appEnvironment.WebRootPath + @"\BreedImages\" + breed.MainPhoto);
                        //}

                        breed.MainPhoto = "/BreedImages/" + fileName;

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

        [HttpPost("EditBreedBigPhoto/{id}")]
        public ResultDto EditBreedBigPhoto([FromRoute] string id, [FromForm(Name = "file")] IFormFile uploadedImage)
        {
            string fileName = Guid.NewGuid().ToString() + ".jpg";
            string path = _appEnvironment.WebRootPath + @"\BreedImages";

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
                    var saveImage = ImageWorker.CreateImage(bmp, 950, 625);
                    if (saveImage != null)
                    {
                        saveImage.Save(path, ImageFormat.Jpeg);

                        var breed = _context.DogInfos.Find(Convert.ToInt32(id));

                        // var thing = _context.Things.Where(x => x.Id.ToString() == id).FirstOrDefault();
                        //if (breed.BigPhoto != null && breed.BigPhoto != "default.jpg")
                        //{
                        //    System.IO.File.Delete(_appEnvironment.WebRootPath + @"\BreedImages\" + breed.BigPhoto);
                        //}

                        breed.BigPhoto = "/BreedImages/" + fileName;

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
        
        [HttpPost("AddMyPhoto/{id}")]
        public ResultDto AddMyPhoto([FromRoute] string id, [FromForm(Name = "file")] IFormFile uploadedImage)
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
                    var saveImage = ImageWorker.CreateImage(bmp, 950, 625);
                    if (saveImage != null)
                    {
                        saveImage.Save(path, ImageFormat.Jpeg);

                        var me = _context.UserAdditionalInfo.Find(id);

                        // var thing = _context.Things.Where(x => x.Id.ToString() == id).FirstOrDefault();
                        //if (breed.BigPhoto != null && breed.BigPhoto != "default.jpg")
                        //{
                        //    System.IO.File.Delete(_appEnvironment.WebRootPath + @"\BreedImages\" + breed.BigPhoto);
                        //}

                        me.Photo = "/Images/" + fileName;

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

        [HttpPost("UploadSalePhoto/{id}")]
        public ResultDto UploadSalePhoto([FromRoute] string id, [FromForm(Name = "file")] IFormFile uploadedImage)
        {
            string fileName = Guid.NewGuid().ToString() + ".jpg";
            string path = _appEnvironment.WebRootPath + @"\SaleImages";

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
                Request r = new Request()
                {
                    Age = "",
                    Breed = "",
                    BreedType = "",
                    Info = "",
                    Price = 0
                };
                using (Bitmap bmp = new Bitmap(uploadedImage.OpenReadStream()))
                {
                    var saveImage = ImageWorker.CreateImage(bmp, 500, 850);
                    if (saveImage != null)
                    {
                        saveImage.Save(path, ImageFormat.Jpeg);

                        r.MainPhoto = "/SaleImages/" + fileName;

                        // var thing = _context.Things.Where(x => x.Id.ToString() == id).FirstOrDefault();
                        //if (thing.Image != null && thing.Image != "default.jpg")
                        //{
                        //    System.IO.File.Delete(_appEnvironment.WebRootPath + @"\Image\" + thing.Image);
                        //}
                        _context.Requests.Add(r);
                        _context.SaveChanges();
                    }
                }
                return new ResultDto
                {
                    IsSuccessful = true,
                    Message = r.Id.ToString()
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
             
        [HttpPost("UploadSaleMainPhoto/{id}")]
        public ResultDto UploadSaleMainPhoto([FromRoute] string id, [FromForm(Name = "file")] IFormFile uploadedImage)
        {
            string fileName = Guid.NewGuid().ToString() + ".jpg";
            string path = _appEnvironment.WebRootPath + @"\SaleImages";

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
                    var saveImage = ImageWorker.CreateImage(bmp, 500, 850);
                    if (saveImage != null)
                    {
                        saveImage.Save(path, ImageFormat.Jpeg);

                        var s = _context.DogForSales.Find(Convert.ToInt32(id));
                        s.MainPhoto = "/SaleImages/" + fileName;

                        // var thing = _context.Things.Where(x => x.Id.ToString() == id).FirstOrDefault();
                        //if (thing.Image != null && thing.Image != "default.jpg")
                        //{
                        //    System.IO.File.Delete(_appEnvironment.WebRootPath + @"\Image\" + thing.Image);
                        //}
                        _context.SaveChanges();

                        Photo p = new Photo
                        {
                            Path = s.MainPhoto,
                            DogForSaleId = s.Id
                        };

                        _context.SaveChanges();
                    }
                }
                return new ResultDto
                {
                    IsSuccessful = true
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