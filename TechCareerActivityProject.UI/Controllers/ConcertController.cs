using Microsoft.AspNetCore.Mvc;
using TechCareerActivityProject.BLL.Services.Interfaces;
using TechCareerActivityProject.BLL.Services.Repositories;
using TechCareerActivityProject.DAL.Data;
using TechCareerActivityProject.DAL.Models;

namespace TechCareerActivityProject.UI.Controllers
{
    public class ConcertController : Controller
    {

        public IActionResult Index()
        {
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
