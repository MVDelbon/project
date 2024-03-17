using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalMVDelbon.Application.Models.UsuarioClientes
{
    public class UsuarioClienteRequestModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int UsuarioSalonId { get; set; }
    }
}
