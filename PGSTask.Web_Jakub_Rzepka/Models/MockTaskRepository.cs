using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PGSTask.Web_Jakub_Rzepka.Models
{
    public class MockTaskRepository : ITaskRepository
    {
        private List<Task> _task;

        public MockTaskRepository()
        {
            if (_task == null)
            {
                InitializeTasks();
            }
        }

        private void InitializeTasks()
        {
            _task = new List<Task>
            {
                new Task { Id = 1, Description = "Test", CreatedAt = new DateTime(2019, 5, 1), IsDone=false},
                 new Task { Id = 2, Description = "Test2", CreatedAt = new DateTime(2019, 5, 2), IsDone=false}
            };
        }

        public IEnumerable<Task> GetAllTasks()
        {
            return _task;
        }

        public Task GetTaskById(int taskId)
        {
            return _task.FirstOrDefault(t => t.Id == taskId);
        }
    }
}
