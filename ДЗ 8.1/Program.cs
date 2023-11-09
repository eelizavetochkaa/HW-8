using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_8._1
{
    public enum ProjectStatus
    {
        Project,
        Execution,
        Closed
    }

    public enum TaskStatus
    {
        Assigned,
        InProgress,
        Review,
        Completed
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем список людей
            List<Person> people = new List<Person>();
            for (int i = 0; i < 10; i++)
            {
                people.Add(new Person { Name = $"Человек{i}" });
            }

            // Создаем проект
            Project project = new Project
            {
                Description = "Первый проект",
                DueDate = DateTime.Now.AddDays(7),
                Initiator = people[0],
                TeamLead = people[1],
                Tasks = new List<Task>(),
                Status = ProjectStatus.Project
            };

            // Создаем задачи
            for (int i = 0; i < 5; i++)
            {
                Task task = new Task
                {
                    Description = $"Задача {i}",
                    DueDate = DateTime.Now.AddDays(i + 1),
                    Initiator = project.TeamLead,
                    Assignee = people[i + 2],
                    Status = TaskStatus.Assigned,
                    Report = new Report
                    {
                        Text = $"Отчёт о задаче {i}",
                        Date = DateTime.Now,
                        Assignee = people[i + 2]
                    }
                };

                project.Tasks.Add(task);
            }

            // Выводим информацию о проекте и задачах
            Console.WriteLine($"Проект: {project.Description}, Срок: {project.DueDate}, Инициатор: {project.Initiator.Name}, Исполнитель: {project.TeamLead.Name}, Статус: {project.Status}");
            foreach (var task in project.Tasks)
            {
                Console.WriteLine($"Задача: {task.Description}, Срок: {task.DueDate}, Инициатор: {task.Initiator.Name}, Исполнитель: {task.Assignee.Name}, Статус: {task.Status},Отчёт: {task.Report.Text}");
            }
            Console.ReadKey();
        }
    }
}
