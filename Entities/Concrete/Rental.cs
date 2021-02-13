using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    /// <summary>
    /// RentDate(Kiralama Tarihi), ReturnDate(Teslim Tarihi).
    /// </summary>
    public class Rental : IEntity
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int UserId { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
