using Microsoft.AspNetCore.Mvc;
using WEB_253504_PATREBKA.UI.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WEB_253504_PATREBKA.UI.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.LabTitle = "Лабораторная работа 2";

        var selectList = new SelectList(
            new List<ListDemo>
            {
                new ListDemo {Id = 1, Name = "Выбор 1"},
                new ListDemo {Id = 2, Name = "Выбор 2"},
                new ListDemo {Id = 3, Name = "Выбор 3"},
            },
            "Id",
            "Name"
        );

        return View(selectList);
    }
}
