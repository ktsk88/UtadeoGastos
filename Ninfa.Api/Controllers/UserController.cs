using Microsoft.AspNetCore.Mvc;
using Ninfa.Common;
using Ninfa.Common.TransferObjects;
using Ninfa.Logic.Abstractions.Interface;

namespace Ninfa.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUsserLogic _userLogic;

        public UserController(IUsserLogic userLogic)
        {
            _userLogic = userLogic;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Save([FromBody] UserSave dto)
        {
            var result = await _userLogic.Save(dto);
            return Ok(result);
        }

        [HttpDelete("{phone}")]
        public async Task<ActionResult<bool>> Delete(string phone)
        {
            var result = await _userLogic.Delete(phone);
            if (result)
            {
                return Ok(result);
            }
            return NotFound();
        }

        [HttpGet("{phone}")]
        public async Task<ActionResult<UserRead>> Get(string phone)
        {
            var user = await _userLogic.Get(phone);
            if (user != null)
            {
                return Ok(user);
            }
            return NotFound();
        }

        [HttpGet("{phone}/concepts")]
        public async Task<ActionResult<PaginatedResult<ConceptRead>>> GetConcepts([FromRoute] string phone, [FromQuery] int page = 1)
        {
            var concepts = await _userLogic.GetConcepts(phone, page);
            return Ok(concepts);
        }
    }

}
