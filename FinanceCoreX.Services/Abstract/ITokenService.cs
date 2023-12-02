using FinanceCoreX.Core.Entities;
using FinanceCoreX.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceCoreX.Services.Abstract
{
    public interface ITokenService
    {
        TokenDto CreateToken(User user);
    }
}
