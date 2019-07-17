using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PGSTask.Web_Jakub_Rzepka.Models;
using PGSTask.Web_Jakub_Rzepka.ViewModels;
using System.Linq.Dynamic;
using PGSTask.Web_Jakub_Rzepka.Repositories;

namespace PGSTask.Web_Jakub_Rzepka.Controllers
{
    public class UserTaskController : Controller
    {
        private readonly IUserTaskRepository _userTaskRepository;

        public UserTaskController(IUserTaskRepository userTaskRepository)
        {
            _userTaskRepository = userTaskRepository;
        }

        // GET: Task
        public ActionResult Index(string column = null, string sortOrder = null, string searchString = null, int? page = null)
        {
            var tasksVM = new UserTasksVM();

            tasksVM.SortOrder = sortOrder;
            tasksVM.Tasks = _userTaskRepository.GetAllTasks(column, sortOrder, searchString, page);

            tasksVM.CurrentColumn = column;
            tasksVM.CurrentFilter = searchString;

            return View(tasksVM);
        }


        // POST: Task/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Description")] CreateTaskVM model)
        {
            if (ModelState.IsValid)
                _userTaskRepository.AddTask(model);
            
            return RedirectToAction("Index");
        }

        // POST: Task/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult Edit(int id, string description)
        {
            if (!String.IsNullOrEmpty(description))
            {
                _userTaskRepository.EditTask(id, description);

                return Json(new { success = true, responseText = id });
            }
            return Json(new { success = false, responseText = id });
        }

        // POST: Task/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _userTaskRepository.DeleteTask(id);
            return RedirectToAction("Index");
        }
    }
}