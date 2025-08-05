using Entity.Dtos.BaseDtos;
using Entity.Model;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers.Interfaces
{
    public interface IBaseController<T, D> where T : Base where D : BaseDto
    {
        Task<IActionResult> GetAll();
        Task<IActionResult> GetById(int id);
        Task<IActionResult> Create(D dto);
        Task<IActionResult> Update(D dto);
        Task<IActionResult> Delete(int id);
    }
}