using AutoMapper;
using ProyectoFinalMVDelbon.Application.Models.UsuarioClientes;
using ProyectoFinalMVDelbon.Application.Models.UsuarioSalones;
using ProyectoFinalMVDelbon.Application.Services.Interfaces;
using ProyectoFinalMVDelbonDomain.Entitiess;
using ProyectoFinalMVDelbonDomain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalMVDelbon.Application.Services
{
    public class UsuarioSalonService : IUsuarioSalonService
    {
        private readonly IUsuarioSalonRepository _usuarioSalonRepository;
        private readonly IMapper _mapper;

        public UsuarioSalonService(IUsuarioSalonRepository usuarioSalonRepository, IMapper mapper)
        {
            _usuarioSalonRepository = usuarioSalonRepository;
            _mapper = mapper;
        }

        //Add
        public async Task Add(UsuarioSalonRequestModel entity)
        {
            var usuarioSalonEntity = _mapper.Map<UsuarioSalonEntity>(entity);
            usuarioSalonEntity.CreatedBy = "Admin.";
            usuarioSalonEntity.UpdatedBy = "Admin.";
            await _usuarioSalonRepository.AddAsync(usuarioSalonEntity);
            await _usuarioSalonRepository.SaveChanges();
        }

        //Update 
        public async Task Update(UsuarioSalonRequestModel entity, int id)
        {
            UsuarioSalonEntity usuarioSalonEntityFound = await _usuarioSalonRepository.GetByIdAsync(id) ?? throw new Exception("El id ingresado no existe");
            var usuarioSalonEntity = _mapper.Map(entity, usuarioSalonEntityFound);
            await _usuarioSalonRepository.UpdateAsync(usuarioSalonEntity);
            await _usuarioSalonRepository.SaveChanges();
        }

        //GetAll
        public async Task<IEnumerable<UsuarioSalonResponseModel>> GetAll()
        {
            var usuarioSalonEntity = await _usuarioSalonRepository.GetAllAsync();
            var usuarioSalonResponseModel = _mapper.Map<IEnumerable<UsuarioSalonResponseModel>>(usuarioSalonEntity);
            return usuarioSalonResponseModel;
        }

        //GetById
        public async Task<UsuarioSalonResponseModel> GetById(int id)
        {
            var usuarioSalonEntity = _usuarioSalonRepository.GetByIdAsync(id);
            var usuarioSalonResponseModel = _mapper.Map<UsuarioSalonResponseModel>(usuarioSalonEntity);
            return usuarioSalonResponseModel;
        }

        //Delete
        public async Task Delete(int id)
        {
            await _usuarioSalonRepository.DeleteAsync(id);
            await _usuarioSalonRepository.SaveChanges();
        }
    }
}
