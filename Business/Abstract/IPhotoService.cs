using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IPhotoService
    {
        IDataResult<List<Photo>> GetAll();
        IDataResult<Photo> GetPhotoById(int photoId);
        IDataResult<Photo> GetPhotoByCity(int cityid);
        IResult Add(Photo photo);
        IResult Delete(Photo photo);
        IResult Update(Photo photo);
    }
}
