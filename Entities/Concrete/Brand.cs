using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class Brand :IEntity
    {
        public int Id { get; set; }

        [StringLength(2, ErrorMessage = "Aracın adı en fazla 2 karakter olabilir.")]
        public string Name { get; set; }
    }
}
