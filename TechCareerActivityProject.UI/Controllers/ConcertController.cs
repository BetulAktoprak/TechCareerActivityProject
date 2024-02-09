using Microsoft.AspNetCore.Mvc;
using TechCareerActivityProject.BLL.Services.Interfaces;
using TechCareerActivityProject.BLL.Services.Repositories;
using TechCareerActivityProject.DAL.Data;
using TechCareerActivityProject.DAL.Models;

namespace TechCareerActivityProject.UI.Controllers
{
    public class ConcertController : Controller
    {

        public IActionResult Index(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                var filteredConcerts = ConcertRepository.FilterConcerts(value);
               
                return View("Index", new Home { ConcertList = filteredConcerts });
            }
            var model = new Home()
            {
                ConcertList = ConcertRepository.Concerts
            };
            return View(model);
        }

        public IActionResult Details(int id)
        {
            return View(ConcertRepository.GetById(id));
        }

       
    }
}
