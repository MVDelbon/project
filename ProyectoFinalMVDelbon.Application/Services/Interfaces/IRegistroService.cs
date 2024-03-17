using ProyectoFinalMVDelbon.Application.Models.FichasClientes;
using ProyectoFinalMVDelbon.Application.Models.Registros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalMVDelbon.Application.Services.Interfaces
{
    public interface IRegistroService
    {
        Task Add(RegistroRequestModel entity);
        Task Update(RegistroRequestModel entity, int id);
        Task<IEnumerable<RegistroResponseModel>> GetAll();
        Task<RegistroResponseModel> GetById(int id);
        Task Delete(int id);
    }
}
