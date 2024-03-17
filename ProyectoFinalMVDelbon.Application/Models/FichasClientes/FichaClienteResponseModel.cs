using ProyectoFinalMVDelbon.Application.Models.UsuarioClientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalMVDelbon.Application.Models.FichasClientes
{
    public class FichaClienteResponseModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }

        public UsuarioClienteResponseModel UsuarioCliente { get; set; }
    }
}
