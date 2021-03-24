using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentalDetailDto: IDto
    {
        public int RentalId { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public string UserName { get; set; }
        public string CompanyName { get; set; }
        public string ModelYear { get; set; }
 
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
