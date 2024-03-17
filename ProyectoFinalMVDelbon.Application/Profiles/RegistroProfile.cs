using AutoMapper;
using ProyectoFinalMVDelbon.Application.Models.Registros;
using ProyectoFinalMVDelbonDomain.Entitiess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalMVDelbon.Application.Profiles
{
    public class RegistroProfile : Profile
    {
        public RegistroProfile() 
        {
            CreateMap<RegistroEntity, RegistroResponseModel>().ReverseMap();
            CreateMap<RegistroRequestModel, RegistroEntity>().ReverseMap();

        }

    }
}
