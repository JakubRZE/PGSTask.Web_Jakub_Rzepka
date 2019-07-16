using System;
using System.Collections.Generic;
using System.Linq;

namespace PGSTask.Web_Jakub_Rzepka.Models
{
    public interface IUserTaskRepository
    {
        IEnumerable<UserTask> GetAllTasks();

        UserTask GetTaskById(int taskId);
    }
}
