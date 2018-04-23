using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using WebApiDemo.Services;

namespace WebApiDemo.Controllers
{
    [EnableCors("AllowAllOrigin")]
    [Route("task")]
    public class TaskController : Controller
    {
        [Route("list")]
        [HttpGet]
        public IActionResult GetTasksList([FromServices] TaskManager taskManager)
        {
            return Json(taskManager.GetAllTasks());
        }
    }
}