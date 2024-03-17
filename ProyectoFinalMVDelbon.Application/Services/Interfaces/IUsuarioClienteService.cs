using ProyectoFinalMVDelbon.Application.Models.Registros;
using ProyectoFinalMVDelbon.Application.Models.UsuarioClientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalMVDelbon.Application.Services.Interfaces
{
    public interface IUsuarioClienteService
    {
        Task Add(UsuarioClienteRequestModel entity);
        Task Update(UsuarioClienteRequestModel entity, int id);
        Task<IEnumerable<UsuarioClienteResponseModel>> GetAll();
        Task<UsuarioClienteResponseModel> GetById(int id);
        Task Delete(int id);
    }
}
