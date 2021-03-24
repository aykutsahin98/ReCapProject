using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
   public class PaymentDetailDto: IDto
    {
        public Rental Rental { get; set; }
        public Payment Payment { get; set; }
    }
}
