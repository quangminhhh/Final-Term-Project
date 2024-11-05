using Microsoft.AspNetCore.Mvc;
using Final_Term_Project.Models;

namespace Final_Term_Project.Controllers
{
    public class LinkedListController : Controller
    {
        private static CircularLinkedListModel<int> linkedList = new CircularLinkedListModel<int>();

        public IActionResult Index()
        {
            return View("LinkedListPage");
        }

        [HttpPost]
        public IActionResult AddNode([FromBody] int value)
        {
            linkedList.AddLast(value);
            return Json(linkedList.ToList());
        }

        [HttpPost]
        public IActionResult DeleteFirstNode()
        {
            linkedList.DeleteFirst();
            return Json(linkedList.ToList());
        }

        [HttpPost]
        public IActionResult DeleteLastNode()
        {
            linkedList.DeleteLast();
            return Json(linkedList.ToList());
        }

        [HttpGet]
        public IActionResult GetNodes()
        {
            return Json(linkedList.ToList());
        }
    }
}