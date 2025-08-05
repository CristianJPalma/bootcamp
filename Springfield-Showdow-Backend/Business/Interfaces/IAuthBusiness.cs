using System.Threading.Tasks;
using Entity.Dtos;
using Entity.Model;


namespace Business.Interfaces
{
    /// <summary>
    /// Define los m�todos y operaciones de autenticaci�n disponibles en el sistema.
    /// </summary>
    public interface IAuthBusiness
    {
        /// <summary>
        /// Autentica a un usuario utilizando sus credenciales y genera un token JWT.
        /// </summary>
        /// <param name="credenciales">Objeto que contiene el correo electr�nico y la contrase�a del usuario.</param>
        /// <returns>Un objeto AuthDto que contiene el token JWT y su fecha de expiraci�n.</returns>
        Task<AuthDto> LoginAsync(CredencialesDto credenciales);
       
    }
}
