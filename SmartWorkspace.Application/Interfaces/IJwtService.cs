using SmartWorkspace.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWorkspace.Application.Interfaces
{
    public interface IJwtService
    {
        string GenerateToken(AppUser user, IList<string> roles);
    }
}
