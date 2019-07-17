using PGSTask.Web_Jakub_Rzepka.Models;
using PGSTask.Web_Jakub_Rzepka.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using X.PagedList;

namespace PGSTask.Web_Jakub_Rzepka.Repositories
{
    public interface IUserTaskRepository
    {
        IPagedList<UserTaskVM> GetAllTasks(string column = null, string sortOrder = SortOrder.Asc, string searchString = null, int? page = null);

        void AddTask(CreateTaskVM userTask);

        void DeleteTask(int id);

        void EditTask(int id, string description);
    }
}
