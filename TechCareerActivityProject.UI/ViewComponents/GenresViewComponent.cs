using Microsoft.AspNetCore.Mvc;
using TechCareerActivityProject.DAL.Models;

namespace TechCareerActivityProject.UI.ViewComponents
{
    public class GenresViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var genreList = new List<Genre>()
            {
                new Genre {Name = "Konser"},
                new Genre {Name = "Festival"},
                new Genre {Name = "Sahne"},
                new Genre {Name = "Sergi"}
            };
            return View(genreList);
        }
    }
}
