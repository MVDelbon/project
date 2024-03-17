using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalMVDelbonDomain.Entitiess
{
    public class UsuarioSalonEntity : BaseEntity
    {
        public int Id { get; set; }
        public  string NombreSalon { get; set; }

        public ICollection<UsuarioClienteEntity> Clientes { get; } = new List<UsuarioClienteEntity>();
    }
}
