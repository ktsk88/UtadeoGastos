﻿using Microsoft.AspNetCore.Mvc;

using UtadeoGastos.Dtos;
using UtadeoGastos.LogicBusiness;

namespace UtadeoGastos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GastosController : ControllerBase
    {
        private readonly IGastosLogic gastosLogic;

        public GastosController(IGastosLogic gastosLogic)
        {
            this.gastosLogic = gastosLogic;
        }

        [HttpDelete("/{id}")]
        public async Task<ActionResult> Delete([FromRoute] int id)
        {
            await gastosLogic.Delete(id);
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult> Save([FromBody] GastosContract dto)
        {
            await gastosLogic.Add(dto);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] ReadGastosContract dto)
        {
            await gastosLogic.Update(dto);
            return Ok();
        }

        [HttpGet("/{name}/{cantidad}/{pagina}")]
        public async Task<ActionResult> GetByName([FromRoute] string name, [FromRoute] int cantidad, [FromRoute] int pagina)
        {
            return Ok(await gastosLogic.GetByName(name, pagina, cantidad));
        }

        [HttpGet("/{name}")]
        public async Task<ActionResult> GetByName([FromRoute] string name)
        {
            return Ok(await gastosLogic.GetMonthInform(name));
        }
    }
}
