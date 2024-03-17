using AutoMapper;
using ProyectoFinalMVDelbon.Application.Models.UsuarioClientes;
using ProyectoFinalMVDelbon.Application.Models.UsuarioSalones;
using ProyectoFinalMVDelbonDomain.Entitiess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalMVDelbon.Application.Profiles
{
    public class UsuarioSalonProfile : Profile
    {
        public UsuarioSalonProfile()
        {
            CreateMap<UsuarioSalonEntity, UsuarioSalonResponseModel>().ReverseMap();
            CreateMap<UsuarioSalonRequestModel, UsuarioSalonEntity>().ReverseMap();

        }
    }
}
