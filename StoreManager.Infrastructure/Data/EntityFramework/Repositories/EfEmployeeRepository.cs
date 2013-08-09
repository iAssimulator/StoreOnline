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
    public class EfEmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EfEmployeeRepository(IStoreOnlineContextFactory<FurnituresContext> contextFactory) : base(contextFactory)
        {
        }

        public Employee GetEmployeeByNationalUniqueNumber(string nationalIdNumber)
        {
            return this.FindBy(e => e.NationalIDNumber == nationalIdNumber).FirstOrDefault();
        }

        public int GetMaxEmployeeNumber()
        {
            return this.GetAll().Count();
        }

        public Employee RegisterNewEmployee(EmployeeRegistrationDto thisEmployee)
        {
            var newEmployee = new Employee()
                {
                    ContactID = thisEmployee.ContactId,
                    AddressID = thisEmployee.AddressId,
                    BirthDate = thisEmployee.BirthDay,
                    MaritalStatus = thisEmployee.MaritalStatus.ToString(),
                    Gender = thisEmployee.Gender.ToString(),
                    HireDate = thisEmployee.HireDate,
                    SalariedFlag = thisEmployee.SalariedFlag,
                    HolidayHours = thisEmployee.HolidayHours,
                    SickLeaveHours = thisEmployee.SickLeaveHours,
                    CurrentFlag = thisEmployee.CurrentFlag,
                    PhotoID = thisEmployee.PhotoId
                };
            try
            {
                this.Add(newEmployee);
                this.Save();
                return
                    this.FindBy(
                        e =>
                        e.ContactID == thisEmployee.ContactId && e.AddressID == thisEmployee.AddressId &&
                        e.BirthDate == thisEmployee.BirthDay).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new EntityCommandExecutionException("EmployeeRepository, RegisterNewEmployeer: Entity [Employee] badly initialised", ex.InnerException);
            }
        }

        public Contact GetEmployeeContactDetails(int contactId)
        {
            return (from e in GetAll() where e.ContactID == contactId select e.Contact).FirstOrDefault();
        }

        public Address GetEmployeeAddress(int addressId)
        {
            return this.GetAll().Where(e => e.AddressID == addressId).Select(e => e.Address).FirstOrDefault();
        }

        public Photo GetEmployeeMugshots(int photoId)
        {
            return (from e in GetAll() where e.PhotoID == photoId select e.Photo).FirstOrDefault();
        }
    }
}
