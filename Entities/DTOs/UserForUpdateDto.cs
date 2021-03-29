using Core.Entities;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
   public class UserForUpdateDto: IDto
    {
        public User User { get; set; }
        public string Password { get; set; }
    }
}
