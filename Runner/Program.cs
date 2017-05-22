using System;
using Lab6;
using SheduleContext;

namespace Runner
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var employeeCtx = new EmployeeContext();
            var positionCtx = new PositionContext();
            var taskCtx = new TaskContext();


            Task task = new Task();
            task.name = "Delete this";
            task.priority = 1;
            task.status = 0;
            task.time = "30 minutes";

            taskCtx.Task.Add(task);
            taskCtx.SaveChanges();

            Employee andrew = new Employee();
            andrew.name = "Andrew";
            andrew.surname = "Yashin";
            andrew.position = positionCtx.Position.Find(1);
            andrew.task.Add(task);
            employeeCtx.Employee.Add(andrew);
            employeeCtx.SaveChanges();

            foreach (var employee in employeeCtx.Employee)
            {
                Console.WriteLine(employee.name);
            }

            foreach (var task1 in taskCtx.Task)
            {
                Console.WriteLine(task1.name);
            }

        }
    }
}