using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechCareerActivityProject.DAL.Models;

namespace TechCareerActivityProject.DAL.Data
{
    public class GenreRepository
    {
        private static readonly List<Genre> _genres = null;

        static GenreRepository()
        {
            _genres = new List<Genre>()
            {
                new Genre {Id = 1, Name = "Konser"},
                new Genre {Id = 2, Name = "Festival"},
                new Genre {Id = 3, Name = "Sahne"},
                new Genre {Id = 4, Name = "Sergi"}
            };

        }

        public static List<Genre> Genres
        {
            get
            {
                return _genres;
            }
        }

        public static Genre GetById(int id)
        {
            return _genres.FirstOrDefault(c => c.Id == id);
        }
    }
}
