using SmartWorkspace.Domain.Entities.Common;
using SmartWorkspace.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWorkspace.Domain.Entities.Project
{
    public class Notification : BaseEntity
    {
        public string UserId { get; set; }
        public AppUser User { get; set; }

        public string Title { get; set; }
        public string Message { get; set; }

        public bool IsRead { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
