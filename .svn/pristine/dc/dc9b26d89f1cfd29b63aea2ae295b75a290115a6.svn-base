using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreOnline.Core.Interfaces;
using StoreOnline.Core.Models;
using StoreOnline.Core.Models.DTOs;

namespace StoreOnline.Core.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        private IEmployeeRepository _employeeRepository;
        private IAddressRepository _addressRepository;
        private IContactRepository _contactRepository;
        private IPhotoRepository _photoRepository;

        public UserService(IUserRepository userRepository, IEmployeeRepository employeeRepository,
            IAddressRepository addressRepository, IContactRepository contactRepository, IPhotoRepository photoRepository)
        {
            _photoRepository = photoRepository;
            _contactRepository = contactRepository;
            _addressRepository = addressRepository;
            _employeeRepository = employeeRepository;
            _userRepository = userRepository;
        }

        /// <summary>
        /// Registers user, employee, address, contact then returns an employee object for caching
        /// </summary>
        /// <returns>Returns Employee, see: Model: Employee</returns>
        public virtual KeyValuePair<bool, Employee> RegisterUser(UserRegistrationDto newUser, AddressCreationDto newAddress, 
            ContactCreationDto newContat, EmployeeRegistrationDto newEmployee, PhotoCreationDto newPhoto)
        {
            var result = new KeyValuePair<bool, Employee>();
            MemberUser freshUser = _userRepository.CreateNewUser(newUser);
            Address freshAddress = _addressRepository.CreateNewAddress(newAddress);
            Contact freshContact = _contactRepository.CreateNewContact(newContat);
            Photo freshPhoto = _photoRepository.AttachNewPhoto(newPhoto);
            Employee freshEmployee = _employeeRepository.RegisterNewEmployee(newEmployee);
            if (freshUser != null && freshEmployee != null && freshAddress != null && freshContact != null) 
                result = new KeyValuePair<bool, Employee>(true, freshEmployee);
            
            return result;
        }

        /// <summary>
        /// Validates a user if succeeded then aserts if user is employee
        /// (no: [RegisterEmployee() then return Employee object for caching] | yes: returns Employee object for caching)
        /// </summary>
        /// <returns></returns>
        public virtual Employee Login(LoginDto loginDetails)
        {
            MemberUser loggedIn =
                _userRepository.FindBy(
                    u => u.MUS_Login == loginDetails.Username && u.MUS_Password == loginDetails.Password)
                               .FirstOrDefault();
            Employee thisEmployee = null;
            try
            {
                 thisEmployee = _employeeRepository.FindBy(e => e.UserID == loggedIn.MUS_ID).FirstOrDefault();
                return thisEmployee;
            }
            catch (Exception)
            {
                return thisEmployee;
            }
        }
    }
}
