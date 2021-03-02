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
        public string Url { get; set; }
        public IFormFile File { get; set; }
        public string Description { get; set; }
        public DateTime ImageDate { get; set; }
        public string PublicId { get; set; }
    }
}
