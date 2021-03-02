using Core.Entities;
using Core.Entities.Concrete;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class City : IEntity
    {
        public City()
        {
            Photos = new List<Photo>();
        }
        public int Id { get; set; }
        public int AdminId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Photo> Photos { get; set; }
        public Admin Admin { get; set; }
    }
}
