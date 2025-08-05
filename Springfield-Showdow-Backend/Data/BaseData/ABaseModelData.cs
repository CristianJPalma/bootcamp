using Data.Interfaces;
using Entity.Model;
using Entity.Dtos.BaseDtos;


namespace Data.BaseData
{
    // clase asbtracta base del data que define los metodos basicos de acceso a datos 
    public abstract class ABaseModelData<T,D>: IBaseModelData<T,D> 
    
        where T : Base // el tipo de entidad que hereda de Base
        where D : BaseDto // el tipo de DTO que hereda de BaseDto



    {

     public abstract Task<List<T>> GetAllAsync();
     public abstract Task<T> GetByIdAsync(int id);
     public abstract Task<T> CreateAsync(T entity);
     public abstract Task<T> UpdateAsync(T entity); 
     public abstract Task<bool> DeleteAsync(int id);


}

}
