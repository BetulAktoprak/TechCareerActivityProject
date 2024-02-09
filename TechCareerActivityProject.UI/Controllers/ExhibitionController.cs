using Microsoft.AspNetCore.Mvc;
using TechCareerActivityProject.DAL.Data;
using TechCareerActivityProject.DAL.Models;

namespace TechCareerActivityProject.UI.Controllers
{
    public class ExhibitionController : Controller
    {
        public IActionResult Index()
        {
            var model = new Home()
            {
                ExhibitionList = ExhibitionRepository.Exhibitions
            };
            return View(model);
        }

        public IActionResult Details(int id)
        {
            return View(ExhibitionRepository.GetById(id));
        }
    }
}