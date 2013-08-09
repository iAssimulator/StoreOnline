using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreOnline.Core.Models.DTOs
{
    public class ContactCreationDto : BaseEntity
    {
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public string ShortName {get { return FirstName + ' ' + LastName; }}
        public int EmailPromotion { get; set; }
        public string Phone { get; set; }
    }
}
