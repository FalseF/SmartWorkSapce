using SmartWorkspace.Domain.Entities.Common;
using SmartWorkspace.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWorkspace.Domain.Entities.Project
{
    public class TaskItem : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public Guid ProjectId { get; set; }
        public Project Project { get; set; }

        public string AssignedToId { get; set; }
        public AppUser AssignedTo { get; set; }

        public TaskStatus Status { get; set; } = TaskStatus.ToDo;

        public DateTime? DueDate { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }

        public ICollection<TaskComment> Comments { get; set; }
    }
}
