using ProyectoFinalMVDelbon.Application.Models.FichasClientes;
using ProyectoFinalMVDelbonDomain.Entitiess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalMVDelbon.Application.Services.Interfaces
{
    public interface IFichaService
    {
        Task Add(FichaClienteRequestModel entity);
        Task Update(FichaClienteRequestModel entity, int id);
        Task<IEnumerable<FichaClienteResponseModel>> GetAll();
        Task <FichaClienteResponseModel> GetById(int id);
        Task Delete(int id);

    }
}
