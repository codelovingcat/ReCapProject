using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCityDal : EfEntityRepositoryBase<City, ReCapProjectContext>, ICityDal
    {
        //public List<CityForListDto> GetCityDetails()
        //{
        //    using (ReCapProjectContext context = new ReCapProjectContext())
        //    {
        //        var result = from c in context.Cities
        //                     join p in context.Photos on c.. equals brand.Id
        //                     join color in context.Colors on car.ColorId equals color.Id
        //                     select new CarDetailDto
        //                     { CarId = car.Id, CarName = car.Description, BrandName = brand.Name, ColorName = color.Name, DailyPrice = car.DailyPrice };
        //        return result.ToList();
        //    }
        //}
        public List<CityForListDto> GetCityDetails()
        {
            throw new NotImplementedException();
        }
    }

}