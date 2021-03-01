using Core;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class PhotoForCreationDto : IDto
    {
        public PhotoForCreationDto()
        {
            ImageDate = DateTime.Now;
        }
        public int Id { get; set; }
        public string CarName { get; set; }
        public string ImagePath { get; set; }
        public IFormFile File { get; set; }
        public DateTime ImageDate { get; set; }
    }
}
