using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreOnline.Core.Models;
using StoreOnline.Core.Models.DTOs;

namespace StoreOnline.Core.Interfaces
{
    public interface IContactRepository : IRepository<Contact>
    {
        Contact CreateNewContact(ContactCreationDto thisContact);
    }
}
