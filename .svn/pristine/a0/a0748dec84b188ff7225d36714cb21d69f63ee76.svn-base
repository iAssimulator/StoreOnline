using System;
using System.Collections.Generic;
using System.Data;
//using System.Data.Entity.Core;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreOnline.Core.Interfaces;
using StoreOnline.Core.Models;
using StoreOnline.Core.Models.DTOs;
using StoreOnline.Infrastructure.Interfaces;

namespace StoreOnline.Infrastructure.Data.EntityFramework.Repositories
{
    public class EfPhotoRepository : GenericRepository<Photo>, IPhotoRepository
    {
        public EfPhotoRepository(IStoreOnlineContextFactory<FurnituresContext> contextFactory) : base(contextFactory)
        {
        }

        public Photo AttachNewPhoto(PhotoCreationDto photoItem)
        {
            var newPhoto = new Photo()
                {
                    Avatar = photoItem.Avatar,
                    MainPhoto = photoItem.MainPhoto,
                    ModifiedDate = DateTime.Now.Date
                };
            try
            {
                this.Add(newPhoto);
                this.Save();
                return
                    this.FindBy(p => p.Avatar == photoItem.Avatar && p.MainPhoto == photoItem.MainPhoto)
                        .FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new EntityCommandExecutionException("UserRepository, CreateNewUser: Entity [MemberUser] badly initialised", ex.InnerException);
            }
        }
    }
}
