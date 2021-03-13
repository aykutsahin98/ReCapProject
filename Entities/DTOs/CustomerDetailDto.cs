using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
   public class CustomerDetailDto : IDto
    {
        public int CustomerId { get; set; }
        public string UserName { get; set; }
        public string CompanyName { get; set; }
    }
}
