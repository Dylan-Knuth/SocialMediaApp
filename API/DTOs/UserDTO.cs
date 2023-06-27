using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;

namespace API.DTOs
{
    public class UserDTO
    {

        public string UserName { get; set; }

        public string Token { get; set; }
        
    }
}