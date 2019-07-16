using System;
using System.Collections.Generic;
using System.Linq;

namespace PGSTask.Web_Jakub_Rzepka.Models
{
    public interface IUserTaskRepository
    {
        IEnumerable<UserTask> GetAllTasks(string column = null, string sortOrder = SortOrder.Asc, string searchString = null);

        UserTask GetTaskById(int taskId);

        void AddTask(UserTask userTask);

        void DeleteTask(int id);
    }
}
