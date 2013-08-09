using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreOnline.Core.Models;
using StoreOnline.Core.Models.DTOs;

namespace StoreOnline.Core.Interfaces
{
    public interface IUserRepository : IRepository<MemberUser>
    {
        MemberUser CreateNewUser(UserRegistrationDto thisUser);
        //bool ValidateUser(string userName, string password);
        //bool CreateNewUser(UserRegistrationDto thisUser, EmployeeRegistrationDto thisEmployee, 
        //    ContactCreationDto thisContact, AddressCreationDto thisAddress, PhotoCreationDto thisPhoto);
        bool IsUserEmployee(int currentUserId);
    }
}
