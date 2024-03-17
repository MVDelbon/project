using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinalMVDelbon.Application.Models.FichasClientes;
using ProyectoFinalMVDelbon.Application.Models.UsuarioClientes;
using ProyectoFinalMVDelbon.Application.Services.Interfaces;

namespace ProyectoFinalMVDelbon.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioClienteController : ControllerBase
    {
        public readonly IUsuarioClienteService _usuarioClienteService;

        public UsuarioClienteController(IUsuarioClienteService usuarioClienteService)
        {
            _usuarioClienteService =usuarioClienteService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] UsuarioClienteRequestModel cliente)
        {
            await _usuarioClienteService.Add(cliente);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UsuarioClienteRequestModel cliente, int id)
        {
            await _usuarioClienteService.Update(cliente, id);
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetAllUsuariosClientes()
        {
            var clientes = await _usuarioClienteService.GetAll();
            return Ok(clientes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var cliente = await _usuarioClienteService.GetById(id);
            return Ok(cliente);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _usuarioClienteService.Delete(id);
            return Ok();
        }

    }
}
