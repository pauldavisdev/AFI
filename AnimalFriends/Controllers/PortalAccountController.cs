using Core.Dtos;
using Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PortalAccountController : ControllerBase
    {
        private CustomerService _customerService;

        public PortalAccountController(CustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create(RegistrationDetailDto registrationDetail)
        {
            return await _customerService.AddCustomer(registrationDetail);           
        }

    }
}