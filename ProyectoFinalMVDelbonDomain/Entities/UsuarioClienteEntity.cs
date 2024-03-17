using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalMVDelbonDomain.Entitiess
{
    public class UsuarioClienteEntity : BaseEntity
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; } 

        public FichaClienteEntity Ficha { get; set; }

        public UsuarioSalonEntity salon { get; set; } = null!;
        public int UsuarioSalonId { get; set; }
    }
}
