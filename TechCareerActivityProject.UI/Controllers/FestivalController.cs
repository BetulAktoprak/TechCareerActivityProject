using Microsoft.AspNetCore.Mvc;
using TechCareerActivityProject.DAL.Data;
using TechCareerActivityProject.DAL.Models;

namespace TechCareerActivityProject.UI.Controllers
{
    public class FestivalController : Controller
    {
        public IActionResult Index()
        {
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
