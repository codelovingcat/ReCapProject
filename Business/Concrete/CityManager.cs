using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CityManager : ICityService
    {
        private ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public IResult Add(City city)
        {
            _cityDal.Add(city);
            return new SuccessResult(Messages.CityAdded);
        }

        public IResult Delete(City city)
        {
            _cityDal.Delete(city);
            return new SuccessResult(Messages.CityDeleted);
        }

        public IDataResult<List<City>> GetAll()
        {
            return new SuccessDataResult<List<City>>(_cityDal.GetAll(), Messages.CityListed);
        }

        public IDataResult<City> GetCityById(int cityId)
        {
            return new SuccessDataResult<City>(_cityDal.Get(c => c.Id == cityId));
        }

        public IDataResult<List<CityForListDto>> GetCityDetails()
        {
            return new SuccessDataResult<List<CityForListDto>>(_cityDal.GetCityDetails());
        }

        public IResult Update(City city)
        {
            _cityDal.Update(city);
            return new SuccessResult(Messages.CityUpdated);
        }
    }
}
