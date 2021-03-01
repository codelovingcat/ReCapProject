using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class Photo : IEntity
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsMain { get; set; }
        public string PublicId { get; set; }

        public City City { get; set; }

    }
}
