using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
//using System.Data.Entity.Core;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using StoreOnline.Core.Interfaces;
using StoreOnline.Core.Models;
using StoreOnline.Core.Models.DTOs;
using StoreOnline.Infrastructure.Interfaces;

namespace StoreOnline.Infrastructure.Data.EntityFramework.Repositories
{
    public class EfUserRepository : GenericRepository<MemberUser>, IUserRepository
    {
        public EfUserRepository(IStoreOnlineContextFactory<FurnituresContext> contextFactory) : base(contextFactory)
        {
        }

        public virtual MemberUser CreateNewUser(UserRegistrationDto thisUser)
        {
            var newUser = new MemberUser()
                {
                    MUS_Login = thisUser.Username,
                    MUS_Password = thisUser.Password,
                    MUS_Email = thisUser.Email,
                    MUS_RoleID = thisUser.RoleId,
                    MUS_Token = thisUser.Token,
                    MUS_TokenCreatedAt = thisUser.TokenCreatedAt,
                    MUS_TokenExpiresAt = thisUser.TokenExpiresAt,
                    MUS_UserAgent = thisUser.UserAgent
                };

            try
            {
                this.Add(newUser);
                this.Save();
                return newUser;
                //Trying to see if the generated ID is saved into the instance of the object being saved.
                //return
                //    this.FindBy(u => u.MUS_Login == thisUser.Username && u.MUS_Password == thisUser.Password)
                //        .FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new EntityCommandExecutionException("UserRepository, CreateNewUser: Entity [MemberUser] badly initialised", ex.InnerException);
            }
        }

        public bool IsUserEmployee(int currentUserId)
        {
            return
                this.GetAll().Any(u => u.Employees.All(e => e.UserID == currentUserId));
        }
    }
}
