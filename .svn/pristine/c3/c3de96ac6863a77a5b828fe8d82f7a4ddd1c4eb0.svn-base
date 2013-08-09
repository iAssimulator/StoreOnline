using System;
using System.Data.Entity;
using StoreOnline.Infrastructure.Data.EntityFramework;

namespace StoreOnline.Infrastructure.Interfaces
{
    //public interface IStoreOnlineContextFactory<out TContext> : IDisposable where TContext : DbContext
    public interface IStoreOnlineContextFactory<out TContext> 
        where TContext : DbContext
    {
        FurnituresContext Create();
    }
}
