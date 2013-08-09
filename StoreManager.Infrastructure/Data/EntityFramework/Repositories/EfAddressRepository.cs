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
    public class EfAddressRepository : GenericRepository<Address>, IAddressRepository
    {
        public EfAddressRepository(IStoreOnlineContextFactory<FurnituresContext> contextFactory) : base(contextFactory)
        {
        }

        public Address CreateNewAddress(AddressCreationDto thisAddress)
        {
            var newAddress = new Address()
                {
                    AddressLine1 = thisAddress.Line1,
                    AddressLine2 = thisAddress.Line2,
                    Town = thisAddress.Town,
                    CountyID = thisAddress.CountyId,
                    PostalCode = thisAddress.Postcode,
                    CountryID = thisAddress.CountryId
                };
            try
            {
                this.Add(newAddress);
                this.Save();
                return
                    this.FindBy(
                        a =>
                        a.AddressLine1 == thisAddress.Line1 && a.CountyID == thisAddress.CountyId &&
                        a.PostalCode == thisAddress.Postcode).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new EntityCommandExecutionException("AddressRepository, CreateNewAddress: Entity [Address] badly initialised", ex.InnerException);
            }
        }
    }
}
