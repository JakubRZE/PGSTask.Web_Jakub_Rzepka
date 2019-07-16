using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PGSTask.Web_Jakub_Rzepka.Models
{
    public class MockUserTaskRepository : IUserTaskRepository
    {
        private List<UserTask> _task;

        public MockUserTaskRepository()
        {
            if (_task == null)
            {
                InitializeTasks();
            }
        }

        private void InitializeTasks()
        {
            _task = new List<UserTask>
            {
                new UserTask { Id = 1, Description = "Test", CreatedAt = new DateTime(2019, 5, 1), IsDone=false},
                 new UserTask { Id = 2, Description = "Test2", CreatedAt = new DateTime(2019, 5, 2), IsDone=false}
            };
        }

        public IEnumerable<UserTask> GetAllTasks()
        {
            return _task;
        }

        public UserTask GetTaskById(int taskId)
        {
            return _task.FirstOrDefault(t => t.Id == taskId);
        }
    }
}
