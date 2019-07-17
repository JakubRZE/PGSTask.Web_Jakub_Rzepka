using PGSTask.Web_Jakub_Rzepka.DAL;
using PGSTask.Web_Jakub_Rzepka.Models;
using PGSTask.Web_Jakub_Rzepka.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using X.PagedList;

namespace PGSTask.Web_Jakub_Rzepka.Repositories
{
    public class UserTaskRepository : IUserTaskRepository
    {
        private readonly AppDbContext _appDbContext;

        public UserTaskRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void AddTask(CreateTaskVM userTask)
        {
            _appDbContext.Tasks.Add(new UserTask
            {
                Description = userTask.Description,
            });
            _appDbContext.SaveChanges();
        }

        public void DeleteTask(int id)
        {
            UserTask task = _appDbContext.Tasks.Find(id);
            _appDbContext.Tasks.Remove(task);
            _appDbContext.SaveChanges();
        }

        public void EditTask(int id, string description)
        {
            UserTask task = _appDbContext.Tasks.Find(id);
            task.Description = description;
            _appDbContext.Update(task);
            _appDbContext.SaveChanges();
        }

        public IPagedList<UserTaskVM> GetAllTasks(string column = null, string sortOrder = null, string searchString = null, int? page = null)
        {
            var query =  _appDbContext.Tasks.Select(x => new UserTaskVM
            {
                CreatedAt = x.CreatedAt,
                Description = x.Description,
                Id = x.Id
            }).OrderByDescending(t => t.CreatedAt).AsQueryable();

            if (!String.IsNullOrEmpty(searchString))
            {
                query = query.Where(s => s.Description.ToLower().Contains(searchString.ToLower()));            
            }

            if (column != null)
                query = query.OrderBy(column + " " + sortOrder);

            var pageNumber = page ?? 1;
            return query.ToPagedList(pageNumber, 5);
        }

    }
}
