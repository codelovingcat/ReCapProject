using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PhotoManager : IPhotoService
    {
        private IPhotoDal _photoDal;

        public PhotoManager(IPhotoDal photoDal)
        {
            _photoDal = photoDal;
        }

        public IResult Add(Photo photo)
        {
            _photoDal.Add(photo);
            return new SuccessResult(Messages.PhotoAdded);
        }

        public IResult Delete(Photo photo)
        {
            _photoDal.Add(photo);
            return new SuccessResult(Messages.PhotoDeleted);
        }

        public IDataResult<List<Photo>> GetAll()
        {
            return new SuccessDataResult<List<Photo>>(_photoDal.GetAll(), Messages.PhotoListed);
        }

        public IDataResult<Photo> GetPhotoByCity(int cityid)
        {
            return new SuccessDataResult<Photo>(_photoDal.Get(p =>p.CityId == cityid));
        }

        public IDataResult<Photo> GetPhotoById(int photoId)
        {
            return new SuccessDataResult<Photo>(_photoDal.Get(p => p.Id == photoId));
        }

        public IResult Update(Photo photo)
        {
            _photoDal.Add(photo);
            return new SuccessResult(Messages.PhotoUpdated);
        }
    }
}
