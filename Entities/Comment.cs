using System;

namespace CRM.Entities;

public class Comment
{
    public int CommentId { get; set; }
    public string Text { get; set; } = string.Empty;
    public DateTimeOffset CreatedAt { get; set; } 

    public int TaskId { get; set; }
    public Task Task { get; set; } = null!;

    public int UserId { get; set; }
    public User User { get; set; } = null!;
}