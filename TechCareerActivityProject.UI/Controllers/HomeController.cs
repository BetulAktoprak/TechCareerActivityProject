using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TechCareerActivityProject.DAL.Models;
using TechCareerActivityProject.UI.Models;

namespace TechCareerActivityProject.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var concertList = new List<Concert>()
            {
                new Concert
                {
                    Id = 1,
                    ConcertName = "INNELLEA",
                    ConcertDescription = "Elektronik Müzik",
                    ConcertTime = "10 Şubat Cumartesi",
                    ConcertLocation = "Zorlu PSM",
                    ConcertImage = "innellea-web-mx3vo2qjss57-crop-480-480.jpg"
                },
                new Concert
                {
                    Id = 6,
                    ConcertName = "BERKAY",
                    ConcertDescription = "Pop Müzik",
                    ConcertTime = "10 Şubat Cumartesi",
                    ConcertLocation = "Bostancı Gösteri Merkezi",
                    ConcertImage = "ab6761610000e5ebefc7e159821a28351587cfba.jpg"
                },
                 new Concert
                {
                     Id = 2,
                    ConcertName = "SILA",
                    ConcertDescription = "Pop Müzik",
                    ConcertTime = "14 Şubat Çarşamba",
                    ConcertLocation = "Zorlu PSM",
                    ConcertImage = "channels4_profile.jpg"
                },
                new Concert
                {
                    Id = 3,
                    ConcertName = "MABEL MATİZ",
                    ConcertDescription = "Pop Müzik",
                    ConcertTime = "14 Şubat Çarşamba",
                    ConcertLocation = "Volkswagen Arena",
                    ConcertImage = "mabel.jpg"
                }
            };
            var festivalList = new List<Festival>()
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
                }
            };
            var stageList = new List<Stage>()
            {
                new Stage
                {
                    Id = 1,
                    StageName = "CİMRİ",
                    StageDescription = "Tiyatro",
                    StageTime = "14 Şubat Çarşamba",
                    StageLocation = "Maximum UNIQ Hall",
                    StageImage = "0000190_cimri.jpg"
                },
                new Stage
                {
                    Id = 2,
                    StageName = "AYDINLIKEVLER",
                    StageDescription = "Tiyatro",
                    StageTime = "15 Şubat Perşembe",
                    StageLocation = "Bostancı Gösteri Merkezi",
                    StageImage = "aydinlikevler-yatay.jpg"
                },
                new Stage
                {
                    Id = 3,
                    StageName = "ZENGİN MUTFAĞI",
                    StageDescription = "Tiyatro",
                    StageTime = "16 Şubat Cuma",
                    StageLocation = "Maximum UNIQ Hall",
                    StageImage = "zengin-mutfagi-04.jpg"
                },
                new Stage
                {
                    Id = 4,
                    StageName = "MONTAİGNE",
                    StageDescription = "Tiyatro",
                    StageTime = "17 Şubat Cumartesi",
                    StageLocation = "Oda Tiyatrosu",
                    StageImage = "396024018_18391995217028468_7905172375322033882_n-2-1024x574.jpg"
                }
            };
            var exhibitionList = new List<Exhibition>()
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
                    Id = 5,
                    ExhibitionName = "RENKLİ ANADOLU",
                    ExhibitionDescription = "Sergi",
                    ExhibitionTime = "7 Nisan'a Kadar",
                    ExhibitionLocation = "Ara Güler Müzesi",
                    ExhibitionImage = "1695900048_Anamur__Mersin__1982.jpg"
                },
                new Exhibition
                {
                    Id = 7,
                    ExhibitionName = "KENDİ GÖLGESİNDE",
                    ExhibitionDescription = "Sergi",
                    ExhibitionTime = "7 Nisan'a Kadar",
                    ExhibitionLocation = "Arter",
                    ExhibitionImage = "aac10b45914a69ae7bc7db3abf5d6bab.jpg"
                }
            };
            var ımageList = new List<HomeImage>()
            {
                new HomeImage
                {
                    ImageUrl = "perdenin-ardindakiler-konseri-37379.jpg",
                    Link = "#"
                },
                new HomeImage
                {
                    ImageUrl = "gokhan-turkmen-202312281545432a30a0a4c2154d1196355b71880f6039.jpg",
                    Link = "#"
                },
                new HomeImage
                {
                    ImageUrl = "PIylWQIplEaSkhX4yhTxQA.jpg",
                    Link = "#"
                },
                new HomeImage
                {
                    ImageUrl = "unnamed.jpg",
                    Link = "#"
                },
                new HomeImage
                {
                    ImageUrl = "b48f5c93c5d492fdb8c5b4108741450b.jpg",
                    Link = "#"
                },
                new HomeImage
                {
                    ImageUrl = "Sefo.jpg",
                    Link = "#"
                },
                new HomeImage
                {
                    ImageUrl = "ab67616d0000b273f22f0a3ab76b923df54b73b0.jpg",
                    Link = "#"
                }
            };
            var viewModel = new Home
            {
                ConcertList = concertList,
                FestivalList = festivalList,
                StageList = stageList,
                ExhibitionList = exhibitionList,
                ImageList = ımageList
            };
            return View(viewModel);
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
