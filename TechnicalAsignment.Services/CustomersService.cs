using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using TechnicalAsignment.Data;
using TechnicalAsignment.Domain.DTO;

namespace TechnicalAsignment.Services
{
    public class CustomersService
    {
        public List<CustomerDTO> GetAllCustomers()
        {
            using(var context = new TechnicalAsignmentDBContainer())
            {
                var customers = context.Customers.ToList();

                return customers.Select(c => Mapper.Map<CustomerDTO>(c)).ToList();
            }
        }

        public CustomerDTO GetCustomerById(long id)
        {
            using(var context = new TechnicalAsignmentDBContainer())
            {
                var customer = context.Customers.FirstOrDefault(c => c.Id == id);

                return Mapper.Map<CustomerDTO>(customer);
            }
        }

        public CustomerDTO GetCustomerByEmail(string email)
        {
            using (var context = new TechnicalAsignmentDBContainer())
            {
                var customer = context.Customers.FirstOrDefault(c => c.Email == email);

                return Mapper.Map<CustomerDTO>(customer);
            }
        }
    }
}
