using CustomerEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerFinderBusiness.Abstract
{
    public interface ICustomerService
    {
        List<Customer> GetAllCustomer();

        Customer GetByIdCustomer(int id);

        Customer CreateCustomer(Customer customer);

        Customer UpdateCustomer(Customer customer);

        void DeleteCustomer(int id);

    }
}
