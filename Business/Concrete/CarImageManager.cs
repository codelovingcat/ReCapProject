using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        private ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        public IResult Add(CarImage carImage)
        {
            IResult result = BusinessRules.Run(CheckIfCarImageLimitExceded(carImage.CarId));

            if (result != null)
            {
                return result;
            }

            carImage.ImageDate = DateTime.Now;
            _carImageDal.Add(carImage);
            return new SuccessResult(Messages.CarImageAdded);


        }

        public IResult Delete(CarImage carImage)
        {
            _carImageDal.Delete(carImage);
            return new SuccessResult(Messages.CarImageDeleted);
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(), Messages.CarImageListed);
        }

        public IDataResult<List<CarImage>> GetCarImageByCarId(int carId)
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(image => image.CarId == carId));
        }

        public IResult Update(CarImage carImage)
        {
            _carImageDal.Update(carImage);
            return new SuccessResult(Messages.CarImageUpdated);
        }

        private IResult CheckIfCarImageLimitExceded(int carImageId)
        {
            var result = _carImageDal.GetAll(c=>c.CarId== carImageId);
            if (result.Count > 5)
            {
                return new ErrorResult(Messages.CheckIfCarImageLimitExceded);
            }
            return new SuccessResult();
        }

        private IResult CheckIfCarImageNullImage(int carId)
        {
            var result = _carImageDal.GetAll(c => c.CarId == carId).Any();
            if (result)
            {
                string path = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).FullName + @"\Dosyalar\logo.png");
                //var yol = _carImageDal.GetAll(c => c.ImagePath == path);
            }
            return new SuccessResult();
        }
    }
}
