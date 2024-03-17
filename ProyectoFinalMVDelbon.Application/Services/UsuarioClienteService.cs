using AutoMapper;
using ProyectoFinalMVDelbon.Application.Models.FichasClientes;
using ProyectoFinalMVDelbon.Application.Models.UsuarioClientes;
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
    public class UsuarioClienteService : IUsuarioClienteService
    {
        private readonly IUsuarioClienteRepository _usuarioClienteRepository;
        private readonly IMapper _mapper;

        public UsuarioClienteService(IUsuarioClienteRepository usuarioClienteRepository, IMapper mapper)
        {
            _usuarioClienteRepository = usuarioClienteRepository;
            _mapper = mapper;
        }

        //Add
        public async Task Add(UsuarioClienteRequestModel entity)
        {
            var usuarioClienteEntity = _mapper.Map<UsuarioClienteEntity>(entity);
            usuarioClienteEntity.CreatedBy = "Admin.";
            usuarioClienteEntity.UpdatedBy = "Admin.";
            await _usuarioClienteRepository.AddAsync(usuarioClienteEntity);
            await _usuarioClienteRepository.SaveChanges();
        }

        //Update 
        public async Task Update(UsuarioClienteRequestModel entity, int id)
        {
            UsuarioClienteEntity usuarioClienteEntityFound = await _usuarioClienteRepository.GetByIdAsync(id) ?? throw new Exception("El id ingresado no existe");
            var usuarioClienteEntity = _mapper.Map(entity, usuarioClienteEntityFound);
            await _usuarioClienteRepository.UpdateAsync(usuarioClienteEntity);
            await _usuarioClienteRepository.SaveChanges();
        }

        //GetAll
        public async Task<IEnumerable<UsuarioClienteResponseModel>> GetAll()
        {
            var usuarioClienteEntity = await _usuarioClienteRepository.GetAllAsync();
            var usuarioClienteResponseModel = _mapper.Map<IEnumerable<UsuarioClienteResponseModel>>(usuarioClienteEntity);
            return usuarioClienteResponseModel;
        }

        //GetById
        public async Task<UsuarioClienteResponseModel> GetById(int id)
        {
            var usuarioClienteEntity = _usuarioClienteRepository.GetByIdAsync(id);
            var usuarioClienteResponseModel = _mapper.Map<UsuarioClienteResponseModel>(usuarioClienteEntity);
            return usuarioClienteResponseModel;
        }

        //Delete
        public async Task Delete(int id)
        {
            await _usuarioClienteRepository.DeleteAsync(id);
            await _usuarioClienteRepository.SaveChanges();
        }
    }
}
