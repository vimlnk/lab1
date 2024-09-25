using System.Diagnostics;
using lab1.Models;
using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Mvc;


namespace lab1.Controllers
{
	public class HomeController : Controller
	{
		// Метод для обробки запиту на головну сторінку
		public IActionResult Index()
		{
			// Передаємо дані через ViewBag
			ViewBag.Name = "Мельник Вікторія ";
			ViewBag.Group = "Група: ІПЗ-22-1, ВУЗ: Хмельницький національний університет";
			ViewBag.ProjectTopic = "Інтернет- магазин з продажу книг ";

			return View();
		}
	}
}
