using System;
using System.Collections.Generic;
using CRM.Enums;

namespace CRM.Entities;

public class Project
{
    public int ProjectId { get; set; }
    public string ProjectName { get; set; } = string.Empty;
    public DateTimeOffset StartDate { get; set; }
    public DateTimeOffset? EndDate { get; set; }
    public ProjectStatus ProjectStatus { get; set; }
    public DateTimeOffset CreatedAt { get; set; }

    public int ManagerId { get; set; }
    public User Manager { get; set; } = null!;

    public List<Task> Tasks { get; set; } = new();
}