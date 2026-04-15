using System;
using System.Linq;

class Prog
{
    static void Main()
    {
        var employees = new[]
        {
            new
            {
                Name = "Иван Петров",
                Department = "IT",
                Skills = new[] {"C#", "SQL", "Azure", "Git"}
            },

            new
            {
                Name = "Анна Смирнова",
                Department = "HR",
                Skills = new[] { "Recruiting", "Excel", "Communication" }
            },

            new
            {
                Name = "Петр Сидоров",
                Department = "IT",
                Skills = new[] { "Python", "SQL", "Docker" }
            },

            new
            {
                Name = "Мария Козлова",
                Department = "Marketing",
                Skills = new[] { "SEO", "Content", "Analytics", "Social Media" }
            },

            new
            {
                Name = "Дмитрий Новиков",
                Department = "IT",
                Skills = new[] { "JavaScript", "React", "Node.js", "Git" }
            }
        };

        var allSkills = employees
            .SelectMany(e => e.Skills)
            .Distinct()
            .OrderBy(s => s)
            .ToArray();

        Console.WriteLine("Навыки: " + string.Join(", ", allSkills));
    }
}