using CustomerEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerFinderDataAcess.Abstract
{
    public interface ICustomerReprsitory
    {
        List<Customer> GetAllCustomer();

        Customer GetByIdCustomer(int id);

        Customer CreateCustomer(Customer customer);

        Customer UpdateCustomer(Customer customer);

        void DeleteCustomer(int id);
    }
}
