using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Dtos.BaseDtos;
using Entity.Model;


namespace Data.Interfaces
{
    public interface IBaseModelData<T,D>

        where D : BaseDto
        where T : Base

    {
        // metodo para obtener una entidad por su id 

        Task<T> GetByIdAsync(int id);

        // metodo para obtener todos los id registrados

        Task<List<T>> GetAllAsync();

        //crear una entidad 

        Task<T> CreateAsync(T entity);

        // actualizar una entidad 

        Task<T> UpdateAsync(T entity);  

        // Eliminar una entidad por su id 

        Task<bool> DeleteAsync(int id);
    }
}
