using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Data.Interfaces;
using Entity.Dtos.BaseDtos;
using Entity.Model;
using Microsoft.Extensions.Logging;

namespace Business.BaseBusiness
{
    public class BaseBusiness<T, D> : ABaseBusiness<T, D>

        where T : Base
        where D : BaseDto
    {
        private readonly IBaseModelData<T, D> _data;
        private readonly IMapper _mappers;
        private readonly ILogger _logger;

        public BaseBusiness(IBaseModelData<T, D> data, IMapper mappers, ILogger logger) 
        {
            _data = data;
            _mappers = mappers;
            _logger = logger;

        }


        public override async Task<List<D>> GetAllAsync()
        {
            try
            {
                var entities = await _data.GetAllAsync();
                _logger.LogInformation($"Obteniendo todos los registros de {typeof(T).Name}");
                return _mappers.Map<IList<D>>(entities).ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al obtener registros de {typeof(T).Name}: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Obtiene una entidad específica por su identificador único.
        /// </summary>
        /// <param name="id">El identificador único de la entidad a buscar</param>
        /// <returns>
        /// El DTO correspondiente a la entidad encontrada, o null si no existe
        /// </returns>
        public override async Task<D> GetByIdAsync(int id)
        {
            try
            {
                var entities = await _data.GetByIdAsync(id);
                _logger.LogInformation($"Obteniendo {typeof(T).Name} con ID: {id}");
                return _mappers.Map<D>(entities);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al obtener {typeof(T).Name} con ID {id}: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Crea una nueva entidad en el sistema a partir de un DTO.
        /// </summary>
        /// <param name="dto">El DTO que contiene los datos para crear la nueva entidad</param>
        /// <returns>
        /// El DTO de la entidad creada, incluyendo el ID asignado y cualquier otro campo generado
        /// </returns>
        public override async Task<D> CreateAsync(D dto)
        {
            try
            {
                var entity = _mappers.Map<T>(dto);
                entity = await _data.CreateAsync(entity);
                _logger.LogInformation($"Creando nuevo {typeof(T).Name}");
                return _mappers.Map<D>(entity);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al crear {typeof(T).Name} desde DTO: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Actualiza una entidad existente con los datos proporcionados en el DTO.
        /// </summary>
        /// <param name="dto">El DTO que contiene los datos actualizados para la entidad</param>
        /// <returns>
        /// El DTO de la entidad actualizada
        /// </returns>
        public override async Task<D> UpdateAsync(D dto)
        {
            try
            {
                var entity = _mappers.Map<T>(dto);
                entity = await _data.UpdateAsync(entity);
                _logger.LogInformation($"Actualizando {typeof(T).Name} desde DTO");
                return _mappers.Map<D>(entity);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al actualizar {typeof(T).Name} desde DTO: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Elimina permanentemente una entidad del sistema por su identificador.
        /// </summary>
        /// <param name="id">El identificador único de la entidad a eliminar</param>
        /// <returns>
        /// true si la entidad fue eliminada exitosamente; false en caso contrario
        /// </returns>
        public override async Task<bool> DeleteAsync(int id)
        {
            try
            {
                _logger.LogInformation($"Eliminando {typeof(T).Name} con ID: {id}");
                return await _data.DeleteAsync(id);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al eliminar {typeof(T).Name} con ID {id}: {ex.Message}");
                throw;
            }
        }




    }
}

