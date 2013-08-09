using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreOnline.Core.Models;
using StoreOnline.Core.Models.DTOs;

namespace StoreOnline.Core.Interfaces
{
    public interface IUserService
    {
        KeyValuePair<bool, Employee> RegisterUser(UserRegistrationDto newUser, AddressCreationDto newAddress,
            ContactCreationDto newContat, EmployeeRegistrationDto newEmployee, PhotoCreationDto newPhoto);
        Employee Login(LoginDto loginDetails);
    }
}
