using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Dtos;
using Entity.Model;

namespace Data.Interfaces
{
    public interface ICardData : IBaseModelData<Card, CardDto>
    {
    }
}
