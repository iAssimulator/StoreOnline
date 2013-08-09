using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreOnline.Core.Models.DTOs
{
    public class EmployeeSalesDto : BaseEntity
    {
        public Employee Employee { get; set; }

        public IQueryable<SalesOrderHeader> Sales { get; set; }
    }
}
