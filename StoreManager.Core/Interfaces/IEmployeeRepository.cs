using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreOnline.Core.Models;
using StoreOnline.Core.Models.DTOs;

namespace StoreOnline.Core.Interfaces
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        Employee GetEmployeeByNationalUniqueNumber(string nationalIdNumber);
        int GetMaxEmployeeNumber();
        Employee RegisterNewEmployee(EmployeeRegistrationDto thisEmployee);
        Contact GetEmployeeContactDetails(int contactId);
        Address GetEmployeeAddress(int addressId);
        Photo GetEmployeeMugshots(int photoId);
    }
}
