using Microsoft.AspNetCore.Mvc;
using TechCareerActivityProject.DAL.Data;
using TechCareerActivityProject.DAL.Models;

namespace TechCareerActivityProject.UI.Controllers
{
    public class StageController : Controller
    {
        public IActionResult Index()
        {
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
