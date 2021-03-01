using Core.Entities;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Admin : IEntity
    {
        public Admin()
        {
            Cities = new List<City>();
        }
        public int Id { get; set; }
        public string AdminName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public List<City> Cities { get; set; }
    }
}
