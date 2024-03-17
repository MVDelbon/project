using ProyectoFinalMVDelbon.Application.Models.UsuarioClientes;
using ProyectoFinalMVDelbon.Application.Models.UsuarioSalones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalMVDelbon.Application.Services.Interfaces
{
    public interface IUsuarioSalonService
    {
        Task Add(UsuarioSalonRequestModel entity);
        Task Update(UsuarioSalonRequestModel entity, int id);
        Task<IEnumerable<UsuarioSalonResponseModel>> GetAll();
        Task<UsuarioSalonResponseModel> GetById(int id);
        Task Delete(int id);
    }
}
