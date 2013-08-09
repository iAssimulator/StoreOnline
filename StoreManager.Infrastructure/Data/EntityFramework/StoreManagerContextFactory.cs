using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreOnline.Infrastructure.Interfaces;

namespace StoreOnline.Infrastructure.Data.EntityFramework
{
    public class StoreOnlineContextFactory<TContext> : IStoreOnlineContextFactory<TContext> where TContext : DbContext
    {
        public FurnituresContext Create()
        {
            return new FurnituresContext();
        }
    }
}
