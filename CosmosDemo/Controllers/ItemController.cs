using System;
using System.Threading.Tasks;
using CosmosDemo.Services;
using Microsoft.AspNetCore.Mvc;
using CosmosDemo.Models;
using System.Collections.Generic;
using System.Linq;

namespace CosmosDemo.Controllers
{
    public class ItemController : Controller
    {
        private readonly ICosmosDbService _cosmosDbService;
        public ItemController(ICosmosDbService cosmosDbService)
        {
            _cosmosDbService = cosmosDbService;
        }

        [ActionName("Index")]
        public async Task<IActionResult> Index()
        {
            return View(await _cosmosDbService.GetItemsAsync("SELECT * FROM c"));
        }

        [ActionName("Create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAsync([Bind("Id,ProjectName,Manager,Active")] Item item)
        {
            if (ModelState.IsValid)
            {
                item.Id = Guid.NewGuid().ToString();
                await _cosmosDbService.AddItemAsync(item);
                return RedirectToAction("Index");
            }

            return View(item);
        }

        [HttpPost]
        [ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAsync([Bind("Id,ProjectName,Manager,Active")] Item item)
        {
            Item getItem = await _cosmosDbService.GetItemAsync(item.Id);

            item.ProjectTask.AddRange(getItem.ProjectTask);

            if (ModelState.IsValid)
            {
                await _cosmosDbService.UpdateItemAsync(item.Id, item);
                return RedirectToAction("Index");
            }

            return View(item);
        }

        [ActionName("Edit")]
        public async Task<ActionResult> EditAsync(string id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            Item item = await _cosmosDbService.GetItemAsync(id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        [ActionName("Delete")]
        public async Task<ActionResult> DeleteAsync(string id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            Item item = await _cosmosDbService.GetItemAsync(id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmedAsync([Bind("Id")] string id)
        {
            await _cosmosDbService.DeleteItemAsync(id);
            return RedirectToAction("Index");
        }

        [ActionName("Details")]
        public async Task<ActionResult> DetailsAsync(string id)
        {
            return View(await _cosmosDbService.GetItemAsync(id));
        }

        #region Tasks
        [ActionName("Tasks")]
        public async Task<ActionResult> TasksAsync(string id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            string sql = @"SELECT VALUE c.tasks FROM c WHERE c.id = @ID";

            //List<ProjectTask> task = await _cosmosDbService.GetItemAsync("");
            //if (task == null)
            //{
            //    return NotFound();
            //}
            ViewBag.Id = id;

            return View(await _cosmosDbService.GetTasksAsync(sql, id));
        }

        [ActionName("CreateTask")]
        public IActionResult CreateTask(string id)
        {
            ViewBag.Id = id;
            return View();
        }

        [HttpPost]
        [ActionName("CreateTask")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateTaskAsync([Bind("TaskId,TaskName,AssignedTo,Status")] ProjectTask projectTask, string id)
        {
            projectTask.TaskId = Guid.NewGuid().ToString();
            Item item = await _cosmosDbService.GetItemAsync(id);
            item.ProjectTask.Add(projectTask);
        
            if (ModelState.IsValid)
            {

                await _cosmosDbService.UpdateItemAsync(id, item);
                return RedirectToAction("Tasks", new { id});
            }

            return View(projectTask);
        }

        [HttpPost]
        [ActionName("EditTask")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditTaskAsync([Bind("TaskId, TaskName,AssignedTo,Status")] ProjectTask pTask, string id)
        {

            Item item = await _cosmosDbService.GetItemAsync(id);
            item.ProjectTask.ToList()
                .Where(a => a.TaskId == pTask.TaskId).ToList().ForEach(b =>
                {
                    b.TaskId = pTask.TaskId;
                    b.TaskName = pTask.TaskName;
                    b.AssignedTo = pTask.AssignedTo;
                    b.Status = pTask.Status;
                });

            if (ModelState.IsValid)
            {
                await _cosmosDbService.UpdateItemAsync(id, item);
                return RedirectToAction("Tasks", new { id });
            }

            return View(pTask);
        }

        [ActionName("EditTask")]
        public async Task<ActionResult> EditTaskAsync(string id, string taskId)
        {
            if (id == null)
            {
                return BadRequest();
            }

            Item item = await _cosmosDbService.GetItemAsync(id);
            ProjectTask projectTask = item.ProjectTask.Where(a => a.TaskId == taskId).FirstOrDefault();

            if (projectTask == null)
            {
                return NotFound();
            }

            ViewBag.Id = id;

            return View(projectTask);
        }

        [ActionName("DeleteTask")]
        public async Task<ActionResult> DeleteTaskAsync(string id, string taskId)
        {
            if (id == null)
            {
                return BadRequest();
            }
            Item item = await _cosmosDbService.GetItemAsync(id);
            ProjectTask projectTask = item.ProjectTask.Where(a => a.TaskId == taskId).FirstOrDefault();

            //ProjectTask projectTask = await _cosmosDbService.GetTaskAsync(id);
            if (projectTask == null)
            {
                return NotFound();
            }
            ViewBag.Id = id;

            return View(projectTask);
        }

        [HttpPost]
        [ActionName("DeleteTask")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteTaskConfirmedAsync([Bind("TaskId")] string TaskId, string id)
        {

            Item item = await _cosmosDbService.GetItemAsync(id);
            item.ProjectTask =
             item.ProjectTask.ToList()
              .Where(a => a.TaskId != TaskId).ToList();

            if (ModelState.IsValid)
            {
                await _cosmosDbService.UpdateItemAsync(id, item);
                return RedirectToAction("Tasks", new { id });
            }

            return RedirectToAction("Tasks", new { id, TaskId });
        }

        [ActionName("DetailsTask")]
        public async Task<ActionResult> DetailsTaskAsync(string id, string taskId)
        {

            if (id == null)
            {
                return BadRequest();
            }

            Item item = await _cosmosDbService.GetItemAsync(id);
            ProjectTask projectTask = item.ProjectTask.Where(a => a.TaskId == taskId).FirstOrDefault();

            if (projectTask == null)
            {
                return NotFound();
            }

            ViewBag.Id = id;

            return View(projectTask);

            //return View(await _cosmosDbService.GetTaskAsync(id));
        }

        #endregion
    }
}