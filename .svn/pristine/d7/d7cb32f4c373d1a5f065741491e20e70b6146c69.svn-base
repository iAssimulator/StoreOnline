using System;
using System.Collections.Generic;
//using System.Data.Entity.Core;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreOnline.Core.Interfaces;
using StoreOnline.Core.Models;
using StoreOnline.Core.Models.DTOs;
using StoreOnline.Infrastructure.Interfaces;

namespace StoreOnline.Infrastructure.Data.EntityFramework.Repositories
{
    public class EfContactRepository : GenericRepository<Contact>, IContactRepository
    {
        public EfContactRepository(IStoreOnlineContextFactory<FurnituresContext> contextFactory) : base(contextFactory)
        {
        }

        public Contact CreateNewContact(ContactCreationDto thisContact)
        {
            var newContact = new Contact()
                {
                    Title = thisContact.Title,
                    FirstName = thisContact.FirstName,
                    MiddleName = thisContact.MiddleName,
                    LastName = thisContact.LastName,
                    Suffix = thisContact.Suffix,
                    ShortName = thisContact.ShortName,
                    EmailPromotion = thisContact.EmailPromotion,
                    Phone = thisContact.Phone
                };
            try
            {
                this.Add(newContact);
                this.Save();
                return
                    this.FindBy(
                        c =>
                        c.FirstName == thisContact.FirstName && c.Suffix == thisContact.Suffix &&
                        c.LastName == thisContact.LastName && c.Phone == thisContact.Phone).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new EntityCommandCompilationException("ContacctRepository, CreateNewContact: Entity [Contact] badly initialised", ex.InnerException);
            }
        }
    }
}
