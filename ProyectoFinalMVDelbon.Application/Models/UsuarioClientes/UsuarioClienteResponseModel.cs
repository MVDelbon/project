using ProyectoFinalMVDelbon.Application.Models.FichasClientes;
using ProyectoFinalMVDelbon.Application.Models.UsuarioSalones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalMVDelbon.Application.Models.UsuarioClientes
{
    public class UsuarioClienteResponseModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public UsuarioSalonResponseModel UsuarioSalon { get; set; }

    }
}
