using BlueSky.Application.Common.Exceptions;
using Core.Dtos;
using Core.Entities;
using Core.Interfaces;

namespace Core.Services
{
    public class CustomerService
    {
        private readonly IApplicationDbContext _context;
        public CustomerService(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> AddCustomer(RegistrationDetailDto registrationDetail)
        {
            var validator = new RegistrationDetailValidator();

            var result = await validator.ValidateAsync(registrationDetail);

            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }

            var customerEntity = new Customer
            {
                FirstName = registrationDetail.FirstName,
                Surname = registrationDetail.Surname,
                DOB = registrationDetail.DOB,
                Email = registrationDetail.Email
            };

            _context.Customers.Add(customerEntity);

            await _context.SaveChangesAsync();

            return customerEntity.CustomerId;
        }
    }
}
