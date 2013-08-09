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
    public class EfCountryRepository : GenericRepository<Country>, ICountryRepository
    {
        public EfCountryRepository(IStoreOnlineContextFactory<FurnituresContext> contextFactory) : base(contextFactory)
        {
        }

        public Country CreateNewCountry(CountryCreationDto thisCountry)
        {
            var newCountry = new Country() {CountryName = thisCountry.Name};
            try
            {
                this.Add(newCountry);
                this.Save();
                return this.FindBy(c => c.CountryName == thisCountry.Name).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new EntityCommandCompilationException("CountryRepository, CreateNewCountry: Entity [Country] badly initialised", ex.InnerException);
            }
        }
    }
}
