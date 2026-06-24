using Microsoft.EntityFrameworkCore;
using StudentCodeFirst.Models;

var builder = new DbContextOptionsBuilder<SchoolContext>();
builder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=StudentCodeFirstDb;Trusted_Connection=True;MultipleActiveResultSets=true");

using var context = new SchoolContext(builder.Options);

context.Database.EnsureCreated();

if (!context.Students.Any())
{
    context.Students.Add(new Student { FirstName = "Alice", LastName = "Johnson", EnrollmentDate = DateTime.Now });
    context.SaveChanges();
    Console.WriteLine("Added student Alice Johnson.");
}
else
{
    Console.WriteLine($"Students already exist: {context.Students.Count()}");
}

var students = context.Students.ToList();
foreach (var s in students)
{
    Console.WriteLine($"{s.StudentId}: {s.FirstName} {s.LastName} ({s.EnrollmentDate:d})");
}
