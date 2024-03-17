using AutoMapper;
using ProyectoFinalMVDelbon.Application.Models.Registros;
using ProyectoFinalMVDelbon.Application.Models.UsuarioClientes;
using ProyectoFinalMVDelbonDomain.Entitiess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalMVDelbon.Application.Profiles
{
    public class UsuarioClienteProfile : Profile
    {
        public UsuarioClienteProfile()
        {
            CreateMap<UsuarioClienteEntity, UsuarioClienteResponseModel>().ReverseMap();
            CreateMap<UsuarioClienteRequestModel, UsuarioClienteEntity>().ReverseMap();

        }
    }
}
