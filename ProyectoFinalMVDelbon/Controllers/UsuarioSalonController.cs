using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinalMVDelbon.Application.Models.UsuarioClientes;
using ProyectoFinalMVDelbon.Application.Models.UsuarioSalones;
using ProyectoFinalMVDelbon.Application.Services.Interfaces;

namespace ProyectoFinalMVDelbon.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioSalonController : ControllerBase
    {
        public readonly IUsuarioSalonService _usuarioSalonService;

        public UsuarioSalonController(IUsuarioSalonService usuarioSalonService)
        {
            _usuarioSalonService = usuarioSalonService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] UsuarioSalonRequestModel salon)
        {
            await _usuarioSalonService.Add(salon);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UsuarioSalonRequestModel salon, int id)
        {
            await _usuarioSalonService.Update(salon, id);
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetAllUsuariosSalon()
        {
            var salones = await _usuarioSalonService.GetAll();
            return Ok(salones);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var salon = await _usuarioSalonService.GetById(id);
            return Ok(salon);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _usuarioSalonService.Delete(id);
            return Ok();
        }
    }
}
