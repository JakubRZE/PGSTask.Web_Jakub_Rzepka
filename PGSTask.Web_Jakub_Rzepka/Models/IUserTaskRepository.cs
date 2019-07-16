using System;
using System.Collections.Generic;
using System.Linq;
using X.PagedList;

namespace PGSTask.Web_Jakub_Rzepka.Models
{
    public interface IUserTaskRepository
    {
        IPagedList<UserTask> GetAllTasks(string column = null, string sortOrder = SortOrder.Asc, string searchString = null, int? page = null);

        void AddTask(UserTask userTask);

        void DeleteTask(int id);

        void EditTask(int id);
    }
}
