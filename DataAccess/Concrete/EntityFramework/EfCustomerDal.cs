using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, RentACarContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from cu in context.Customers
                                 join us in context.Users
                                 on cu.UserId equals us.UserId
                                 select new CustomerDetailDto
                                 {
                                     CustomerId= cu.CustomerId,
                                     UserName = us.UserName,
                                     CompanyName = cu.CompanyName,
                                 };
                    return result.ToList();
                }
        }
    }
}
