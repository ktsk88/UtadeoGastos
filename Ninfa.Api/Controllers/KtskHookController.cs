using System.Text.Json;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Ninfa.Common;
using Ninfa.DataAccess;

namespace Ninfa.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KtskHookController : ControllerBase
    {
        protected readonly NinfaDbContext _dbContext;

        public KtskHookController(NinfaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public async Task<ActionResult> Save()
        {
            if (HttpContext.Request.ContentLength == null || HttpContext.Request.ContentLength == 0)
            {
                return BadRequest("No se enviaron datos en el cuerpo de la solicitud.");
            }

            using (StreamReader reader = new StreamReader(HttpContext.Request.Body))
            {
                string body = await reader.ReadToEndAsync();

                if (string.IsNullOrWhiteSpace(body))
                {
                    return BadRequest("El cuerpo de la solicitud está vacío.");
                }

                await _dbContext.KtskHooks.AddAsync(new() { CuerpoPeticion = body });
                await _dbContext.SaveChangesAsync();
            }
            return Ok();
        }
    }
}
