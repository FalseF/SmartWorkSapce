using SmartWorkspace.Domain.Entities.Common;
using SmartWorkspace.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWorkspace.Domain.Entities.Project
{
    public class Project : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public string CreatedById { get; set; }
        public AppUser CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }

        public ICollection<TaskItem> Tasks { get; set; }
    }
}
