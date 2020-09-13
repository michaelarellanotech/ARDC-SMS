using ARDC.Admin.API.DTOs;
using ARDC.Admin.API.Services;
using ARDC.Admin.Common.Pagination;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ARDC.Admin.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OfficialsController : ControllerBase
    {
        private readonly IOfficialsService _service;

        public OfficialsController(IOfficialsService service)
        {
            _service = service;
        }

        [HttpGet]
        [ProducesResponseType(200)]
        public async Task<IActionResult> GetAll([FromQuery] PagingRequest<OfficialsListItem> pagingRequest, [FromQuery] FilterRequest<OfficialsListItem> filterReq)
        {
            var result = await _service.GetAll(pagingRequest, filterReq);
            return Ok(result);
        }
    }
}
