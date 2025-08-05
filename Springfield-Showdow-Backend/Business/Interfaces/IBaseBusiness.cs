using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Dtos.BaseDtos;
using Entity.Model;

namespace Business.Interfaces
{
    public interface IBaseBusiness<T,D>

        where T : Base
        where D : BaseDto
    {

        // Metodo para llamar a todos los id registrados
        Task<List<D>> GetAllAsync();

        // Metodo para llamar a un id especifico
        Task<D> GetByIdAsync(int id);

        // Metodo para crear un nuevo registro
        Task<D> CreateAsync(D dto);

        // Metodo para actualizar un registro existente

        Task<D> UpdateAsync(D dto);

        //Metodo para eliminar un registro existente
        Task<bool> DeleteAsync(int id);


    }
}
