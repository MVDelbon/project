using ProyectoFinalMVDelbon.InfraestructureData.Data;
using ProyectoFinalMVDelbonDomain.Entitiess;
using ProyectoFinalMVDelbonDomain.Repositories;


namespace ProyectoFinalMVDelbon.InfraestructureData.Repository
{
    public class FichaClienteRepository : GenericRepository<FichaClienteEntity>, IFichaClienteRepository
    {
        public FichaClienteRepository(DataContext context) : base(context)
        {

         }
    }
}
