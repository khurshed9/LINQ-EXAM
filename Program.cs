using System;
using CRM.DataContext;
using CRM.Entities;
using CRM.Enums;
using Task = CRM.Entities.Task;
using TaskStatus = CRM.Enums.TaskStatus;

DataContext db = new DataContext();

//1
var query1 = from u in db.Users
    join p in db.Projects on u.UserId equals p.ManagerId
    join t in db.Tasks on p.ProjectId equals t.ProjectId
    where t.AssignedToId > 5
    select new
    {
        p.ProjectId,
        p.ProjectName,
        TotalAmount = t.AssignedToId
    };

foreach (var t1 in query1)
{
    Console.WriteLine(t1.ProjectId + " " + t1.ProjectName  + " " + t1.TotalAmount);
}

//2
/*var query2 = from t in db.Tasks
    join c in db.Comments on t.TaskId equals c.TaskId
    where db.Comments.Count() > 3 && (DateTime.Now.Month - 2) >= c.CreatedAt.Month
    select t;

foreach (var i in query2)
{
    Console.WriteLine(i.TaskId + " " + i.TaskName + " " + i.Status);
}*/


//3
/*var query3 = from u in db.Users
    join p in db.Projects on u.UserId equals p.ManagerId
    where p.CreatedAt >= DateTime.Today.AddYears(-1)
    group u by u.UserId into g
    select new
    {
        UserId =g.Key,
        CurrentProject = g.Count()
    };

foreach (var t in query3)
{
    Console.WriteLine(t.UserId + " " + t.CurrentProject);
}*/

//5
/*var query5 = db.Projects.Where(x => x.ProjectStatus == ProjectStatus.Completed).ToList();

foreach (var t5 in query5)
{
    Console.WriteLine(t5.ProjectId + " " + t5.ProjectName + " " + t5.ProjectStatus);
}*/

//6
/*var query6 = from u in db.Users
    join p in db.Projects on u.UserId equals p.ManagerId
    join t in db.Tasks on p.ProjectId equals t.ProjectId
    where u.UserId != p.ManagerId && p.ProjectId != t.ProjectId
    select u;

foreach (var t6 in query6)
{
    Console.WriteLine(t6.UserId + " " + t6.FirstName + " " + t6.LastName + " " + t6.Role);
}
*/


//7
/*var comments = db.Tasks.Where(t => !(t.Status == TaskStatus.InProgress)).SelectMany(t => t.Comments) 
    .OrderBy(c => c.CreatedAt) 
    .ToList();

foreach (var comment in comments)
{
    Console.WriteLine($"{comment.CreatedAt}: {comment.Text}");
}*/

//8
/*var query8 = from p in db.Projects
    join t in db.Tasks on p.ProjectId equals t.ProjectId
    group t by p
    into g
    select new
    {
        g.Key.ProjectName,
        Average = g.Count() / (decimal)g.Key.ProjectId
    };

foreach (var t8 in query8)
{
    Console.WriteLine(t8.ProjectName + "  " + t8.Average);
}*/

//9
/*
var query9 = from u in db.Users
    join p in db.Projects on u.UserId equals p.ManagerId
    join t in db.Tasks on p.ProjectId equals t.ProjectId
    where t.Status == TaskStatus.InProgress && db.Tasks.Count() > 2
    group t by u
    into g
    select new
    {
        g.Key.FirstName,
        g.Key.LastName,
        Amount = g.Count()
    };

foreach (var t9 in query9)
{
    Console.WriteLine(t9.FirstName + " " + t9.LastName + "  " + t9.Amount);
}*/


//10
/*var query10 = from p in db.Projects
    join t in db.Tasks on p.ProjectId equals t.ProjectId into tasks
    from t in tasks
    join t2 in db.Tasks on t.TaskId equals t2.TaskId into tasks2
    from t2 in tasks2
    where t.EndDate > t.CreatedAt && t.EndDate < t2.CreatedAt
    select p;

foreach (var t10 in query10)
{
    Console.WriteLine(t10.ProjectId + " " + t10.ProjectName + " "  + t10.CreatedAt);
}*/

