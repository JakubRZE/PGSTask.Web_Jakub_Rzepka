using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PGSTask.Web_Jakub_Rzepka.Models
{
    public interface ITaskRepository
    {
        IEnumerable<Task> GetAllTasks();

        Task GetTaskById(int taskId);
    }
}
