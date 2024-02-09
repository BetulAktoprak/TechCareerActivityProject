using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechCareerActivityProject.DAL.Models;

namespace TechCareerActivityProject.DAL.Data
{
    public class FestivalRepository
    {
        private static readonly List<Festival> _festivals = null;

        static FestivalRepository()
        {
            _festivals = new List<Festival>()
            {
                new Festival
                {
                    Id = 1,
                    FestivalName = "SONAR ISTANBUL 2024",
                    FestivalDescription = "Festival",
                    FestivalTime = "26-28 Nisan",
                    FestivalLocation = "Zorlu PSM",
                    FestivalImage = "86b347b9-f785-4204-b5f1-33240cfde830.jpg"
                },
                new Festival
                {
                    Id = 2,
                    FestivalName = "HOLIFEST",
                    FestivalDescription = "Festival",
                    FestivalTime = "25-27 Mayıs",
                    FestivalLocation = "Life Park",
                    FestivalImage = "edaae3cf-d08c-47bc-9ebe-6a708efb7ba3.jpg"
                },
                new Festival
                {
                    Id = 3,
                    FestivalName = "AKDENİZ GENÇLİK FESTİVALİ",
                    FestivalDescription = "Festival",
                    FestivalTime = "3-5 Mayıs",
                    FestivalLocation = "Adana",
                    FestivalImage = "indir (1).jpg"
                },
                new Festival
                {
                    Id = 4,
                    FestivalName = "KOCAELİ MÜZİK FESTİVALİ",
                    FestivalDescription = "Festival",
                    FestivalTime = "10-12 Mayıs",
                    FestivalLocation = "Kocaeli",
                    FestivalImage = "kocaeli-muzik-festivali.jpg"
                },
                new Festival
                {
                    Id = 5,
                    FestivalName = "KÜÇÜKÇİFTLİK BARK",
                    FestivalDescription = "Festival",
                    FestivalTime = "12 Mayıs Pazar",
                    FestivalLocation = "KüçükÇiftlik Park",
                    FestivalImage = "DhxaZJ0W0AETOu1.jpg"
                },
                new Festival
                {
                    Id = 6,
                    FestivalName = "GEZGİNFEST",
                    FestivalDescription = "Festival",
                    FestivalTime = "14-16 Haziran",
                    FestivalLocation = "Kocaeli",
                    FestivalImage = "gezginfest.jpg"
                }

            };
        }

        public static List<Festival> Festivals
        {
            get
            {
                return _festivals;
            }
        }

        public static Festival GetById(int id)
        {
            return _festivals.FirstOrDefault(c => c.Id == id);
        }

        public static List<Festival> FilterFestival(string search)
        {
            search = search.ToLower();

            return _festivals.Where(festival => festival.FestivalName.ToLower().Contains(search)).ToList();
        }
    }
}
