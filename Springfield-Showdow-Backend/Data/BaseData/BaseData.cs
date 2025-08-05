using AutoMapper;
using Data.BaseData;
using Entity.Context;
using Entity.Dtos.BaseDtos;
using Entity.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Data.Implements.BaseData
{
    public class BaseModelData<T,D> : ABaseModelData<T,D> 
        
        where T : Base
        where D : BaseDto
    {

     private readonly ApplicationDbContext _context;
     private readonly IConfiguration _configuration;
     private readonly DbSet<T> _dbSet;
     private readonly IMapper _mapper;
     


    public BaseModelData(ApplicationDbContext context, IConfiguration configuration, IMapper mapper)
        {
            _context = context;
            _configuration = configuration;
            _dbSet = _context.Set<T>();
            _mapper = mapper;
        }





        // Implementación de los métodos abstractos de ABaseModelData

        public override async Task<List<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }



        public override async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }


        public override async Task<T> CreateAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync(); 
            return entity;
        }


        public override async Task<T> UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }


        public override async Task<bool> DeleteAsync(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);
            if (entity == null) return false; 

            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }

    }
}
