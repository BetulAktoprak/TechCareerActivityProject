using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechCareerActivityProject.DAL.Models;

namespace TechCareerActivityProject.DAL.Data
{
    public class ExhibitionRepository
    {
        private static readonly List<Exhibition> _exhibitions = null;

        static ExhibitionRepository()
        {
            _exhibitions = new List<Exhibition>()
            {
                new Exhibition
                {
                    Id = 1,
                    ExhibitionName = "MAT COLLISHAW: ARİTMİ",
                    ExhibitionDescription = "Sergi",
                    ExhibitionTime = "18 Ağustos'a Kadar",
                    ExhibitionLocation = "Borusan Contemporary",
                    ExhibitionImage = "mat_collishaw_heterosis.jpg"
                },
                new Exhibition
                {
                    Id = 2,
                    ExhibitionName = "YAŞASIN CUMHURİYET",
                    ExhibitionDescription = "Sergi",
                    ExhibitionTime = "31 Aralık'a Kadar",
                    ExhibitionLocation = "İş Bankası Müzesi",
                    ExhibitionImage = "yasasin-cumhuriyet-is-sanat-1.jpg"
                },
                new Exhibition
                {
                    Id = 3,
                    ExhibitionName = "TAM YERİNDEN",
                    ExhibitionDescription = "Sergi",
                    ExhibitionTime = "25 Şubat'a Kadar",
                    ExhibitionLocation = "Pera Müzesi",
                    ExhibitionImage = "tam-yerinden-1.jpg"
                },
                new Exhibition
                {
                    Id = 4,
                    ExhibitionName = "GELECEK HATIRALARI",
                    ExhibitionDescription = "Sergi",
                    ExhibitionTime = "25 Şubat'a Kadar",
                    ExhibitionLocation = "Pera Müzesi",
                    ExhibitionImage = "GH_salon_0051.jpg"
                },
                new Exhibition
                {
                    Id = 5,
                    ExhibitionName = "RENKLİ ANADOLU",
                    ExhibitionDescription = "Sergi",
                    ExhibitionTime = "7 Nisan'a Kadar",
                    ExhibitionLocation = "Ara Güler Müzesi",
                    ExhibitionImage = "1695900048_Anamur__Mersin__1982.jpg"
                },
                new Exhibition
                {
                    Id = 6,
                    ExhibitionName = "SPEKTRUM",
                    ExhibitionDescription = "Sergi",
                    ExhibitionTime = "31 Mart'a Kadar",
                    ExhibitionLocation = "Salt Beyoğlu",
                    ExhibitionImage = "13149.jpg"
                },
                new Exhibition
                {
                    Id = 7,
                    ExhibitionName = "KENDİ GÖLGESİNDE",
                    ExhibitionDescription = "Sergi",
                    ExhibitionTime = "7 Nisan'a Kadar",
                    ExhibitionLocation = "Arter",
                    ExhibitionImage = "aac10b45914a69ae7bc7db3abf5d6bab.jpg"
                },
                new Exhibition
                {
                    Id = 8,
                    ExhibitionName = "DÖRTNALA",
                    ExhibitionDescription = "Sergi",
                    ExhibitionTime = "1 Mart'a Kadar",
                    ExhibitionLocation = "Gallery 11.17",
                    ExhibitionImage = "indir (9).jpg"
                }

            };
        }

        public static List<Exhibition> Exhibitions
        {
            get
            {
                return _exhibitions;
            }
        }

        public static Exhibition GetById(int id)
        {
            return _exhibitions.FirstOrDefault(c => c.Id == id);
        }
    }
}
