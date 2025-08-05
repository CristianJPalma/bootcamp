using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces;
using Entity.Context;
using Entity.Dtos.BaseDtos;
using Entity.Model;
using Microsoft.Extensions.Configuration;

namespace Business.BaseBusiness
{
    public abstract class ABaseBusiness<T,D> : IBaseBusiness<T,D>

    where T : Base
    where D : BaseDto
    {

        // Metodo para llamar a todos los id registrados 
        public abstract Task<List<D>> GetAllAsync();

        // Metodo para llamar a un id especifico
        public abstract Task<D> GetByIdAsync(int id);

        // Metodo para crear un nuevo registro 
        public abstract Task<D> CreateAsync(D dto);

        // Metodo para actualizar un registro existente

        public abstract Task<D> UpdateAsync(D dto);

        //Metodo para eliminar un registro existente 
        public abstract Task<bool> DeleteAsync(int id);


    }
}
