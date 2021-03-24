using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Payment: IEntity
    {
        public decimal Amount { get; set; }
    }
}
