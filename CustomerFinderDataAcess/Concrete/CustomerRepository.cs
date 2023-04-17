using CustomerEntity;
using CustomerFinderDataAcess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerFinderDataAcess.Concrete
{
    public class CustomerRepository : ICustomerReprsitory
    {
        public Customer CreateCustomer(Customer customer)
        {
            using (var customerDbContext = new CustomerDbContext())
            {
               ;
                customerDbContext.customers.Add(customer);
                customerDbContext.SaveChanges();
                return customer;
            }
        }

        public void DeleteCustomer(int id)
        {
            using (var customerDbContext = new CustomerDbContext())
            {
                var deletecustomer = GetByIdCustomer(id);
                customerDbContext.customers.Remove(deletecustomer);
                customerDbContext.SaveChanges();
            }
            
        }

        public List<Customer> GetAllCustomer()
        {
            using(var customerDbContext=new CustomerDbContext())
            {
                return customerDbContext.customers.ToList();
            }
            
        }

        public Customer GetByIdCustomer(int id)
        {
            using (var customerDbContext = new CustomerDbContext())
            {
                return customerDbContext.customers.Find(id);
            }

        }

        public Customer UpdateCustomer(Customer customer)
        {
            using (var customerDbContext = new CustomerDbContext())
            {
                ;
                customerDbContext.customers.Update(customer);
                return customer;
            }
        }
    }
}
