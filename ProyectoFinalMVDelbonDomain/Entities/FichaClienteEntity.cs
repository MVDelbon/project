using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalMVDelbonDomain.Entitiess
{
    public class FichaClienteEntity : BaseEntity
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        
        public ICollection<RegistroEntity> Registros { get;} = new List<RegistroEntity>();

        public UsuarioClienteEntity Cliente { get; set; } //= new UsuarioClienteEntity();
        public int UsuarioClienteEntityId { get; set; }
    }
}
