using System;
using System.Collections.Generic;
using CRM.Entities;
using CRM.Enums;
using Task = CRM.Entities.Task;
using TaskStatus = CRM.Enums.TaskStatus;

namespace CRM.DataContext
{
    public sealed class InitialData
    {
        public static IEnumerable<User> Users() => Data.Users;
        public static IEnumerable<Project> Projects() => Data.Projects;
        public static IEnumerable<Task> Tasks() => Data.Tasks;
        public static IEnumerable<Attachment> Attachments() => Data.Attachments;
        public static IEnumerable<Comment> Comments() => Data.Comments;
    }

    internal class Data
    {
        public static readonly IEnumerable<User> Users = new List<User>
        {
            new User
            {
                UserId = 1, FirstName = "Иван", LastName = "Петров", Email = "ivan@example.com",
                PasswordHash = "password1", Role = Roles.Admin
            },
            new User
            {
                UserId = 2, FirstName = "Мария", LastName = "Иванова", Email = "maria@example.com",
                PasswordHash = "password2", Role = Roles.Manager
            },
            new User
            {
                UserId = 3, FirstName = "Сергей", LastName = "Сидоров", Email = "sergey@example.com",
                PasswordHash = "password3", Role = Roles.Employee
            },
            new User
            {
                UserId = 4, FirstName = "Александр", LastName = "Смирнов", Email = "alexander@example.com",
                PasswordHash = "password4", Role = Roles.Manager
            },
            new User
            {
                UserId = 5, FirstName = "Ольга", LastName = "Козлова", Email = "olga@example.com",
                PasswordHash = "password5", Role = Roles.Employee
            },
            new User
            {
                UserId = 6, FirstName = "Дмитрий", LastName = "Лебедев", Email = "dmitriy@example.com",
                PasswordHash = "password6", Role = Roles.Employee
            },
            new User
            {
                UserId = 7, FirstName = "Екатерина", LastName = "Морозова", Email = "ekaterina@example.com",
                PasswordHash = "password7", Role = Roles.Manager
            },
            new User
            {
                UserId = 8, FirstName = "Владимир", LastName = "Новиков", Email = "vladimir@example.com",
                PasswordHash = "password8", Role = Roles.Employee
            },
            new User
            {
                UserId = 9, FirstName = "Алина", LastName = "Федорова", Email = "alina@example.com",
                PasswordHash = "password9", Role = Roles.Employee
            },
            new User
            {
                UserId = 10, FirstName = "Максим", LastName = "Соловьев", Email = "maksim@example.com",
                PasswordHash = "password10", Role = Roles.Employee
            }
        };

        public static readonly IEnumerable<Project> Projects = new List<Project>
        {
            new Project
            {
                ProjectId = 1, ProjectName = "Разработка CRM-системы", StartDate = new DateTime(2024, 1, 1),
                EndDate = new DateTime(2024, 12, 31), ProjectStatus = ProjectStatus.Active, ManagerId = 2
            },
            new Project
            {
                ProjectId = 2, ProjectName = "Модернизация веб-сайта", StartDate = new DateTime(2024, 6, 1),
                EndDate = new DateTime(2024, 8, 31), ProjectStatus = ProjectStatus.Completed, ManagerId = 2
            },
            new Project
            {
                ProjectId = 3, ProjectName = "Разработка мобильного приложения", StartDate = new DateTime(2024, 5, 1),
                EndDate = new DateTime(2024, 11, 30), ProjectStatus = ProjectStatus.OnHold, ManagerId = 4
            },
            new Project
            {
                ProjectId = 4, ProjectName = "Автоматизация отчетов", StartDate = new DateTime(2024, 4, 1),
                EndDate = new DateTime(2024, 10, 1), ProjectStatus = ProjectStatus.Active, ManagerId = 7
            },
            new Project
            {
                ProjectId = 5, ProjectName = "Создание онлайн-платформы", StartDate = new DateTime(2024, 3, 1),
                EndDate = new DateTime(2024, 12, 1), ProjectStatus = ProjectStatus.Active, ManagerId = 7
            },
            new Project
            {
                ProjectId = 6, ProjectName = "Внедрение ERP-системы", StartDate = new DateTime(2024, 7, 1),
                EndDate = new DateTime(2024, 12, 31), ProjectStatus = ProjectStatus.Active, ManagerId = 2
            },
            new Project
            {
                ProjectId = 7, ProjectName = "Обновление системы безопасности", StartDate = new DateTime(2024, 1, 15),
                EndDate = new DateTime(2024, 10, 1), ProjectStatus = ProjectStatus.OnHold, ManagerId = 4
            },
            new Project
            {
                ProjectId = 8, ProjectName = "Интеграция платежных систем", StartDate = new DateTime(2024, 5, 20),
                EndDate = new DateTime(2024, 11, 1), ProjectStatus = ProjectStatus.Active, ManagerId = 2
            },
            new Project
            {
                ProjectId = 9, ProjectName = "Анализ данных клиентов", StartDate = new DateTime(2024, 6, 10),
                EndDate = new DateTime(2024, 12, 2), ProjectStatus = ProjectStatus.Completed, ManagerId = 7
            },
            new Project
            {
                ProjectId = 10, ProjectName = "Разработка внутренней платформы", StartDate = new DateTime(2024, 2, 1),
                EndDate = new DateTime(2024, 10, 1), ProjectStatus = ProjectStatus.Completed, ManagerId = 4
            }
        };

        public static readonly IEnumerable<Task> Tasks = new List<Task>
        {
            new Task
            {
                TaskId = 1, TaskName = "Создать макет интерфейса", Description = "Макет для CRM-системы",
                StartDate = new DateTime(2024, 1, 1), EndDate = new DateTime(2024, 1, 10),
                Status = TaskStatus.InProgress, ProjectId = 1, AssignedToId = 6
            },
            new Task
            {
                TaskId = 2, TaskName = "Собрать требования", Description = "Требования для веб-сайта",
                StartDate = new DateTime(2024, 6, 10), EndDate = new DateTime(2024, 6, 15),
                Status = TaskStatus.Completed, ProjectId = 2, AssignedToId = 5
            },
            new Task
            {
                TaskId = 3, TaskName = "Разработка архитектуры", Description = "Архитектура для мобильного приложения",
                StartDate = new DateTime(2024, 5, 15), EndDate = new DateTime(2024, 6, 1),
                Status = TaskStatus.Completed, ProjectId = 3, AssignedToId = 9
            },
            new Task
            {
                TaskId = 4, TaskName = "Анализ требований", Description = "Требования для системы безопасности",
                StartDate = new DateTime(2024, 1, 15), EndDate = new DateTime(2024, 2, 1),
                Status = TaskStatus.Completed, ProjectId = 7, AssignedToId = 5
            },
            new Task
            {
                TaskId = 5, TaskName = "Разработка модуля отчетности",
                Description = "Модуль отчетности для ERP-системы", StartDate = new DateTime(2024, 7, 10),
                EndDate = new DateTime(2024, 8, 1), Status = TaskStatus.InProgress, ProjectId = 6, AssignedToId = 3
            },
            new Task
            {
                TaskId = 6, TaskName = "Тестирование безопасности", Description = "Тесты для системы безопасности",
                StartDate = new DateTime(2024, 8, 10), EndDate = new DateTime(2024, 8, 15),
                Status = TaskStatus.InProgress, ProjectId = 7, AssignedToId = 4
            },
            new Task
            {
                TaskId = 7, TaskName = "Создание аналитического отчета",
                Description = "Отчет для анализа данных клиентов", StartDate = new DateTime(2024, 6, 20),
                EndDate = new DateTime(2024, 7, 10), Status = TaskStatus.Completed, ProjectId = 9, AssignedToId = 2
            },
            new Task
            {
                TaskId = 8, TaskName = "Обновление системы", Description = "Обновление внутренней платформы",
                StartDate = new DateTime(2024, 3, 1), EndDate = new DateTime(2024, 4, 1), Status = TaskStatus.Completed,
                ProjectId = 10, AssignedToId = 4
            },
            new Task
            {
                TaskId = 9, TaskName = "Анализ данных", Description = "Анализ данных для проекта CRM",
                StartDate = new DateTime(2024, 1, 1), EndDate = new DateTime(2024, 12, 31),
                Status = TaskStatus.InProgress, ProjectId = 1, AssignedToId = 2
            },
            new Task
            {
                TaskId = 10, TaskName = "Интеграция API", Description = "Интеграция API для онлайн-платформы",
                StartDate = new DateTime(2024, 7, 1).ToUniversalTime(), EndDate = new DateTime(2024, 9, 1), Status = TaskStatus.Assigned,
                ProjectId = 5, AssignedToId = 3
            }
        };

        public static readonly IEnumerable<Attachment> Attachments = new List<Attachment>
        {
            new Attachment { AttachmentId = 1, FilePath = "/uploads/mockup.png", TaskId = 1 },
            new Attachment { AttachmentId = 2, FilePath = "/uploads/requirements.docx", TaskId = 2 },
            new Attachment { AttachmentId = 3, FilePath = "/uploads/architecture.pdf", TaskId = 3 },
            new Attachment { AttachmentId = 4, FilePath = "/uploads/security_analysis.pdf", TaskId = 4 },
            new Attachment { AttachmentId = 5, FilePath = "/uploads/report.docx", TaskId = 7 },
            new Attachment { AttachmentId = 6, FilePath = "/uploads/system_update.docx", TaskId = 8 },
            new Attachment { AttachmentId = 7, FilePath = "/uploads/data_analysis.xlsx", TaskId = 9 },
            new Attachment { AttachmentId = 8, FilePath = "/uploads/api_integration.pdf", TaskId = 10 },
            new Attachment { AttachmentId = 9, FilePath = "/uploads/reports.pdf", TaskId = 5 }
        };

        public static readonly IEnumerable<Comment> Comments = new List<Comment>
        {
            new Comment { CommentId = 1, Text = "Отличный макет интерфейса!", TaskId = 1, UserId = 1 },
            new Comment { CommentId = 2, Text = "Нужны дополнительные требования.", TaskId = 2, UserId = 3 },
            new Comment { CommentId = 3, Text = "Архитектура выглядит хорошо.", TaskId = 3, UserId = 2 },
            new Comment { CommentId = 4, Text = "Требуются улучшения в системе безопасности.", TaskId = 4, UserId = 1 },
            new Comment { CommentId = 5, Text = "Отчет готов, жду вашего фидбека.", TaskId = 7, UserId = 4 },
            new Comment { CommentId = 6, Text = "Система обновлена успешно.", TaskId = 8, UserId = 5 },
            new Comment { CommentId = 7, Text = "Анализ данных завершен.", TaskId = 9, UserId = 6 },
            new Comment { CommentId = 8, Text = "API интегрирован.", TaskId = 10, UserId = 3 }
        };
    }
}