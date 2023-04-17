using CustomerEntity;
using CustomerFinderBusiness.Abstract;
using CustomerFinderBusiness.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerService _customservice;
        public CustomerController()
        {
            _customservice = new CustomerManager();
        }

        [HttpGet]
        public List<Customer> Get() 
        {
          return  _customservice.GetAllCustomer();    
        }
        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            return _customservice.GetByIdCustomer(id);
        }
        [HttpPost]
        public Customer Post([FromBody]Customer customer)
        {
        return _customservice.CreateCustomer(customer);
        
        }
        [HttpPut]
        public Customer Put([FromBody] Customer customer)
        {
            return _customservice.UpdateCustomer(customer);
        }
        [HttpDelete]
        public void Delete(int id) 
        {
          _customservice.DeleteCustomer(id);
        }
    }
}
