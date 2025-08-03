using SmartWorkspace.Domain.Entities.Common;
using SmartWorkspace.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWorkspace.Domain.Entities.Project
{
    public class TaskComment : BaseEntity
    {
        public string Message { get; set; }

        public Guid TaskItemId { get; set; }
        public TaskItem TaskItem { get; set; }

        public string UserId { get; set; }
        public AppUser User { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
