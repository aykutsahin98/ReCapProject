using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        /* IResult Add(User user);
         IResult Delete(User user);
         IResult Update(User user);
         IDataResult<List<User>> GetAll();
         IDataResult<User> GetById(int userId);*/

        List<User> GetAll();
        List<OperationClaim> GetClaims(User user);
        void Add(User user);
        User GetByMail(string email);

       /* IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int id);
        List<OperationClaim> GetClaims(User user);
        User GetByMail(string email);*/
    }
}
