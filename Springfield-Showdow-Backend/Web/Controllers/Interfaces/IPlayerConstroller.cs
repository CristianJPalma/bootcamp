using Entity.Dtos;
using Entity.Model;
using Web.Controllers.Implements;

namespace Web.Controllers.Interfaces
{
    public interface IPlayerController : IBaseController<Player, PlayerDto>
    {
    }
}
