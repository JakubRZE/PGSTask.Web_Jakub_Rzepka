using PGSTask.Web_Jakub_Rzepka.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PGSTask.Web_Jakub_Rzepka.Models
{
    public class TaskRepository : ITaskRepository
    {
        private readonly AppDbContext _appDbContext;

        public TaskRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Task> GetAllTasks()
        {
            throw new NotImplementedException();
        }

        public Task GetTaskById(int taskId)
        {
            throw new NotImplementedException();
        }
    }
}
