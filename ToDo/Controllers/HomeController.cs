// using System.Collections.Generic;
// using System;
// using Microsoft.AspNetCore.Mvc;
// using ToDoList.Models;
// using ToDoList;
//
// namespace ToDoList.Controllers
// {
//     public class HomeController : Controller
//     {
//       [HttpGet("/")]
//       public ActionResult Index()
//       {
//         return View();
//       }
//       [HttpPost("/anagram/results")]
//       public ActionResult Results()
//       {
//         Task newTask = new Task (Request.Form["inputWord"]);
//         newTask.Save();
//         return View (newTask);
//       }
//       }
//     }
