using System;
using System.Collections.Generic;
using CRM.Enums;

namespace CRM.Entities;

public class User
{
    public int UserId { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public Roles Role { get; set; }
    public DateTimeOffset CreatedAt { get; set; }

    public List<Project> ManagedProjects { get; set; } = new();
    public List<Task> AssignedTasks { get; set; } = new();
    public List<Comment> Comments { get; set; } = new();
}