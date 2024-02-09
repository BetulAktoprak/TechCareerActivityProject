using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using TechCareerActivityProject.DAL.Data;
using TechCareerActivityProject.DAL.Models;

namespace TechCareerActivityProject.UI.Controllers
{
    public class StageController : Controller
    {
        public IActionResult Index(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                var filteredStage = StageRepository.FilterStage(value);

                return View("Index", new Home { StageList = filteredStage });
            }
            var model = new Home()
            {
                StageList = StageRepository.Stages
            };
            return View(model);
        }

        public IActionResult Details(int id)
        {
            return View(StageRepository.GetById(id));
        }
    }
}
