using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWorkspace.Domain.Entities.Identity
{
    public class RolePermission
    {
        public int Id { get; set; }
        public string RoleId { get; set; }
        public int PermissionId { get; set; }

        public AppRole Role { get; set; }
        public Permission Permission { get; set; }
    }
}
