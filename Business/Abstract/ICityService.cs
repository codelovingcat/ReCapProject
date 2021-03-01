using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICityService
    {
        IDataResult<List<City>> GetAll();
        IDataResult<City> GetCityById(int cityId); 
        IDataResult<List<CityForListDto>>GetCityDetails();
        IResult Add(City city);
        IResult Delete(City city);
        IResult Update(City city);
    }
}
