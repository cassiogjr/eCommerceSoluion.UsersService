using eCommerce.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Core.ServiceContracts
{
    internal interface IUserServices
    {
       Task<AuthenticationResponse?> Login(LoginRequest loginRequest);

       Task<AuthenticationResponse?> Register(RegisterRequest registerRequest);

    }
}
