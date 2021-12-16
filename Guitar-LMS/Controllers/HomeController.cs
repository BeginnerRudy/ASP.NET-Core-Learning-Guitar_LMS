using System;
using System.Collections.Generic;
using System.Linq;
using Guitar_LMS.Models;
using Guitar_LMS.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Guitar_LMS.Controllers {
    [Route("[controller]/[action]")]
    public class HomeController : Controller{
        IGuitarRepository guitarRepository;

        public HomeController(IGuitarRepository guitarRepository) {
            this.guitarRepository = guitarRepository;
        }

        [Route("~/")]
        [Route("")]
        public IActionResult Index() {
            return View();
        }

        [HttpGet]
        [Route("{dateStr}")]
        public ActionResult isDone(string dateStr) {
            bool isValid = false;
            var guitarPracticeCard = guitarRepository.GetGuitarPracticeCard(dateStr);
            bool allDone = true;
            if (guitarPracticeCard != null && guitarPracticeCard.TodoList.Count != 0) {
                foreach (TodoListItem item in guitarPracticeCard.TodoList){
                    if (!item.IsDone) {
                        allDone = false;
                        break;
                    }
                }
                isValid = allDone;
            }
            var obj = new {
                valid = isValid
            };
            return Json(obj);
        }

        [Route("{dateStr}")]
        public IActionResult ToDoList(string dateStr) {
            var model = new TodoListViewModel();
            model.DateStr = dateStr;
            GuitarPracticeCard guitarPracticeCardChanges = guitarRepository.GetGuitarPracticeCard(dateStr);
            if (guitarPracticeCardChanges != null)
                model.TodoItems = guitarPracticeCardChanges.TodoList;
            return View(model);
        }

        public IActionResult CreateUpdate(TodoListViewModel viewModel) {
            if (ModelState.IsValid) {
                var guitarPracticeCard = guitarRepository.GetGuitarPracticeCard(viewModel.DateStr);
                GuitarPracticeCard guitarPracticeCardChanges = new GuitarPracticeCard {
                    DateStr = viewModel.DateStr,
                    Summary = viewModel.Summary,
                    TodoList = new List<TodoListItem>()
                };
                guitarPracticeCardChanges.TodoList.Add(viewModel.EditableItem);

                if (guitarPracticeCard == null) {
                    guitarRepository.AddGuitarPracticeCard(guitarPracticeCardChanges);
                } else {
                    guitarRepository.UpdateGuitarPracticeCard(guitarPracticeCardChanges);
                }
                return RedirectToAction("ToDoList", "Home",  new { dateStr = viewModel.DateStr });
            } 
            return View("ToDoList", viewModel);
        }

        [Route("{dateStr}/{id}")]
        public IActionResult Delete(string dateStr, int id) {
            TodoListItem item = guitarRepository.GetTodoListItem(id);
            if (item != null) {
                guitarRepository.DeleteTodoListItem(id);
                return RedirectToAction("ToDoList", "Home", new { dateStr = dateStr });
            }
            return RedirectToAction("ToDoList", "Home", new { dateStr = dateStr });
        }

        [Route("{dateStr}/{id}")]
        public IActionResult ToggleIsDone(string dateStr, int id) {
            TodoListItem item = guitarRepository.GetTodoListItem(id);
            if (item != null) {
                item.IsDone = !item.IsDone;
                guitarRepository.UpdateTodoListItem(item);
            }
            return RedirectToAction("ToDoList", "Home", new { dateStr = dateStr });
        }

    }
}
