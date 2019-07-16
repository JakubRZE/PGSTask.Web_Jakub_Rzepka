using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PGSTask.Web_Jakub_Rzepka.Models;
using PGSTask.Web_Jakub_Rzepka.ViewModels;
using System.Linq.Dynamic;

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
        public ActionResult Index(string column = null, string sortOrder = null, string searchString = null)
        {
            var tasksVM = new UserTaskViewModel();

            tasksVM.SortOrder = sortOrder;
            var tasks = _userTaskRepository.GetAllTasks(column, sortOrder, searchString);

            tasksVM.Tasks = tasks.ToList();
            

            tasksVM.CurrentColumn = column;
            tasksVM.CurrentFilter = searchString;

            return View(tasksVM);
        }


        // POST: Task/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(
             [Bind("Description")] UserTaskViewModel model)
        {
            if (ModelState.IsValid)
            {
                UserTask newTask = new UserTask
                {
                    Description = model.Description,
                };
                _userTaskRepository.AddTask(newTask);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        // GET: Task/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Task/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
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