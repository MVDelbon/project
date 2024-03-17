using ProyectoFinalMVDelbon.InfraestructureData.Data;
using ProyectoFinalMVDelbonDomain.Entitiess;
using ProyectoFinalMVDelbonDomain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalMVDelbon.InfraestructureData.Repository
{
    public class UsuarioSalonRepository : GenericRepository<UsuarioSalonEntity>, IUsuarioSalonRepository
    {
        public UsuarioSalonRepository(DataContext context) : base(context)
        {

        }
    }
}
