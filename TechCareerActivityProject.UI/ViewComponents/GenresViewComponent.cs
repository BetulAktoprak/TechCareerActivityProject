using Microsoft.AspNetCore.Mvc;
using TechCareerActivityProject.DAL.Data;
using TechCareerActivityProject.DAL.Models;

namespace TechCareerActivityProject.UI.ViewComponents
{
    public class GenresViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            
            return View(GenreRepository.Genres);
        }
    }
}
