using Business.Abstract;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Core.Utilities.Business;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        private ICarImageService _carImageService;
        private IWebHostEnvironment _webHostEnvironment;

        public CarImagesController(ICarImageService carImageService, IWebHostEnvironment webHostEnvironment)
        {
            _carImageService = carImageService;
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpPost("add")]
        public IActionResult AddAsync( CarImage carImage)
        {
            var result = _carImageService.Add(carImage);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }



        //[HttpPost("ekle")]
        //public string Post([FromForm] FileUpload file)
        //{
        //    try
        //    {
        //        if (file..Length > 0)
        //        {
        //            string path = _webHostEnvironment.WebRootPath + "\\uploads\\";
        //            if (!Directory.Exists(path))
        //            {
        //                Directory.CreateDirectory(path);
        //            }
        //            using (FileStream fileStream = System.IO.File.Create(path + Guid.NewGuid().ToString() + file.file.FileName))
        //            {
        //                file.file.CopyTo(fileStream);
        //                fileStream.Flush();
        //                return "Uploaded";
        //            }
        //        }
        //        else
        //        {
        //            return "Uploaded Not.";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return ex.Message;
        //    }
        //}




        [HttpPost("ek")]
        public IActionResult Add( IFormFile file)
        {
            if (ModelState.IsValid)
            {
                //var entity = new CarImage()
                //{
                //    Id= model.Id,
                //    CarId = model.CarId,
                //    ImageDate =model.ImageDate
                //};

                if (file != null)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", file.FileName);
                    //entity.ImagePath = file.FileName;
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }

                }
               // var result = _carImageService.Add(entity);
               
               // return Ok(result.Message);
            }
            return BadRequest();





            //List<IResult> results = new List<IResult>();
            //var result = _carImageService.Add(carImage);
            //if (result.Success)
            //{
            //    if (file.file.Length > 0 && file.file. )
            //    {
            //        string path = _webHostEnvironment.WebRootPath + "\\uploads\\";
                    
            //        if (!Directory.Exists(path))
            //        {
            //            Directory.CreateDirectory(path);
            //        }
            //        using (FileStream fileStream = System.IO.File.Create(path + Guid.NewGuid().ToString() + file.file.FileName))
            //        {
            //            file.file.CopyTo(fileStream);
            //            fileStream.Flush();
            //            return Ok(result.Message);
            //        }
            //        results.Add(_carImageService.Add(new CarImage()
            //        {
            //            ImagePath = path,
            //            Id = carImage.Id
            //        }));
            //    }
               
            //}
            

        }



        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carImageService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
    }
}


