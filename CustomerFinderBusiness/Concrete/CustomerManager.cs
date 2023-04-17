using CustomerEntity;
using CustomerFinderBusiness.Abstract;
using CustomerFinderDataAcess.Abstract;
using CustomerFinderDataAcess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerFinderBusiness.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerReprsitory _customerReprsitory;

        public CustomerManager()
        {
            _customerReprsitory =new CustomerRepository();
        }


        public Customer CreateCustomer(Customer customer)
        {
            return _customerReprsitory.CreateCustomer(customer);
        }

        public void DeleteCustomer(int id)
        {
             _customerReprsitory.DeleteCustomer(id);
        }

        public List<Customer> GetAllCustomer()
        {
            return _customerReprsitory.GetAllCustomer();
        }

        public Customer GetByIdCustomer(int id)
        {
            return _customerReprsitory.GetByIdCustomer(id);
        }

        public Customer UpdateCustomer(Customer customer)
        {
            return _customerReprsitory.UpdateCustomer(customer);
        }
    }
}
