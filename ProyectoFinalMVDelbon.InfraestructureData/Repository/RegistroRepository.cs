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
    public class RegistroRepository : GenericRepository<RegistroEntity>, IRegistroRepository
    {
        public RegistroRepository(DataContext context) : base(context)
        {

        }
    }
}
