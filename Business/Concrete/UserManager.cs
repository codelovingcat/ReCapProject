using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public User GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }

        //[ValidationAspect(typeof(UserValidator))]
        //[CacheRemoveAspect("IUserService.Get")]
        //public IResult Add(User user)
        //{
        //    _userDal.Add(user);
        //    return new SuccessResult(Messages.UserAdded);
        //}

        //public IResult Delete(User user)
        //{
        //    _userDal.Delete(user);
        //    return new SuccessResult(Messages.UserDeleted);
        //}

        //public IDataResult<List<User>> GetAll()
        //{
        //    return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.UsersListed);
        //}

        //public IDataResult<User> GetById(int userId)
        //{
        //    return new SuccessDataResult<User>(_userDal.Get(c => c.Id == userId));
        //}

        //public User GetByMail(string email)
        //{
        //    return _userDal.Get(u => u.Email == email);
        //}

        //public List<OperationClaim> GetClaims(User user)
        //{
        //    return _userDal.GetClaims(user);
        //}

        //[TransactionScopeAspect]
        //public IResult TransactionalOperation(User user)
        //{
        //    _userDal.Update(user);
        //    _userDal.Add(user);
        //    return new SuccessResult(Messages.UserUpdated);

        //}

        //[ValidationAspect(typeof(UserValidator))]
        //[CacheRemoveAspect("IUserService.Get")]
        //public IResult Update(User user)
        //{
        //    _userDal.Update(user);
        //    return new SuccessResult(Messages.UserUpdated);
        //}


    }
}
