using System;
using System.Collections.Generic;
using TaskStatus = CRM.Enums.TaskStatus;

namespace CRM.Entities;

public class Task
{
    public int TaskId { get; set; }
    public string TaskName { get; set; } = string.Empty;
    public string? Description { get; set; }
    public DateTimeOffset StartDate { get; set; }
    public DateTimeOffset? EndDate { get; set; }
    public TaskStatus Status { get; set; }
    public DateTimeOffset CreatedAt { get; set; }

    public int ProjectId { get; set; }
    public Project Project { get; set; } = null!;

    public int? AssignedToId { get; set; }
    public User? AssignedTo { get; set; }

    public List<Comment> Comments { get; set; } = new();
    public List<Attachment> Attachments { get; set; } = new();
}