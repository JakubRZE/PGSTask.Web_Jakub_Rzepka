using PGSTask.Web_Jakub_Rzepka.DAL;
using System;
using System.Collections.Generic;
using System.Linq;


namespace PGSTask.Web_Jakub_Rzepka.Models
{
    public class UserTaskRepository : IUserTaskRepository
    {
        private readonly AppDbContext _appDbContext;

        public UserTaskRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void AddTask(UserTask userTask)
        {
            _appDbContext.Tasks.Add(userTask);
            _appDbContext.SaveChanges();
        }

        public void DeleteTask(int id)
        {
            UserTask task = _appDbContext.Tasks.Find(id);
            _appDbContext.Tasks.Remove(task);
            _appDbContext.SaveChanges();
        }

        public IEnumerable<UserTask> GetAllTasks()
        {
            return _appDbContext.Tasks;
        }

        public UserTask GetTaskById(int taskId)
        {
            return _appDbContext.Tasks.FirstOrDefault(t => t.Id == taskId);
        }

    }
}
