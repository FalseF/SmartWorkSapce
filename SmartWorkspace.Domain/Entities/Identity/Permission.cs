using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWorkspace.Domain.Entities.Identity
{
    public class Permission
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Module { get; set; }
    }
}
