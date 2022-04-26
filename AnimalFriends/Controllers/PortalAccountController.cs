using Core.Dtos;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PortalAccountController : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<int>> Create([FromBody] RegistrationDetailDto registrationDetail)
        {
            throw new NotImplementedException();
        }
    }
}