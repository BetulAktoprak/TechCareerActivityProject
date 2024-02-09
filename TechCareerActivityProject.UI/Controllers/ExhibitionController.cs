using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using TechCareerActivityProject.DAL.Data;
using TechCareerActivityProject.DAL.Models;

namespace TechCareerActivityProject.UI.Controllers
{
    public class ExhibitionController : Controller
    {
        public IActionResult Index(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                var filteredExhibition = ExhibitionRepository.FilterExhibition(value);

                return View("Index", new Home { ExhibitionList = filteredExhibition });
            }
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