using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using TechCareerActivityProject.DAL.Data;
using TechCareerActivityProject.DAL.Models;

namespace TechCareerActivityProject.UI.Controllers
{
    public class FestivalController : Controller
    {
        public IActionResult Index(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                var filteredFestival = FestivalRepository.FilterFestival(value);

                return View("Index", new Home { FestivalList = filteredFestival });
            }
            var model = new Home()
            {
                FestivalList = FestivalRepository.Festivals
            };
            return View(model);

        }

        public IActionResult Details(int id)
        {
            return View(FestivalRepository.GetById(id));
        }
    }
}
