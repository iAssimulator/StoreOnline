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
    public class EfCountyRepository : GenericRepository<County>, ICountyRepository
    {
        public EfCountyRepository(IStoreOnlineContextFactory<FurnituresContext> contextFactory) : base(contextFactory)
        {
        }

        public County CreateNewCounty(CountyCreationDto thisCounty)
        {
            var newCounty = new County() {CountyName = thisCounty.Name, CountyID = thisCounty.CountryId};
            try
            {
                this.Add(newCounty);
                this.Save();
                return
                    this.FindBy(
                        c => c.CountyName == newCounty.CountyName && c.CountyCountryID == newCounty.CountyCountryID)
                        .FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new EntityCommandCompilationException("CountyRepository, CreateNewCounty: Entity [County] badly initialised", ex.InnerException);
            }
        }
    }
}
