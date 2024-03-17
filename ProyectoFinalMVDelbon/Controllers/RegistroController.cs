using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinalMVDelbon.Application.Models.Registros;
using ProyectoFinalMVDelbon.Application.Services.Interfaces;

namespace ProyectoFinalMVDelbon.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistroController : ControllerBase
    {
        public readonly IRegistroService _registroService;

        public RegistroController(IRegistroService registroService)
        {
            _registroService = registroService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] RegistroRequestModel registro)
        {
            await _registroService.Add(registro);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] RegistroRequestModel registro, int id)
        {
            await _registroService.Update(registro, id);
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetAllRegistros()
        {
            var registro = await _registroService.GetAll();
            return Ok(registro);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var registro = await _registroService.GetById(id);
            return Ok(registro);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _registroService.Delete(id);
            return Ok();
        }
    
    }
}
