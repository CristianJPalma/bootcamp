using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitis.Interfaces
{
    public interface IValidationHelpers
    {
        //Verifica si el numero de telefono es valido
        /// <param name="phoneNumber">El número de teléfono a validar</param>
        /// <returns>True si es válido, False en caso contrario</returns>
        bool IsValidPhoneNumber(string phoneNumbe);
    }
}
