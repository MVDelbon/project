using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalMVDelbonDomain.Entitiess
{
    public class RegistroEntity : BaseEntity
    {
        #region Propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Descripcion { get; set; }
        public string Precio { get; set; }

        //public virtual FichaClienteEntity Ficha { get; set; } = new FichaClienteEntity();
        public FichaClienteEntity Ficha { get; set; } = null!;
        public int FichaClienteId { get; set; }


        #endregion

        #region Constructor


        #endregion

        #region Metodos

        #endregion
    }
}
