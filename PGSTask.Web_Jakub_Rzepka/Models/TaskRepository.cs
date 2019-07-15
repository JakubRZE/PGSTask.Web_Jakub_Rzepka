using PGSTask.Web_Jakub_Rzepka.DAL;
using System;
using System.Collections.Generic;
using System.Linq;


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
            return _appDbContext.Tasks;
        }

        public Task GetTaskById(int taskId)
        {
            return _appDbContext.Tasks.FirstOrDefault(t => t.Id == taskId);
        }
    }
}
