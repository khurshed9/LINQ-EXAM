using System;
using CRM.Entities;
using Microsoft.EntityFrameworkCore;
using Task = CRM.Entities.Task;

namespace CRM.DataContext;

public sealed class DataContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Task> Tasks { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<Attachment> Attachments { get; set; }

    public DataContext()
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=linq_db;Username=postgres;Password=Galchaew05;")
            //.LogTo(Console.WriteLine)
            .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(InitialData.Users());
        modelBuilder.Entity<Task>().HasData(InitialData.Tasks());
        modelBuilder.Entity<Attachment>().HasData(InitialData.Attachments());
        modelBuilder.Entity<Project>().HasData(InitialData.Projects());
        modelBuilder.Entity<Comment>().HasData(InitialData.Comments());
        base.OnModelCreating(modelBuilder);
    }
}