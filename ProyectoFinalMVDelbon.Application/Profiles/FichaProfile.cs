using AutoMapper;
using ProyectoFinalMVDelbon.Application.Models.FichasClientes;
using ProyectoFinalMVDelbonDomain.Entitiess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalMVDelbon.Application.Profiles
{
    public class FichaProfile : Profile
    {
        public FichaProfile()
        {
            CreateMap <FichaClienteEntity, FichaClienteResponseModel> ().ReverseMap();
            CreateMap<FichaClienteRequestModel, FichaClienteEntity > ().ReverseMap();

        }
    }
}
