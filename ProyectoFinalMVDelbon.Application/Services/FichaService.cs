using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProyectoFinalMVDelbon.Application.Models.FichasClientes;
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
    public class FichaService : IFichaService
    {
        private readonly IFichaClienteRepository _fichaRepository;
        private readonly IMapper _mapper;

        public FichaService(IFichaClienteRepository fichaRepository, IMapper mapper)
        {
            _fichaRepository = fichaRepository;
            _mapper = mapper;
        }

        //Add
        public async Task Add(FichaClienteRequestModel entity)
        {
            var fichaEntity = _mapper.Map<FichaClienteEntity>(entity);
            fichaEntity.CreatedBy = "Admin.";
            fichaEntity.UpdatedBy = "Admin.";
            await _fichaRepository.AddAsync(fichaEntity);
           await _fichaRepository.SaveChanges();
        }

        //Update 
        public async Task Update(FichaClienteRequestModel entity, int id)
        {
            FichaClienteEntity fichaEntityFound = await _fichaRepository.GetByIdAsync(id) ?? throw new Exception("El id ingresado no existe");
            var fichaEntity = _mapper.Map(entity, fichaEntityFound);
            await _fichaRepository.UpdateAsync(fichaEntity);
            await _fichaRepository.SaveChanges();
        }
        
        //GetAll
        public async Task<IEnumerable<FichaClienteResponseModel>> GetAll()
        {
            var fichaEntity = await _fichaRepository.GetAllAsync();
            var fichaResponseModel = _mapper.Map<IEnumerable<FichaClienteResponseModel>>(fichaEntity);
            return fichaResponseModel;
        }

        //GetById
        public async Task <FichaClienteResponseModel> GetById(int id)
        {
           var fichaEntity = _fichaRepository.GetByIdAsync(id);
           var fichaResponseModel = _mapper.Map<FichaClienteResponseModel>(fichaEntity);
           return fichaResponseModel;
        }

        //Delete
        public async Task Delete(int id)
        {
            await _fichaRepository.DeleteAsync(id);
            await _fichaRepository.SaveChanges();
        }

    } 
}
