using System;

namespace CRM.Entities;

public class Attachment
{
    public int AttachmentId { get; set; }
    public string FilePath { get; set; } = string.Empty;
    public DateTimeOffset UploadedAt { get; set; } 

    public int TaskId { get; set; }
    public Task Task { get; set; } = null!;
}